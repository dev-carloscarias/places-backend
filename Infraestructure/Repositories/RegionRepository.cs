using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class RegionRepository : Repository<Region>, IRegionRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RegionRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<Region> Create(Region region)
    {
        _dbContext.Regions.Add(region);
        await _dbContext.SaveChangesAsync();
        return region;
    }

    public async Task<Region?> GetById(int id)
    {
        return await _dbContext.Regions.FindAsync(id);
    }

    public async Task<IEnumerable<Region>> GetAll()
    {
        return await _dbContext.Regions.ToListAsync();
    }

    public async Task<Region> Update(Region region)
    {
        _dbContext.Regions.Update(region);
        await _dbContext.SaveChangesAsync();
        return region;
    }

    public async Task Delete(int id)
    {
        var region = await _dbContext.Regions.FindAsync(id);
        if (region != null)
        {
            _dbContext.Regions.Remove(region);
            await _dbContext.SaveChangesAsync();
        }
    }
}