using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class Region : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public int CountryId { get; set; }
    public virtual Country Country { get; set; } = null!;
}