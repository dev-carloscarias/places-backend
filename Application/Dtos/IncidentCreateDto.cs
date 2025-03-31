using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class IncidentCreateDto
{
    public int UserId { get; set; }
    public int SiteId { get; set; }
    public string Description { get; set; } = string.Empty;
}