using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Places.Application.Dtos;
using Places.Application.Dtos.Site;
using Places.Domain.Entities;
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
            // Consulta optimizada usando Include con AsSplitQuery para evitar cartesian explosion
            var site = await _context.Sites
                .AsSplitQuery() // Divide la consulta en múltiples queries para evitar cartesian explosion
                .AsNoTracking()
                .Include(s => s.DataFiles.OrderBy(df => df.FileOrder))
                .Include(s => s.AmenityBySites)
                    .ThenInclude(ab => ab.Amenity)
                    .ThenInclude(a => a.Files.OrderBy(f => f.FileOrder))
                .Include(s => s.AdditionalCosts)
                .Include(s => s.SpecialPackage)
                    .ThenInclude(sp => sp.PackageItems)
                .Include(s => s.SelectedTransportOptions)
                    .ThenInclude(sto => sto.TransportOption)
                .Include(s => s.Availabilities)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (site == null)
            {
                return null;
            }

            // Aplicar ordenamiento y limpieza de datos duplicados si es necesario
            site.DataFiles = site.DataFiles
                .DistinctBy(df => df.Id)
                .OrderBy(df => df.FileOrder)
                .ToList();

            site.AmenityBySites = site.AmenityBySites
                .DistinctBy(ab => ab.AmenityId)
                .ToList();

            // Asegurar ordenamiento de archivos de amenidades
            foreach (var amenityBySite in site.AmenityBySites)
            {
                if (amenityBySite.Amenity?.Files != null)
                {
                    amenityBySite.Amenity.Files = amenityBySite.Amenity.Files
                        .DistinctBy(f => f.Id)
                        .OrderBy(f => f.FileOrder)
                        .ToList();
                }
            }

            site.SelectedTransportOptions = site.SelectedTransportOptions
                .DistinctBy(st => st.TransportOptionId)
                .ToList();

            return site;
        }
        catch (Exception ex)
        {
            // Log el error específico para mejor debugging
            Console.WriteLine($"Error en GetById para SiteId {id}: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            return null;
        }
    }

    /// <summary>
    /// Método optimizado para obtener datos básicos del sitio con menos relaciones
    /// Usar cuando no necesites todas las relaciones completas
    /// </summary>
    public async Task<Site> GetByIdLightweight(int id)
    {
        try
        {
            var site = await _context.Sites
                .AsNoTracking()
                .Include(s => s.DataFiles.OrderBy(df => df.FileOrder))
                .Include(s => s.AdditionalCosts)
                .Include(s => s.SpecialPackage)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (site?.DataFiles != null)
            {
                site.DataFiles = site.DataFiles
                    .DistinctBy(df => df.Id)
                    .OrderBy(df => df.FileOrder)
                    .ToList();
            }

            return site;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en GetByIdLightweight para SiteId {id}: {ex.Message}");
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

    public async Task<IEnumerable<Site>> FindSiteByTitle(string titlePrefix, int limit = 6)
    {
        var prefix = titlePrefix?.ToLower() ?? string.Empty;

        return await _context.Sites
            .AsNoTracking()
            .Where(x =>
                x.IsActive &&
                !x.IsPendingToApprove &&
                x.IsSiteApproved &&
                EF.Functions.Like(x.Title.ToLower(), prefix + "%"))
            .OrderBy(x => x.Id)
            .Select(x => new Site
            {
                Id = x.Id,
                Title = x.Title,
                DataFiles = x.DataFiles
                    .Where(df => df.FileOrder == x.DataFiles.Min(d => d.FileOrder))
                    .Select(df => new DataFile
                    {
                        Path = df.Path,
                        FileOrder = df.FileOrder
                    })
                    .Take(1)
                    .ToList()
            })
            .Take(limit)
            .ToListAsync();
    }




}