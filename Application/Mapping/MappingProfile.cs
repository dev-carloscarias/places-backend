namespace Places.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Currency, CurrencyDto>();
        CreateMap<CurrencyDto, Currency>();

        CreateMap<Country, CountryDto>()
            .ForMember(d => d.Iso2, map => map.MapFrom(op => $"{op.Iso2.ToLower()}"))
            .ForMember(d => d.CountryCode, map => map.MapFrom(op => $"+{op.CountryCode}"))
            .ForMember(d => d.Iso3, map => map.MapFrom(op => op.Iso3.ToLower()));
        CreateMap<CountryDto, Country>();

        CreateMap<Screen, ScreenDto>();
        CreateMap<ScreenDto, Screen>();

        CreateMap<Label, LabelDto>();
        CreateMap<LabelDto, Label>();

        CreateMap<User, RegisterDto>();
        CreateMap<RegisterDto, User>();

        CreateMap<UserType, UserTypeDto>().ReverseMap();

        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();

        CreateMap<User, OwnerDetailRegistrationDto>();

        CreateMap<DataFile, DataFileDto>().ReverseMap();

        CreateMap<CategoryDto, Category>().ReverseMap();

        CreateMap<Availability, AvailabilityDto>().ReverseMap();
        CreateMap<Amenity, AmenityDto>().ReverseMap();
        CreateMap<Site, SiteDto>()
        // Mapear precios y capacidad
        .ForMember(dest => dest.AdultPrice, opt => opt.MapFrom(src => src.AdultPrice))
        .ForMember(dest => dest.ChildPrice, opt => opt.MapFrom(src => src.ChildPrice))
        .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
        // Mapear las fotos (DataFiles -> Photos)
        .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.DataFiles))
        // Mapear las políticas del sitio
         .ForMember(
             dest => dest.SitePolicies,
             opt => opt.MapFrom(src => ConvertSitePolicies(src.SitePolicies))
         )
         .ForMember(dest => dest.SelectedDates,
               opt => opt.MapFrom(src => src.SelectedDates.Split(';', StringSplitOptions.RemoveEmptyEntries)
                                             .Select(date => DateTime.Parse(date))
                                             .ToList()))
        // Mapear opciones de transporte seleccionadas
        .ForMember(dest => dest.SelectedTransportOptions, opt => opt.MapFrom(src =>
            src.SelectedTransportOptions.Select(sto => new SelectedTransportOptionDto
            {
                Id = sto.Id,
                TransportOptionId = sto.TransportOptionId,
                Name = sto.TransportOption != null ? sto.TransportOption.Name : string.Empty,
                ImageUrl = sto.TransportOption != null ? sto.TransportOption.ImageUrl : string.Empty,
                Price = sto.Price
            }).ToList()))
         .ForMember(dest => dest.Amenities, opt => opt.MapFrom(src =>
                src.AmenityBySites.Select(abs => new AmenityBySiteDto
                {
                    AmenityId = abs.AmenityId,
                    Description = abs.Description,
                    SiteId = abs.SiteId
                }).ToList()
            ));

        CreateMap<SiteDto, Site>()
            // Mapear fotos (Photos -> DataFiles)
            .ForMember(dest => dest.DataFiles, opt => opt.MapFrom(src => src.Photos))
            // Mapear las políticas del sitio (lista -> cadena separada por comas)
            .ForMember(dest => dest.SitePolicies, opt => opt.MapFrom(src => string.Join(",", src.SitePolicies)))
            .ForMember(dest => dest.SelectedDates,
               opt => opt.MapFrom(src => string.Join(";", src.SelectedDates.Select(date => date.ToString("yyyy-MM-dd")))))
            // Mapear la relación con AmenityBySites
            .ForMember(dest => dest.AmenityBySites, opt => opt.MapFrom(src =>
                src.Amenities.Select(amenity => new AmenityBySite
                {
                    AmenityId = amenity.Id,
                    Description = amenity.Description
                }).ToList()
            ))
            // Ignorar opciones de transporte seleccionadas (si no se procesan directamente aquí)
            .ForMember(dest => dest.SelectedTransportOptions, opt => opt.MapFrom(src =>
                    src.SelectedTransportOptions.Select(sto => new SelectedTransportOption
                    {
                        TransportOptionId = sto.TransportOptionId,
                        Price = sto.Price
                    }).ToList()));


        CreateMap<SelectedTransportOption, SelectedTransportOptionDto>()
            .ForMember(dto => dto.Name, opt => opt.MapFrom(entity => entity.TransportOption.Name));

        CreateMap<Language, LanguageDto>().ReverseMap();

        CreateMap<TransportOption, TransportOptionDto>().ReverseMap();

        CreateMap<SpecialPackageDto, SpecialPackage>()
            .ForMember(d => d.PackageItems, opt => opt.MapFrom(m => m.PackageItems));

        CreateMap<SpecialPackage, SpecialPackageDto>()
            .ForMember(d => d.PackageItems, opt => opt.MapFrom(m => m.PackageItems));

        CreateMap<PackageItemDto, PackageItem>();
        CreateMap<PackageItem, PackageItemDto>();

        CreateMap<AdditionalCostDto, AdditionalCost>();
        CreateMap<AdditionalCost, AdditionalCostDto>();
        CreateMap<UserDto, User>()
            .ForMember(dest => dest.Hobbies, opt => opt.MapFrom(src => src.Hobbies));
        CreateMap<HobbieDto, Hobbie>();
        CreateMap<Hobbie, HobbieDto>();

        CreateMap<Comment, CommentDto>();

        CreateMap<CommentDto, Comment>()
            .ForMember(dest => dest.User, opt => opt.Ignore())
            .ForMember(dest => dest.Site, opt => opt.Ignore());

        CreateMap<Rating, RatingDto>();
        CreateMap<RatingDto, Rating>()
            .ForMember(r => r.User, opt => opt.Ignore())
            .ForMember(r => r.Site, opt => opt.Ignore());
        CreateMap<ChatConversation, ChatConversationDto>()
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
        .ForMember(dest => dest.UserOneId, opt => opt.MapFrom(src => src.UserOneId))
        .ForMember(dest => dest.UserTwoId, opt => opt.MapFrom(src => src.UserTwoId))
        .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
        .ForMember(dest => dest.MessageCount, opt => opt.Ignore())
        .ReverseMap();

        // Mapeo de ChatConversation a ChatConversationDto
        CreateMap<ChatMessage, ChatMessageDto>()
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
        .ForMember(dest => dest.IsRead, opt => opt.MapFrom(src =>
            src.UserChatMessages.Any(um => !um.IsDeleted)))
        .ForMember(dest => dest.ChatConversationId, opt => opt.MapFrom(src => src.ChatConversationId))
        .ForMember(dest => dest.SenderUserId, opt => opt.MapFrom(src => src.SenderUserId))
        .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
        .ForMember(dest => dest.SentAt, opt => opt.MapFrom(src => src.SentAt))
        .ReverseMap();

        // Mapeo de ChatMessage a ChatMessageDto
        CreateMap<ChatMessage, ChatMessageDto>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.IsRead, opt => opt.MapFrom(src =>
               src.UserChatMessages.Any(um => !um.IsDeleted)))
           .ForMember(dest => dest.ChatConversationId, opt => opt.MapFrom(src => src.ChatConversationId))
           .ForMember(dest => dest.SenderUserId, opt => opt.MapFrom(src => src.SenderUserId))
           .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
           .ForMember(dest => dest.SentAt, opt => opt.MapFrom(src => src.SentAt))
           .ReverseMap();
    }

    private static List<string> ConvertSitePolicies(string? sitePolicies)
    {
        if (string.IsNullOrEmpty(sitePolicies))
        {
            return new List<string>();
        }
        return sitePolicies.Split(',').ToList();
    }

}