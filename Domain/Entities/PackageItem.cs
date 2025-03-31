using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class PackageItem : EntityBase
{
    public string ItemName { get; set; } = string.Empty;

    public int SpecialPackageId { get; set; }

    public virtual SpecialPackage SpecialPackage { get; set; } = null!;
}
