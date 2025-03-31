using Microsoft.AspNetCore.Http.HttpResults;
using Places.Application.Dtos;
using Places.Application.Dtos.Site;
using Places.Infrastructure.Data;

namespace Places.Infrastructure.Repositories;

public class SiteRepository : Repository<Site>, ISiteRepository 
{
    private readonly ApplicationDbContext _context;
    public SiteRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<Site> GetById(int id)
    {
        try
        {
            // Consulta principal: obtiene datos básicos del sitio, incluyendo fotos y amenidades
            var siteData = await _context.Sites
                .AsNoTracking()
                .Where(s => s.Id == id)
                .Select(s => new
                {
                    s.Id,
                    s.Title,
                    s.IsPublic,
                    s.Description,
                    s.CountryId,
                    s.CurrencyId,
                    s.TotalPrice,
                    s.Latitude,
                    s.Longitude,
                    s.UserId,
                    s.CategoryId,
                    s.Capacity,
                    s.IsSiteApproved,
                    s.IsPendingToApprove,
                    s.AdultPrice,
                    s.ChildPrice,
                    s.TransportationPrice,
                    s.Availabilities,
                    s.RegionId,
                    s.SelectedDates,
                    s.SelectedTransportOptions,
                    s.SitePolicies,
                    Photos = s.DataFiles
                        .Select(df => new
                        {
                            df.Id,
                            df.Path,
                            df.FileOrder
                        })
                        .OrderBy(df => df.FileOrder)
                        .ToList(),
                    Amenities = s.AmenityBySites
                        .Select(ab => new
                        {
                            ab.Amenity.Id,
                            ab.Amenity.Name,
                            Files = ab.Amenity.Files
                                .Select(f => new
                                {
                                    f.Path,
                                    f.FileOrder
                                })
                                .OrderBy(f => f.FileOrder)
                                .ToList(),
                            ab.Description
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (siteData == null)
            {
                return null;
            }

            // Segunda consulta: AdditionalCosts
            var additionalCostsData = await _context.Sites
                .AsNoTracking()
                .Where(s => s.Id == id)
                .Select(s => s.AdditionalCosts
                    .Select(ac => new
                    {
                        ac.Price,
                        ac.Name
                    })
                    .ToList())
                .FirstOrDefaultAsync();

            // Tercera consulta: SpecialPackage (si existe)
            var specialPackageData = await _context.Sites
                .AsNoTracking()
                .Where(s => s.Id == id && s.SpecialPackage != null)
                .Select(s => new
                {
                    s.SpecialPackage.PackageName,
                    s.SpecialPackage.Price,
                    PackageItems = s.SpecialPackage.PackageItems
                        .Select(pi => new
                        {
                            pi.ItemName
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            // Cuarta consulta: Transporte
            var transportOptionsData = await _context.SelectedTransportOptions
            .AsNoTracking()
            .Where(sto => sto.SiteId == id)
            .Select(sto => new
            {
                sto.TransportOptionId,
                sto.Price,
                TransportOptionName = sto.TransportOption.Name,
                TransportOptionImageUrl = sto.TransportOption.ImageUrl
            })
            .ToListAsync();

            // Combinar todos los datos en el objeto Site final

            var site = new Site
            {
                Id = siteData.Id,
                Title = siteData.Title,
                IsPublic = siteData.IsPublic,
                Description = siteData.Description,
                CountryId = siteData.CountryId,
                CurrencyId = siteData.CurrencyId,
                TotalPrice = siteData.TotalPrice,
                Latitude = siteData.Latitude,
                Longitude = siteData.Longitude,
                UserId = siteData.UserId,
                CategoryId = siteData.CategoryId,
                Capacity = siteData.Capacity,
                IsSiteApproved = siteData.IsSiteApproved,
                IsPendingToApprove = siteData.IsPendingToApprove,
                AdultPrice = siteData.AdultPrice,
                ChildPrice = siteData.ChildPrice,
                TransportationPrice = siteData.TransportationPrice,
                Availabilities = siteData.Availabilities,
                RegionId = siteData.RegionId,
                SelectedDates = siteData.SelectedDates,
                SitePolicies = siteData.SitePolicies,
                DataFiles = siteData.Photos.Select(p => new DataFile
                {
                    Id = p.Id,
                    Path = p.Path,
                    FileOrder = p.FileOrder
                }).ToList(),
                AmenityBySites = siteData.Amenities.Select(a => new AmenityBySite
                {
                    Amenity = new Amenity
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Files = a.Files.Select(f => new DataFile
                        {
                            Path = f.Path,
                            FileOrder = f.FileOrder
                        }).ToList()
                    },
                    Id = a.Id,
                    Description = a.Description
                }).ToList(),
                AdditionalCosts = additionalCostsData != null
                    ? additionalCostsData.Select(ac => new AdditionalCost
                    {
                        Price = ac.Price,
                        Name = ac.Name
                    }).ToList()
                    : new List<AdditionalCost>(),
                SpecialPackage = specialPackageData != null
                    ? new SpecialPackage
                    {
                        PackageName = specialPackageData.PackageName,
                        Price = specialPackageData.Price,
                        PackageItems = specialPackageData.PackageItems
                            .Select(pi => new PackageItem
                            {
                                ItemName = pi.ItemName
                            })
                            .ToList()
                    }
                    : null,
                SelectedTransportOptions = transportOptionsData.Select(to => new SelectedTransportOption
                {
                    TransportOptionId = to.TransportOptionId,
                    Price = to.Price,
                    TransportOption = new TransportOption
                    {
                        Name = to.TransportOptionName,
                        ImageUrl = to.TransportOptionImageUrl
                    }
                }).ToList()
            };

            return site;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<Site> GetByIdAsync(int id)
    {
        try
        {
            var site = await _context.Sites
                .AsSplitQuery()
                .Include(s => s.DataFiles)
                .Include(s => s.SelectedTransportOptions)
                .Include(s => s.Availabilities)
                .Include(s => s.AmenityBySites)
                    .ThenInclude(ab => ab.Amenity)
                .Include(s => s.AdditionalCosts)
                .Include(s => s.SpecialPackage)
                    .ThenInclude(sp => sp.PackageItems)
                .SingleOrDefaultAsync(s => s.Id == id);

            if (site == null)
            {
                return null;
            }

            site.DataFiles = site.DataFiles
                .DistinctBy(df => df.Path)
                .OrderBy(df => df.FileOrder)
                .ToList();

            site.AmenityBySites = site.AmenityBySites
                .DistinctBy(ab => ab.Amenity.Id)
                .ToList();

            site.SelectedTransportOptions = site.SelectedTransportOptions
                .DistinctBy(st => st.TransportOptionId)
                .ToList();


            return site;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }


    public async Task<IEnumerable<Site>> GetPendingToApprove()
    {
        try
        {
            var sites = await _context.Sites
                 .Where(s => s.IsPendingToApprove)
                 .Select(s => new Site
                 {
                     Id = s.Id,
                     Title = s.Title,
                     Description = s.Description,
                     CountryId = s.CountryId,
                     CurrencyId = s.CurrencyId,
                     UserId = s.UserId,
                     CreatedAt = s.CreatedAt,
                     IsPendingToApprove = s.IsPendingToApprove,
                 })
                 .ToListAsync();

            return sites;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<IEnumerable<Site>> GetSitesbyOwner(int userId)
    {
        try
        {
            var siteDataList = await _context.Sites
            .AsNoTracking()
            .Where(s => s.UserId == userId)
            .Select(s => new
            {
                s.Id,
                s.Title,
                s.Description,
                s.CountryId,
                s.CurrencyId,
                s.UserId,
                s.CreatedAt,
                s.IsPendingToApprove,
                Photo = s.DataFiles
                    .OrderBy(df => df.FileOrder)
                    .Select(df => new
                    {
                        df.Path,
                        df.FileOrder
                    })
                    .FirstOrDefault()
            })
            .ToListAsync();

            if (siteDataList == null || !siteDataList.Any())
            {
                return Enumerable.Empty<Site>();
            }

            // Proyecta los datos en una lista de `Site`
            var sites = siteDataList.Select(siteData => new Site
            {
                Id = siteData.Id,
                Title = siteData.Title,
                Description = siteData.Description,
                CountryId = siteData.CountryId,
                CurrencyId = siteData.CurrencyId,
                UserId = siteData.UserId,
                CreatedAt = siteData.CreatedAt,
                IsPendingToApprove = siteData.IsPendingToApprove,
                DataFiles = siteData.Photo != null
                    ? new List<DataFile>
                    {
            new DataFile
            {
                Path = siteData.Photo.Path,
                FileOrder = siteData.Photo.FileOrder
            }
                    }
                    : new List<DataFile>()
            }).ToList();

            return sites;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<IEnumerable<Site>> GetAllbyManage()
    {
        try
        {
            var sites = await _context.Sites
                .AsNoTracking()
                .Where(x => true)
                .Select(s => new Site
                {
                    Id = s.Id,
                    Title = s.Title,
                    CountryId = s.CountryId,
                    UserId = s.UserId,
                    CreatedAt = s.CreatedAt,
                    IsActive = s.IsActive,
                    DataFiles = s.DataFiles
                        .Where(df => df.FileOrder == s.DataFiles.Min(d => d.FileOrder))
                        .Select(df => new DataFile
                        {
                            Path = df.Path,
                            FileOrder = df.FileOrder
                        })
                        .Take(1)
                        .ToList()
                })
                .ToListAsync();

            return sites;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<Site> GetAmenitiesbySite(int id)
    {
        return await _context.Sites.Include(s => s.AmenityBySites).FirstOrDefaultAsync(s=> s.Id == id);
    }

    public async Task<Site> GetAvailabilitiesbySite(int id)
    {
        return await _context.Sites.Include(s => s.Availabilities).FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Site> GetFeaturesDataForUpdateAsync(int siteId)
    {
        return await _context.Sites
            .Select(s => new Site
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                CountryId = s.CountryId,
                RegionId = s.RegionId,
                CurrencyId = s.CurrencyId,
                IsPublic = s.IsPublic,
                CategoryId = s.CategoryId,
                Capacity = s.Capacity,
                SitePolicies = s.SitePolicies
            })
            .FirstOrDefaultAsync(s => s.Id == siteId);
    }

    public async Task UpdateSiteAsync(Site site)
    {
        _context.Sites.Attach(site);
        _context.Entry(site).State = EntityState.Modified;
        site.UpdatedAt = DateTimeOffset.Now;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Incident>> GetIncidentsBySiteIdAsync(int siteId)
    {
        return await _context.Incidents
          .Include(i => i.User)
          .Where(i => i.SiteId == siteId)
          .ToListAsync();
    }

    public async Task<Incident?> GetIncidentById(int incidentId)
    {
        return await _context.Incidents
            .Include(i => i.User)
            .FirstOrDefaultAsync(i => i.Id == incidentId);
    }

    public async Task<Incident> AddIncidentAsync(Incident incident)
    {
        _context.Incidents.Add(incident);
        await _context.SaveChangesAsync();
        return incident;
    }

    public async Task<bool> DeleteIncidentAsync(int incidentId)
    {
        var incident = await _context.Incidents.FindAsync(incidentId);
        if (incident == null) return false;

        _context.Incidents.Remove(incident);
        await _context.SaveChangesAsync();
        return true;
    }

}