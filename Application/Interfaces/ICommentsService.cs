using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface ICommentsService : IService<Comment>
{
    Task<IEnumerable<Comment>> GetCommentsBySiteIdAsync(int siteId);
    Task<Comment> GetCommentByIdAsync(int commentId);
    Task<Comment> CreateCommentAsync(int siteId, int userId, string text);
    Task UpdateCommentAsync(int commentId, string text, int userId);
    Task DeleteCommentAsync(int commentId, int userId);
}