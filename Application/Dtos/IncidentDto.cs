using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class IncidentDto
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime ReportedAt { get; set; } 
    public int SiteId { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string UserProfilePicture { get; set; } = string.Empty;
    public string UserPhone { get; set; } = string.Empty;
    public string UserEmail { get; set; } = string.Empty;

}