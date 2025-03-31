using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class Hobbie : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public virtual User user { get; set; } = null!;
}
