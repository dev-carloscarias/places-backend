using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class SpecialPackage : EntityBase
{
    public string PackageName { get; set; } = string.Empty;

    public ICollection<PackageItem> PackageItems { get; set; } = new List<PackageItem>();

    public int SiteId { get; set; }
    public decimal Price { get; set; }

    public virtual Site Site { get; set; } = null!;
    public virtual ICollection<Reservation> Reservations { get; set; } = [];

}
