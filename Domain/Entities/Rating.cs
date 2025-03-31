using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class Rating : EntityBase
{
    public int SiteId { get; set; }
    public int UserId { get; set; }
    public int RatingValue { get; set; }

    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ModifiedDate { get; set; }

    public virtual Site Site { get; set; } = null!;
    public virtual User User { get; set; } = null!;
}
