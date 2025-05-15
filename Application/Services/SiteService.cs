using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using Places.Application.Dtos;
using Places.Application.Dtos.Site;
using Places.Application.Interfaces;
using Places.Domain.Entities;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Places.Application.Services;

public class SiteService : ISiteService
{
    private readonly ISiteRepository _siteRepository;

    private readonly ILocalizationService _localizationService;

    private readonly ITranslateService _translateService;

    private readonly ILanguageService _languageService;

    private readonly ITranslationService _translationService;

    private readonly ITranslateRepository _translateRepository;

    private readonly ICountryRepository _countryRepository;

    private readonly ICurrencyConversion _currencyConversion;

    private readonly IGlobalValuesAccessor _globalValuesAccessor;

    private readonly IUserRepository _userRepository;

    private readonly IEmailService _emailService;
    private readonly IUserService _userService;
    private readonly ICurrentUserService _currentUserService;
    private readonly INotificationsService _notificationsService;
    private readonly IHubContext<NotificationHub> _notificationHubContext;

    private readonly IDataService _dataService;
    private readonly IMemoryCache _cache;


    public SiteService(ISiteRepository siteRepository, ILocalizationService localizationService,
        ITranslateService translateService, ILanguageService languageService, ITranslationService translationService,
        ITranslateRepository translateRepository, ICountryRepository countryRepository, ICurrencyConversion currencyConversion,
        IGlobalValuesAccessor globalValuesAccessor, IUserRepository userRepository, IEmailService emailService, ICurrentUserService currentUserService, 
        IDataService dataService, IMemoryCache cache, INotificationsService notificationsService, IHubContext<NotificationHub> notificationHubContext, IUserService userService)
    {
        _siteRepository = siteRepository;
        _localizationService = localizationService;
        _translateService = translateService;
        _languageService = languageService;
        _translationService = translationService;
        _translateRepository = translateRepository;
        _countryRepository = countryRepository;
        _currencyConversion = currencyConversion;
        _globalValuesAccessor = globalValuesAccessor;
        _userRepository = userRepository;
        _emailService = emailService;
        _currentUserService = currentUserService;
        _dataService = dataService;
        _cache = cache;
        _notificationHubContext = notificationHubContext;
        _notificationsService = notificationsService;
        _userService = userService;
    }

    public async Task<Site> Create(Site model)
    {
        model.IsPendingToApprove = true;
        model.CreatedBy = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0;
        model.UpdatedBy = model.CreatedBy;

        /*var languages = await _languageService.GetAll();
        var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        foreach (var language in languages.Select(d => d.LanguageCode))
        {

            var resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Title });
            model.Translates.Add(new Translate { IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText, FieldName = "Title" });

            resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Description });
            model.Translates.Add(new Translate { IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText, FieldName = "Description" });
        }*/
        var site = await _siteRepository.AddAsync(model);
        //Notificacion al usuario
        var message = "Tu solicitud de registro de sitio ha sido enviada, espera a la resolucion de la administracion de Places.";
        var user = await _userService.GetById(site.UserId);
        var guatemalaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
        var guatemalaTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, guatemalaTimeZone);

        var notification = new Notification
        {
            UserId = site.UserId,
            profilePhoto = user.ProfilePicture,
            Message = message,
            Timestamp = guatemalaTime
        };
        var connectionId = ConnectionMapping.GetConnectionId(model.UserId);
        if (!string.IsNullOrEmpty(connectionId))
        {
            await _notificationHubContext.Clients.Client(connectionId)
                .SendAsync("ReceiveNotification", notification);
        }
        await _notificationsService.CreateNotification(notification);

        //Notificacion a los admins
        var users = await _userService.GetAdminUsers();
        foreach (var userAdmin in users)
        {
            var adminMessage = $"Se ha enviado una solicitud de aprobacion de sitio: {site.Title}";

            var notificationAdmin = new Notification
            {
                UserId = userAdmin.Id,
                profilePhoto = user.ProfilePicture,
                Message = adminMessage,
                Timestamp = guatemalaTime
            };
            var connectionAdmin = ConnectionMapping.GetConnectionId(userAdmin.Id);
            if (!string.IsNullOrEmpty(connectionId))
            {
                await _notificationHubContext.Clients.Client(connectionId)
                    .SendAsync("ReceiveNotification", notificationAdmin);
            }
            await _notificationsService.CreateNotification(notificationAdmin);
        }

        return site;
    }

    public async Task<SiteDto> CreateImages(SiteDto modelDto, IFormCollection formCollection)
    {

        var files = formCollection.Files;
        int index = 0;
        foreach (var file in files)
        {
            if (file.Length > 0)
            {
                using var ms = new MemoryStream();
                await file.CopyToAsync(ms);
                var fileBytes = ms.ToArray();

                var description = formCollection[$"photos[{index}].description"].ToString();
                var section = formCollection[$"photos[{index}].section"].ToString();
                var fileOrderStr = formCollection[$"photos[{index}].fileOrder"].ToString();
                var dataFileTypeStr = formCollection[$"photos[{index}].dataFileType"].ToString();
                var dataTypeExtensionStr = formCollection[$"photos[{index}].dataTypeExtension"].ToString();

                var filePath = await _dataService.UploadBlobFile($"Sites/{Guid.NewGuid()}/{Guid.NewGuid().ToString()}.{dataTypeExtensionStr}", fileBytes);

                int.TryParse(fileOrderStr, out int fileOrder);
                Enum.TryParse<DataFileType>(dataFileTypeStr, out var dataFileType);
                Enum.TryParse<DataTypeExtension>(dataTypeExtensionStr, out var dataTypeExtension);

                var dataFileDto = new DataFileDto
                {
                    Path = filePath,
                    Description = description,
                    Section = section,
                    FileOrder = fileOrder,
                    DataFileType = dataFileType,
                    DataTypeExtension = dataTypeExtension
                };


                modelDto.Photos.Add(dataFileDto);

                index++;
            }
        }

        return modelDto;
    }

    public async Task Delete(int id)
    {
        var original = await _siteRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _siteRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Site> Edit(Site model)
    {
        var id = model.Id;
        var original = await _siteRepository.GetByIdAsync(id);

        if (original is null)
        {
            throw new NotFoundException(LanguageConst.IdNotFound);
        }
        original.UpdatedBy = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0;

        var site = await _siteRepository.UpdateAsync(model);
        var languages = await _languageService.GetAll();
        var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        // foreach (var language in languages.Select(d => d.LanguageCode))
        // {
        //     var resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Title });
        //     _ = _translateService.Create(new Translate { SiteId = site.Id, IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText, FieldName = "Title" });

        //     resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Description });
        //     await _translateService.Create(new Translate { SiteId = site.Id, IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText, FieldName = "Description" });
        // }

        var country = (await _countryRepository.FindAsync(c => c.Id == model.CountryId && !c.IsActive)).FirstOrDefault();
        if (country != null)
        {
            country.IsActive = true;
            await _countryRepository.UpdateAsync(country);
        }

        return site;
    }

    public async Task<IEnumerable<Site>> GetAllActive()
    {
        var amenities = await _siteRepository.FindAllAsync();
        var code = _localizationService.GetLanguage();
        foreach (var amenity in amenities)
        {
            var translation = (await _translateRepository.FindAsync(d => d.CategoryId == amenity.Id && d.LanguageCode == code)).FirstOrDefault();
            if (translation != null) amenity.Title = translation.Translation;

            amenity.AdultPrice = await _currencyConversion.Convert(amenity.CurrencyId, _globalValuesAccessor.GetCurrency(), amenity.AdultPrice);
            amenity.ChildPrice = await _currencyConversion.Convert(amenity.CurrencyId, _globalValuesAccessor.GetCurrency(), amenity.ChildPrice);
            amenity.TransportationPrice = await _currencyConversion.Convert(amenity.CurrencyId, _globalValuesAccessor.GetCurrency(), amenity.TransportationPrice);
        }

        return amenities;
    }

    public async Task<IEnumerable<Site>> GetAll()
    {
        return await _siteRepository.GetAllAsync();
    }

    public async Task<Site> GetByIdandLanguage(int id, string userLanguage)
    {
        var current = await _siteRepository.GetById(id);
        return current;
        var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        if (current is not null)
        {
            try
            {
                var titleTranslated = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = userLanguage, Text = current.Title });
                var descriptionTranslated = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = userLanguage, Text = current.Description });
                current.Title = titleTranslated.TranslatedText;
                current.Description = descriptionTranslated.TranslatedText;
                for (var i = 0; i < current.AmenityBySites.Count; i++)
                {
                    var amenityName = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = userLanguage, Text = current.AmenityBySites.ElementAt(i).Amenity.Name });
                    current.AmenityBySites.ElementAt(i).Amenity.Name = amenityName.TranslatedText;
                }

                current.AdultPrice = await _currencyConversion.Convert(current.CurrencyId, _globalValuesAccessor.GetCurrency(), current.AdultPrice);
                current.TransportationPrice = await _currencyConversion.Convert(current.CurrencyId, _globalValuesAccessor.GetCurrency(), current.TransportationPrice);
                current.ChildPrice = await _currencyConversion.Convert(current.CurrencyId, _globalValuesAccessor.GetCurrency(), current.ChildPrice);
                current.TotalPrice = await _currencyConversion.Convert(current.CurrencyId, _globalValuesAccessor.GetCurrency(), current.TotalPrice);

                return current;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _siteRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Site, bool>> predicate)
    {
        return await _siteRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Site>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _siteRepository.GetByQueryRequestAsync(queryRequest);
    }

    public async Task SiteApprobation(SiteApprobationDto siteApprobationDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteApprobationDto.SiteId);
        if (site is not null)
        {
            site.IsSiteApproved = siteApprobationDto.IsApproved;
            site.IsSiteRejected = !siteApprobationDto.IsApproved;
            site.RejectReason = siteApprobationDto.RejectReason;
            site.IsPendingToApprove = false;
            site.AmenityBySites = site.AmenityBySites
                .GroupBy(a => a.Amenity.Id)
                .Select(g => g.First())
                .ToList();
            site.DataFiles = site.DataFiles
               .GroupBy(df => df.Id)
               .Select(g => g.First())
               .ToList();
            await _siteRepository.UpdateAsync(site);
            var user = await _userRepository.GetByIdAsync(site.UserId);
            if (site.IsSiteApproved)
            {
                var country = (await _countryRepository.FindAsync(c => c.Id == site.CountryId && !c.IsActive)).FirstOrDefault();
                if (country != null)
                {
                    country.IsActive = true;
                    await _countryRepository.UpdateAsync(country);
                }

                
                if (user != null && !user.HasProperties)
                {
                    user.HasProperties = true;
                    await _userRepository.UpdateAsync(user);
                }

                /*if (user is not null)
                    site.User = user;     */
            }

            var message = siteApprobationDto.IsApproved
                        ? $"¡Felicidades! Tu sitio {site.Title} ha sido aprobado."
                        : $"Tu solicitud de publicacion del sitio {site.Title} ha sido rechazada. Razón: {siteApprobationDto.RejectReason}";
            if (user != null)
            {
                await _emailService.SendSiteRegistrationResult(user, message);
                var notification = new Notification
                {
                    UserId = user.Id,
                    profilePhoto = site.DataFiles
                      .OrderBy(df => df.FileOrder)
                      .Select(df => df.Path)
                      .FirstOrDefault(),
                    Message = message,
                    Timestamp = DateTime.UtcNow
                };
                var connectionId = ConnectionMapping.GetConnectionId(user.Id);
                if (!string.IsNullOrEmpty(connectionId))
                {
                    await _notificationHubContext.Clients.Client(connectionId)
                        .SendAsync("ReceiveNotification", notification);
                }

                // Guardar la notificación en la base de datos
                await _notificationsService.CreateNotification(notification);
            }

            //await _emailService.SendSiteRegistrationResult(site);
        }
    }

    public async Task<IEnumerable<Site>> GetAllPendingToApprove()
    {
        var sites = await _siteRepository.GetPendingToApprove();

        var code = _localizationService.GetLanguage();
        foreach (var site in sites)
        {
            var translation = site.Translates.FirstOrDefault(d => d.LanguageCode == code);
            if (translation != null) site.Title = translation.Translation;

            //site.Price = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.Price);
        }

        return sites;
    }

    public async Task<IEnumerable<Site>> GetSitesByOwner(int userId)
    {
        var sites = await _siteRepository.GetSitesbyOwner(userId);

        var code = _localizationService.GetLanguage();
        foreach (var site in sites)
        {
            var translation = site.Translates.FirstOrDefault(d => d.LanguageCode == code);
            if (translation != null) site.Title = translation.Translation;

            //site.Price = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.Price);
        }

        return sites;
    }

    public async Task<IEnumerable<Site>> GetAllByCountry(int countryId)
    {
        var sites = await _siteRepository.GetPendingToApprove();
        var code = _localizationService.GetLanguage();
        foreach (var site in sites)
        {
            var translation = site.Translates.FirstOrDefault(d => d.LanguageCode == code && d.FieldName == "Name");
            if (translation != null) site.Title = translation.Translation;

            translation = site.Translates.FirstOrDefault(d => d.LanguageCode == code && d.FieldName == "Title");
            if (translation != null) site.Title = translation.Translation;

            translation = site.Translates.FirstOrDefault(d => d.LanguageCode == code && d.FieldName == "Description");
            if (translation != null) site.Description = translation.Translation;

            site.AdultPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.AdultPrice);
            site.TransportationPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.TransportationPrice);
            site.ChildPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.ChildPrice);
        }

        return sites;
    }

    public async Task<IEnumerable<Site>> GetAllbyFilter(string language, int countryId, int categoryId, int stateId, string nombre, int pageNumber, int pageSize)
    {
        string cacheKey = $"Sites_{countryId}_{categoryId}_{stateId}_{nombre}_{pageNumber}_{pageSize}";
        if (_cache.TryGetValue(cacheKey, out IEnumerable<Site> cachedSites))
        {
            if (cachedSites != null)
            {
                return cachedSites;

            }
        }
        var sites = await _siteRepository
    .FindAllEficientAsync(
        x => x.IsActive
            && (countryId == -1 || x.CountryId == countryId)
            && (categoryId == -1 || x.CategoryId == categoryId)
            && (stateId == -1 || x.RegionId == stateId)
            && !x.IsPendingToApprove
            && x.IsSiteApproved,
        x => new Site
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            CountryId = x.CountryId,
            CurrencyId = x.CurrencyId,
            TotalPrice = x.TotalPrice,
            UserId = x.UserId,
            RegionId = x.RegionId,
            NewRegionName = x.Region.Name,
            AdultPrice = x.AdultPrice,
            ChildPrice = x.ChildPrice,
            DataFiles = x.DataFiles
                    .OrderBy(df => df.FileOrder)
                    .ToList(),
        },

        pageNumber,
        pageSize);

        var code = _localizationService.GetLanguage();

        foreach (var site in sites)
        {
            var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            var titleTranslated = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = site.Title });
            site.Title = titleTranslated.TranslatedText;

            site.AdultPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.AdultPrice);
            site.TransportationPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.TransportationPrice);
            site.ChildPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.ChildPrice);
            site.TotalPrice = await _currencyConversion.Convert(site.CurrencyId, _globalValuesAccessor.GetCurrency(), site.TotalPrice);
        }

        if (!string.IsNullOrEmpty(nombre))
        {
            sites = sites.Where(s => s.Title != null && s.Title.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        var cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
            SlidingExpiration = TimeSpan.FromMinutes(5)
        };

        _cache.Set(cacheKey, sites, cacheOptions);
        return sites;

    }
    public async Task<IEnumerable<Site>> GetAllBySearch(string language, string nombre)
    {
        string cacheKey = $"Sites_{nombre}";
        if (_cache.TryGetValue(cacheKey, out IEnumerable<Site> cachedSites))
        {
            return cachedSites ?? Enumerable.Empty<Site>();
        }

        var sites = await _siteRepository.FindSiteByTitle(nombre);

        var cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
            SlidingExpiration = TimeSpan.FromMinutes(5)
        };

        _cache.Set(cacheKey, sites, cacheOptions);

        return sites;
    }
    //public async Task<IEnumerable<Site>> GetAllBySearch(string language, string nombre)
    //{
    //    string cacheKey = $"Sites_{nombre}";
    //    if (_cache.TryGetValue(cacheKey, out IEnumerable<Site> cachedSites))
    //    {
    //        if (cachedSites != null)
    //        {
    //            return cachedSites;

    //        }
    //    }

    //    var sites = await _siteRepository
    //    .FindAllEficientWithoutPageAsync(x => x.IsActive
    //                && !x.IsPendingToApprove
    //                && x.IsSiteApproved,
    //            x => new Site
    //            {
    //                Id = x.Id,
    //                Title = x.Title,
    //                DataFiles = x.DataFiles
    //                .Where(df => df.FileOrder == x.DataFiles.Min(d => d.FileOrder))
    //                .Select(df => new DataFile
    //                {
    //                    Path = df.Path,
    //                    FileOrder = df.FileOrder
    //                })
    //                .Take(1)
    //                .ToList()
    //            });

    //    if (!string.IsNullOrEmpty(nombre))
    //    {
    //        sites = sites.Where(s => s.Title != null && s.Title.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
    //    }
    //    var cacheOptions = new MemoryCacheEntryOptions
    //    {
    //        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
    //        SlidingExpiration = TimeSpan.FromMinutes(5)
    //    };

    //    _cache.Set(cacheKey, sites, cacheOptions);

    //    return sites;
    //}

    public async Task<IEnumerable<Site>> GetAllbyManage()
    {
        var sites = await _siteRepository.GetAllbyManage();

        var code = _localizationService.GetLanguage();

        return sites;
    }

    public async Task<Site> ToggleActive(int id)
    {
        var original = await _siteRepository.GetByIdAsync(id);

        if (original is null)
        {
            throw new NotFoundException(LanguageConst.IdNotFound);
        }
        original.UpdatedBy = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0;

        original.IsActive = !original.IsActive;
        var updatedSite = await _siteRepository.UpdateAsync(original);

        return updatedSite;
    }

    public async Task DeleteSite(int id)
    {
        await _siteRepository.DeletePermanentlyAsync(id);
    }

    public async Task<Site> GetById(int id)
    {
        var current = await _siteRepository.GetById(id);
        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Site> UpdateAmenities(int siteId, List<AmenityDto> amenitiesDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        if (site == null) throw new KeyNotFoundException("Site not found");

        var existingAmenities = site.AmenityBySites.ToList();

        foreach (var amenityDto in amenitiesDto)
        {
            var existingAmenity = existingAmenities.FirstOrDefault(a => a.AmenityId == amenityDto.Id);
            if (existingAmenity != null)
            {
                existingAmenity.Description = amenityDto.Description;
            }
            else
            {
                site.AmenityBySites.Add(new AmenityBySite
                {
                    AmenityId = amenityDto.Id,
                    Description = amenityDto.Description
                });
            }
        }

        var selectedAmenityIds = amenitiesDto.Select(a => a.Id).ToHashSet();
        foreach (var existingAmenity in existingAmenities)
        {
            if (!selectedAmenityIds.Contains(existingAmenity.AmenityId))
            {
                site.AmenityBySites.Remove(existingAmenity);
            }
        }

        site.UpdatedAt = DateTimeOffset.Now;

        await _siteRepository.UpdateSiteAsync(site);
        return site;
    }

    public async Task<Site> UpdateFeatures(int siteId, FeaturesDto featuresDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        if (site == null) throw new KeyNotFoundException("Site not found");

        site.Title = featuresDto.Title;
        site.Description = featuresDto.Description;
        site.CountryId = featuresDto.CountryId;
        site.RegionId = featuresDto.RegionId ?? site.RegionId;
        site.CurrencyId = featuresDto.CurrencyId;
        site.IsPublic = featuresDto.IsPublic;
        site.CategoryId = featuresDto.CategoryId;
        site.Capacity = featuresDto.Capacity ?? site.Capacity;
        site.SitePolicies = string.Join(",", featuresDto.SitePolicies);
       
        
        await _siteRepository.UpdateAsync(site);
        return site;
    }

    public async Task<Site> UpdatePrices(int siteId, PricesDto pricesDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        if (site == null) throw new KeyNotFoundException("Site not found");

        site.AdultPrice = pricesDto.AdultPrice;
        site.ChildPrice = pricesDto.ChildPrice;

        // Actualizar costos adicionales
        site.AdditionalCosts.Clear();
        foreach (var additionalCostDto in pricesDto.AdditionalCosts)
        {
            site.AdditionalCosts.Add(new AdditionalCost
            {
                Name = additionalCostDto.Name,
                Price = additionalCostDto.Price
            });
        }

        // Actualizar opciones de transporte seleccionadas
        var existingTransportOptions = site.SelectedTransportOptions.ToList();
        foreach (var existingOption in site.SelectedTransportOptions.ToList())
        {
            var matchingOption = pricesDto.TransportOptions
                .FirstOrDefault(to => to.Id == existingOption.TransportOptionId);

            if (matchingOption == null || !matchingOption.Selected)
            {
                site.SelectedTransportOptions.Remove(existingOption);
            }
        }
        foreach (var transportOptionDto in pricesDto.TransportOptions)
        {
            var existingOption = site.SelectedTransportOptions
                .FirstOrDefault(to => to.TransportOptionId == transportOptionDto.Id);

            if (existingOption != null)
            {
                existingOption.Price = transportOptionDto.Price;
            }
            else if (transportOptionDto.Selected)
            {
                site.SelectedTransportOptions.Add(new SelectedTransportOption
                {
                    TransportOptionId = transportOptionDto.Id,
                    Price = transportOptionDto.Price
                });
            }
        }

        // Actualizar el paquete especial
        if (pricesDto.SpecialPackage != null)
        {
            site.SpecialPackage = new SpecialPackage
            {
                PackageName = pricesDto.SpecialPackage.Name,
                Price = pricesDto.SpecialPackage.Price,
                PackageItems = pricesDto.SpecialPackage.Includes
                    .Select(include => new PackageItem { ItemName = include })
                    .ToList()
            };
        }
        else
        {
            site.SpecialPackage = null;
        }

        site.TotalPrice = (decimal)(site.AdultPrice + site.ChildPrice + site.AdditionalCosts.Sum(ac => ac.Price) +
                          site.SelectedTransportOptions.Sum(to => to.Price));

        site.UpdatedAt = DateTimeOffset.Now;

        // Guardar los cambios en la base de datos
        await _siteRepository.UpdateAsync(site);

        return site;
    }

    public async Task<Site> UpdateSchedule(int siteId, ScheduleDto scheduleDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        if (site == null) throw new KeyNotFoundException("Site not found");

        site.Availabilities.Clear();

        foreach (var day in scheduleDto.Days)
        {
            site.Availabilities.Add(new Availability
            {
                DayOfWeek = day.DayOfWeek,
                From = day.From,
                To = day.To
            });
        }

        site.SelectedDates = string.Join(";", scheduleDto.UnavailableDates.Select(d => d.ToString("yyyy-MM-dd")));

        await _siteRepository.UpdateAsync(site);
        return site;
    }

    public async Task<Site> UpdateLocation(int siteId, LocationDto locationDto)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        if (site == null) throw new KeyNotFoundException("Site not found");

        site.Latitude = locationDto.Latitude; 
        site.Longitude = locationDto.Longitude;

        site.UpdatedAt = DateTimeOffset.Now;

        await _siteRepository.UpdateAsync(site);
        return site;
    }

    public async Task<Site> UpdateSite(Site site)
    {
        await _siteRepository.UpdateAsync(site);
        return site;
    }

    public async Task<Site> GetByIdTracking(int siteId)
    {
        var site = await _siteRepository.GetByIdAsync(siteId);
        return site;
    }

    public async Task<IEnumerable<IncidentDto>> GetIncidentsBySiteIdAsync(int siteId)
    {
        var incidents = await _siteRepository.GetIncidentsBySiteIdAsync(siteId);
        return incidents.Select(i => new IncidentDto
        {
            Id = i.Id,
            SiteId = i.SiteId,
            Description = i.Description,
            ReportedAt = i.CreatedDate,
            UserId = i.User.Id,
            UserName = $"{i.User.FirstName} {i.User.LastName}",
            UserProfilePicture = i.User.ProfilePicture,
            UserEmail = i.User.Email,
            UserPhone = i.User.Telephone
        });
    }

    public async Task<IncidentDto> AddIncidentAsync(IncidentCreateDto dto)
    {
        var user = await _userRepository.GetByIdAsync(dto.UserId);
        if (user == null)
        {
            throw new Exception("El usuario no existe.");
        }

        var incident = new Incident
        {
            SiteId = dto.SiteId,
            UserId = dto.UserId,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow,
        };

        try
        {
            var createdIncident = await _siteRepository.AddIncidentAsync(incident);
            return new IncidentDto
            {
                Id = createdIncident.Id,
                SiteId = createdIncident.SiteId,
                Description = createdIncident.Description,
                ReportedAt = createdIncident.CreatedDate,
                UserId = createdIncident.UserId 
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al agregar incidente: {ex.Message}");
            throw;
        }
    }


    public async Task<bool> DeleteIncidentAsync(int incidentId)
    {
        return await _siteRepository.DeleteIncidentAsync(incidentId);
    }

}