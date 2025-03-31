using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface ICommentsRepository : IRepository<Comment>
{
    Task<IEnumerable<Comment>> GetCommentsBySiteIdAsync(int siteId);
    Task DeleteAsync(Comment comment);
}

