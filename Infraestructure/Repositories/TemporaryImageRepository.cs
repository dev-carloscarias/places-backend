using Places.Domain.Entities;
using Places.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class TemporaryImageRepository : Repository<TemporaryImage>, ITemporaryImageRepository
{
    private readonly ApplicationDbContext _context;
    public TemporaryImageRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<List<TemporaryImage>> GetTemporaryImagesbyId(int userId, int sessionId)
    {
        return await _context.TemporaryImages
         .Where(t => t.UserId == userId && t.SessionId == sessionId)
         .ToListAsync();
    }

}
