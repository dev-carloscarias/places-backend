using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class SpecialPackageDto
{
    public int Id { get; set; }
    public string PackageName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public List<PackageItemDto> PackageItems { get; set; } = new List<PackageItemDto>();
}
