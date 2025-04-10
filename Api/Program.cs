using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adding Serilog Configuration
builder.Host.AddSerilog(builder.Configuration);
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

// Configura el puerto dinámicamente para Azure
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080"; // Usa el puerto de Azure o 8080 como respaldo
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(int.Parse(port));
});

// Add Authentication
var secretKey = builder.Configuration["JwtBearer:SecretKey"];
if (string.IsNullOrEmpty(secretKey))
{
    throw new InvalidOperationException("JwtBearer:SecretKey is not configured in appsettings.json or environment variables.");
}

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
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };
});

// Add the DB Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
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

// Configura SignalR
builder.Services.AddSignalR();

// Configura autenticación con Facebook y Google (comenta si no lo usas)
builder.Services.AddAuthentication()
    .AddFacebook(fb =>
    {
        var appId = builder.Configuration["AuthenticatonProviders:FacebookAppId"];
        var appSecret = builder.Configuration["AuthenticatonProviders:FacebookAppSecret"];
        if (string.IsNullOrEmpty(appId) || string.IsNullOrEmpty(appSecret))
        {
            throw new InvalidOperationException("Facebook authentication credentials are not configured.");
        }
        fb.AppId = appId;
        fb.AppSecret = appSecret;
        fb.SaveTokens = true;
    })
    .AddGoogle(g =>
    {
        var clientId = builder.Configuration["AuthenticatonProviders:GoogleClientId"];
        var clientSecret = builder.Configuration["AuthenticatonProviders:GoogleClientSecret"];
        if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
        {
            throw new InvalidOperationException("Google authentication credentials are not configured.");
        }
        g.ClientId = clientId;
        g.ClientSecret = clientSecret;
        g.SaveTokens = true;
    });

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

// Configura CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.WithOrigins("https://nice-pond-01f64d51e.5.azurestaticapps.net")
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials()); // Necesario para SignalR y autenticación
});

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownProxies.Add(IPAddress.Parse("127.0.0.1"));
});

// Habilita logging detallado para depuración
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddDebug();
    logging.SetMinimumLevel(LogLevel.Debug);
});

var app = builder.Build();
app.UseForwardedHeaders();
app.UseHttpLogging();
app.UseMiddleware<GlobalValuesMiddleware>();

// Maneja solicitudes OPTIONS explícitamente para evitar errores CORS
app.Use(async (context, next) =>
{
    if (context.Request.Method == "OPTIONS")
    {
        context.Response.StatusCode = StatusCodes.Status200OK;
        context.Response.Headers.Add("Access-Control-Allow-Origin", context.Request.Headers["Origin"]);
        context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
        context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
        context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
        context.Response.Headers.Add("Access-Control-Max-Age", "86400");
        return;
    }
    await next();
});

app.UseCors("AllowAll");

app.MapControllers();
app.MapHub<ChatHub>("/chatHub");
app.MapHub<NotificationHub>("/notificationHub");

app.Use(async (context, next) =>
{
    app.Logger.LogInformation("Request RemoteIp: {RemoteIpAddress}", context.Connection.RemoteIpAddress);
    await next(context);
});

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseSerilogRequestLogging();

// Add the Exception Middleware Handler
app.UseExceptionMiddleware();

app.UseLocalizationMiddleware();

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Run();

[ExcludeFromCodeCoverage]
public static partial class Program;