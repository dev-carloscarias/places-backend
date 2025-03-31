using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface IRatingService : IService<Rating>
{
    Task<Rating> GetRatingByIdAsync(int ratingId);
    Task<IEnumerable<Rating>> GetRatingsBySiteIdAsync(int siteId);
    Task<Rating?> GetUserRatingForSiteAsync(int siteId, int userId);
    Task<Rating> CreateOrUpdateRatingAsync(int siteId, int userId, int ratingValue);
    Task DeleteRatingAsync(int ratingId, int userId);
}