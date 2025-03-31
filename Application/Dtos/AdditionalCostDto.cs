using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class AdditionalCostDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }
}
