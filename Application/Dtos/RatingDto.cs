using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class RatingDto
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public int UserId { get; set; }
    public int RatingValue { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
}