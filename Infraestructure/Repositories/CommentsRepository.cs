using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class CommentsRepository : Repository<Comment>, ICommentsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CommentsRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<Comment> GetByIdAsync(int id)
    {
            return await _dbContext.Comments.FirstOrDefaultAsync(c => c.Id == id);
       
    }

    public async Task<IEnumerable<Comment>> GetCommentsBySiteIdAsync(int siteId)
    {
        return await _dbContext.Comments
                             .Where(c => c.SiteId == siteId)
                             .OrderByDescending(c => c.CreatedDate)
                             .ToListAsync();
    }

    public async Task<Comment> AddAsync(Comment comment)
    {
        _dbContext.Comments.Add(comment);
        await _dbContext.SaveChangesAsync();
        return comment;
    }

    public async Task UpdateAsync(Comment comment)
    {
        _dbContext.Comments.Update(comment);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Comment comment)
    {
        _dbContext.Comments.Remove(comment);
        await _dbContext.SaveChangesAsync();
    }
}