using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class TransportOption : EntityBase
{
    public string Name { get; set; } = string.Empty; 
    public bool IsActive { get; set; } = true;
    public string? ImageUrl { get; set; }
    public ICollection<SelectedTransportOption> SelectedTransportOptions { get; set; } = new List<SelectedTransportOption>();
}
