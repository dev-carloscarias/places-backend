using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class TransportOptionDto
{   
    public int? Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public string? ImageUrl { get; set; } = null;
    public string? DataTypeExtension { get; set; } = null;
}
