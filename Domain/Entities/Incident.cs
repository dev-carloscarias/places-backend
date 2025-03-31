using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;

public class Incident : EntityBase
{
    public int SiteId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public virtual Site Site { get; set; } = null!;
    public virtual User User { get; set; } = null!;
}
