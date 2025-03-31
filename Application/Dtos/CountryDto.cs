using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Iso2 { get; set; } = string.Empty;

    public string Iso3 { get; set; } = string.Empty;

    public string CountryCode { get; set; } = string.Empty;
    
    public int? ContinentId { get; set; }
}
