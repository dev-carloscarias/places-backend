using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class AdditionalCost : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int SiteId { get; set; }

    public virtual Site Site { get; set; } = null!;
}
