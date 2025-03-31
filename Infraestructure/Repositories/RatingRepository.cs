using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class RatingRepository : Repository<Rating>, IRatingRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RatingRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<Rating> GetByIdAsync(int id)
    {
        return await _dbContext.Ratings.FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<Rating?> GetUserRatingForSiteAsync(int siteId, int userId)
    {
        return await _dbContext.Ratings
            .FirstOrDefaultAsync(r => r.SiteId == siteId && r.UserId == userId);
    }

    public async Task<IEnumerable<Rating>> GetRatingsBySiteIdAsync(int siteId)
    {
        return await _dbContext.Ratings
            .Where(r => r.SiteId == siteId)
            .Include(r => r.User)
            .ToListAsync();
    }

    public async Task<Rating> AddAsync(Rating rating)
    {
        _dbContext.Ratings.Add(rating);
        await _dbContext.SaveChangesAsync();
        return rating;
    }

    public async Task UpdateAsync(Rating rating)
    {
        _dbContext.Ratings.Update(rating);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Rating rating)
    {
        _dbContext.Ratings.Remove(rating);
        await _dbContext.SaveChangesAsync();
    }
}