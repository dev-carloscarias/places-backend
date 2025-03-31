using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;
public class FeaturesDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CountryId { get; set; } 
    public int? RegionId { get; set; }
    public bool newRegion { get; set; } = false;
    public string? CustomRegionName { get; set; } = null;
    public int CurrencyId { get; set; } 
    public bool IsPublic { get; set; } = true;
    public int CategoryId { get; set; } 
    public int? Capacity { get; set; } 
    public List<string> SitePolicies { get; set; } = new();
}
