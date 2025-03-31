using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class SelectedTransportOption : EntityBase
{
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;

    public int TransportOptionId { get; set; }
    public TransportOption TransportOption { get; set; } = null!;

    public decimal? Price { get; set; }
}