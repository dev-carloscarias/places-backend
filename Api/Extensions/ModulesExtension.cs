using Places.Application.Interfaces;

namespace Places.Api.Extensions;

public static class ModulesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IDataService, DataService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICurrencyService, CurrencyService>();
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<ITranslateService, TranslateService>();
        services.AddScoped<ILocalizationService, LocalizationService>();
        services.AddScoped<IScreenService, ScreenService>();
        services.AddScoped<ILabelService, LabelService>();
        services.AddScoped<IResourceService, ResourceService>();
        services.AddScoped<ITemporaryImageRepository, TemporaryImageRepository>();
        services.AddScoped<ITemporaryImageService, TemporaryImageService>();
        services.AddScoped<ITransportOptionService, TransportOptionService>();
        services.AddScoped<IRegionService, RegionService>();
        services.AddScoped<ICommentsService, CommentsService>();
        services.AddScoped<IRatingService, RatingService>();
        services.AddScoped<INotificationsService, NotificationsService>();

        services.AddScoped<ISmsService, SmsService>();

        services.AddScoped<IAmenityBySiteService, AmenityBySiteService>();
        services.AddScoped<IAmenityService, AmenityService>();
        services.AddScoped<ISiteService, SiteService>();
        services.AddScoped<ICurrencyConversion, CurrencyConversion>();
        services.AddScoped<IGlobalValuesAccessor, GlobalValuesAccessor>();
        services.AddScoped<IDataFileService, DataFileService>();
        services.AddScoped<IChatService, ChatService>();

        services.Configure<GlobalValues>(options =>
        {
            options.CurrencyId = 138;
        });

        services.AddSingleton<IGlobalValuesAccessor, GlobalValuesAccessor>();

        services.AddHttpClient<IAzureTranslationClientService, AzureTranslationClientService>();
        services.AddScoped<ITranslationService, TranslationService>();

        services.Configure<AzureTranslationSettings>(configuration.GetSection("AzureTranslationSettings"));

        services.AddSignalR();
        

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContinentRepository, ContinentRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ITranslateRepository, TranslateRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserTypeRepository, UserTypeRepository>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<ITranslateRepository, TranslateRepository>();
        services.AddScoped<IScreenRepository, ScreenRepository>();
        services.AddScoped<ILabelRepository, LabelRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IDataFileRepository, DataFileRepository>();
        services.AddScoped<IAmenityRepository, AmenityRepository>();
        services.AddScoped<IAmenityBySiteRepository, AmenityBySiteRepository>();
        services.AddScoped<ISiteRepository, SiteRepository>();
        services.AddScoped<ITransportOptionRepository, TransportOptionRepository>();
        services.AddScoped<IRegionRepository, RegionRepository>();
        services.AddScoped<ICommentsRepository, CommentsRepository>();
        services.AddScoped<IRatingRepository, RatingRepository>();
        services.AddScoped<IChatConversationRepository, ChatConversationRepository>();
        services.AddScoped<IChatMessageRepository, ChatMessageRepository>();
        services.AddScoped<IUserChatMessageRepository, UserChatMessageRepository>();
        services.AddScoped<INotificationsRepository, NotificationsRepository>();

        return services;
    }

    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<RegisterDto>, RegisterValidator>();
        services.AddScoped<IValidator<LoginInputDto>, LoginInputDtoValidator>();
        return services;
    }

    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddLocalization(options => options.ResourcesPath = "Resources");
        services.Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("en"),
                        new CultureInfo("fr"),
                        new CultureInfo("es"),
                        new CultureInfo("it"),
                        new CultureInfo("pt")
                    };

            options.DefaultRequestCulture = new RequestCulture("es");
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;
        });
        return services;
    }

    public static IServiceCollection AddMapping(this IServiceCollection services)
    {
        // Auto Mapper Configurations
        var mapperConfig = new MapperConfiguration(mc => mc.AddProfile(new MappingProfile()));

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        return services;
    }
}