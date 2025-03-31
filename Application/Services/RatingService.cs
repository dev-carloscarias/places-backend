using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class RatingService : IRatingService
{
    private readonly IRatingRepository _ratingRepository;

    public RatingService(IRatingRepository ratingRepository)
    {
        _ratingRepository = ratingRepository;
    }

    public async Task<Rating> GetRatingByIdAsync(int ratingId)
    {
        return await _ratingRepository.GetByIdAsync(ratingId);
    }

    public async Task<IEnumerable<Rating>> GetRatingsBySiteIdAsync(int siteId)
    {
        return await _ratingRepository.GetRatingsBySiteIdAsync(siteId);
    }

    public async Task<Rating?> GetUserRatingForSiteAsync(int siteId, int userId)
    {
        return await _ratingRepository.GetUserRatingForSiteAsync(siteId, userId);
    }

    public async Task<Rating> CreateOrUpdateRatingAsync(int siteId, int userId, int ratingValue)
    {
        var existing = await _ratingRepository.GetUserRatingForSiteAsync(siteId, userId);
        if (existing != null)
        {
            existing.RatingValue = ratingValue;
            existing.ModifiedDate = DateTimeOffset.UtcNow;
            await _ratingRepository.UpdateAsync(existing);
            return existing;
        }
        else
        {
            var rating = new Rating
            {
                SiteId = siteId,
                UserId = userId,
                RatingValue = ratingValue,
                CreatedDate = DateTimeOffset.UtcNow
            };
            return await _ratingRepository.AddAsync(rating);
        }
    }

    public async Task DeleteRatingAsync(int ratingId, int userId)
    {
        var existing = await _ratingRepository.GetByIdAsync(ratingId);
        if (existing == null)
            throw new Exception("Rating not found");

        if (existing.UserId != userId)
            throw new UnauthorizedAccessException("No tienes permiso para eliminar este rating.");

        await _ratingRepository.DeleteAsync(existing);
    }

    public Task<Rating> Create(Rating model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Rating> Edit(Rating model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Rating>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Rating> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Any()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Any(Expression<Func<Rating, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<QueryResult<Rating>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        throw new NotImplementedException();
    }
}