using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class RegionService : IRegionService
{
    private readonly IRegionRepository _regionRepository;

    public RegionService(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<Region> Create(Region region)
    {
        return await _regionRepository.AddAsync(region);
    }

    public async Task<Region?> GetById(int id)
    {
        return await _regionRepository.GetById(id);
    }

    public async Task<IEnumerable<Region>> GetAll()
    {
        return await _regionRepository.GetAllAsync();
    }

    public async Task<Region> Update(Region region)
    {
        return await _regionRepository.UpdateAsync(region);
    }

    public async Task Delete(int id)
    {
        await _regionRepository.DeletePermanentlyAsync(id);
    }

    public async Task<IEnumerable<Region>> GetByCountryId(int countryId)
    {
        return await _regionRepository.FindAsync(r => r.CountryId == countryId);
    }

}
