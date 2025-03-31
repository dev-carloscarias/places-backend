using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Dtos;
public class UpdateFileOrderRequest
{
    public int Id { get; set; }
    public int NewFileOrder { get; set; }
}
