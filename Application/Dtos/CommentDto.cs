using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class CommentDto
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public int UserId { get; set; }
    public string UserProfilePicture { get; set; }
    public string UserName { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? ModifiedDate { get; set; }
}