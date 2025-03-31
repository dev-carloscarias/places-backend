using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adding Serilog Configuration
builder.Host.AddSerilog(builder.Configuration);
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

// Add Authentication
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = true;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtBearer:Issuer"],
        ValidAudience = builder.Configuration["JwtBearer:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtBearer:SecretKey"]!))
    };
});

// Add the DB Context
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers()
    /*.AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))*/;
builder.Services.AddMemoryCache();

builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errorDetails = context.ConstructErrorMessages();
        return new BadRequestObjectResult(errorDetails);
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.UseInlineDefinitionsForEnums();

    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Places.WebApi.Api", Version = "v1.0" });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Please enter into field the word 'Bearer' following by space and JWT",
        Type = SecuritySchemeType.ApiKey
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });

    var xmlFiles = Directory.GetFiles(Path.Combine(AppContext.BaseDirectory), "*.xml");
    foreach (var filePath in xmlFiles)
    {
        options.IncludeXmlComments(filePath);
    }
});

//HostingEnvironment hostingEnvironment = new HostingEnvironment();

builder.Services.AddAuthentication()
    .AddFacebook(fb =>
    {
        fb.AppId = builder.Configuration["AuthenticatonProviders:FacebookAppId"] ?? string.Empty;
        fb.AppSecret = builder.Configuration["AuthenticatonProviders:FacebookAppSecret"] ?? string.Empty;
        fb.SaveTokens = true;
    })
    .AddGoogle(g =>
    {
        g.ClientId = builder.Configuration["AuthenticatonProviders:GoogleClientId"] ?? string.Empty;
        g.ClientSecret = builder.Configuration["AuthenticatonProviders:GoogleClientSecret"] ?? string.Empty;
        g.SaveTokens = true;
    })
    /*.AddApple(a =>
    {
        a.ClientId = builder.Configuration["AuthenticatonProviders:AppleClientId"] ?? string.Empty;
        a.KeyId = builder.Configuration["AuthenticatonProviders:AppleKeyId"] ?? string.Empty;
        a.TeamId = builder.Configuration["AuthenticatonProviders:AppleTeamId"] ?? string.Empty;
        a.UsePrivateKey(keyId
            => hostingEnvironment.ContentRootFileProvider.GetFileInfo($"AuthKey_{keyId}.p8"));
        a.SaveTokens = true;
    })*/;

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties;
});

builder.Services.AddFluentValidationRulesToSwagger();

// Add Authorization Methods
builder.Services.AddAuthorization();

// Add Modules
builder.Services.AddMapping();
builder.Services.AddValidators();
builder.Services.AddRepositories();
builder.Services.AddServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Lax;
    options.Secure = CookieSecurePolicy.None;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownProxies.Add(IPAddress.Parse("127.0.0.1"));
});

var app = builder.Build();

app.UseCors("AllowAll");
app.UseForwardedHeaders();
app.UseHttpLogging();
app.UseMiddleware<GlobalValuesMiddleware>();
app.MapControllers();
app.MapHub<ChatHub>("/chatHub");
app.MapHub<NotificationHub>("/notificationHub");

app.Use(async (context, next) =>
{
    // Connection: RemoteIp
    app.Logger.LogInformation("Request RemoteIp: {RemoteIpAddress}",
        context.Connection.RemoteIpAddress);

    await next(context);
});

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseSerilogRequestLogging();

// Add the Exception Middleware Handler
app.UseExceptionMiddleware();

app.UseLocalizationMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();


app.Run();

[ExcludeFromCodeCoverage]
public static partial class Program;