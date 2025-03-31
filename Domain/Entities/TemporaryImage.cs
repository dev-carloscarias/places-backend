using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class TemporaryImage : EntityBase
{
    public string Path { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public int FileOrder { get; set; }
    public DataFileType DataFileType { get; set; }
    public DataTypeExtension DataTypeExtension { get; set; }
    public int UserId { get; set; }
    public int SessionId { get; set; }
}
