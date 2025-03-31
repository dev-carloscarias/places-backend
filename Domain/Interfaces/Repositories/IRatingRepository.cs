using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface IRatingRepository : IRepository<Rating>
{
    Task<Rating?> GetUserRatingForSiteAsync(int siteId, int userId);
    Task<IEnumerable<Rating>> GetRatingsBySiteIdAsync(int siteId);
    Task DeleteAsync(Rating rating);
}

