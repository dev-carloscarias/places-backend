using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class CommentsService : ICommentsService
{
    private readonly ICommentsRepository _commentsRepository;

    public CommentsService(ICommentsRepository commentsRepository)
    {
        _commentsRepository = commentsRepository;
    }

    public async Task<IEnumerable<Comment>> GetCommentsBySiteIdAsync(int siteId)
    {
        return await _commentsRepository.GetCommentsBySiteIdAsync(siteId);
    }

    public async Task<Comment> GetCommentByIdAsync(int commentId)
    {
        return await _commentsRepository.GetByIdAsync(commentId);
    }

    public async Task<Comment> CreateCommentAsync(int siteId, int userId, string text)
    {
        var comment = new Comment
        {
            SiteId = siteId,
            UserId = userId,
            Text = text,
            CreatedDate = DateTimeOffset.UtcNow
        };
        return await _commentsRepository.AddAsync(comment);
    }

    public async Task UpdateCommentAsync(int commentId, string text, int userId)
    {
        var existingComment = await _commentsRepository.GetByIdAsync(commentId);
        if (existingComment == null)
            throw new Exception("Comment not found");

        if (existingComment.UserId != userId)
            throw new UnauthorizedAccessException("No tienes permiso para editar este comentario.");

        existingComment.Text = text;
        existingComment.ModifiedDate = DateTimeOffset.UtcNow;

        await _commentsRepository.UpdateAsync(existingComment);
    }

    public async Task DeleteCommentAsync(int commentId, int userId)
    {
        await _commentsRepository.DeletePermanentlyAsync(commentId);
    }

    public Task<Comment> Create(Comment model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> Edit(Comment model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Comment>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Comment> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Any()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Any(Expression<Func<Comment, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<QueryResult<Comment>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        throw new NotImplementedException();
    }
}