using Places.Application.Services;
using Places.Domain.Dtos;

namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
    private readonly ICommentsService _commentsService;
    private readonly IUserService _userService;

    private readonly IMapper _mapper;

    public CommentsController(ICommentsService commentsService, IUserService userService, IMapper mapper)
    {
        _commentsService = commentsService;
        _userService = userService;
        _mapper = mapper;
    }

    // GET /api/comments/site/5
    [HttpGet("site/{siteId}")]
    public async Task<IActionResult> GetCommentsForSite(int siteId)
    {
        var comments = await _commentsService.GetCommentsBySiteIdAsync(siteId);
        var commentsDto = _mapper.Map<IEnumerable<CommentDto>>(comments);
        foreach (var comment in commentsDto)
        {
            var user = await _userService.GetById(comment.UserId);
            comment.UserProfilePicture = user.ProfilePicture;
            comment.UserName = user.FirstName + " " + user.LastName;
        }
        return Ok(commentsDto);
    }

    // POST /api/comments/site/5
    [HttpPost("site/{siteId}")]
    public async Task<IActionResult> CreateComment(int siteId, [FromBody] CreateCommentDto model)
    {
        var createdComment = await _commentsService.CreateCommentAsync(siteId, model.UserId, model.Text);
        var resultDto = _mapper.Map<CommentDto>(createdComment);
        return Ok(resultDto);
    }

    // PUT /api/comments/10
    [HttpPut("{commentId}")]
    public async Task<IActionResult> UpdateComment(int commentId, [FromBody] UpdateCommentDto model)
    {
        // int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        int userId = model.UserId;

        await _commentsService.UpdateCommentAsync(commentId, model.Text, userId);
        return NoContent();
    }

    // DELETE /api/comments/10
    [HttpDelete("{commentId}")]
    public async Task<IActionResult> DeleteComment(int commentId, int userId)
    {
        // int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        await _commentsService.DeleteCommentAsync(commentId, userId);
        return NoContent();
    }
}

public class CreateCommentDto
{
    public int UserId { get; set; }
    public string Text { get; set; } = string.Empty;
}

public class UpdateCommentDto
{
    public int UserId { get; set; }
    public string Text { get; set; } = string.Empty;
}