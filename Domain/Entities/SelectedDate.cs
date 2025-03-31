using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class SelectedDate : EntityBase
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int SiteId { get; set; }
    public Site Site { get; set; }
}
