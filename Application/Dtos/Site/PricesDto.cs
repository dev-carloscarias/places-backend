using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;
public class PricesDto
{
    public decimal AdultPrice { get; set; }
    public decimal ChildPrice { get; set; }

    public List<TransportOptionDto> TransportOptions { get; set; } = new List<TransportOptionDto>();
    public List<AdditionalCostDto> AdditionalCosts { get; set; } = new List<AdditionalCostDto>();
    public SpecialPackageDto? SpecialPackage { get; set; }
}

public class TransportOptionDto
{
    public int Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool Selected { get; set; } 
}

public class AdditionalCostDto
{
    public string Name { get; set; } = string.Empty; 
    public decimal Price { get; set; }
}

public class SpecialPackageDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; } 
    public List<string> Includes { get; set; } = new(); 
}

