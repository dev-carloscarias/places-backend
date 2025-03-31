using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;
public class LocationDto
{
    public double Latitude { get; set; } 
    public double Longitude { get; set; }
    public string Address { get; set; } = string.Empty;
}

