using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;
public class UpdateImagesDto
{
    public List<UpdatedImageDto> UpdatedImages { get; set; } = new();
    public List<RemovedImageDto> RemovedImages { get; set; } = new();
}

public class UpdatedImageDto
{
    public int Id { get; set; }
    public int FileOrder { get; set; }
    public string Description { get; set; } = string.Empty;
}

public class RemovedImageDto
{
    public int DataFileType { get; set; }
    public int DataTypeExtension { get; set; }
    public string Description { get; set; } = string.Empty;
    public int FileOrder { get; set; }
    public int Id { get; set; }
    public string Path { get; set; } = string.Empty;
    public string Preview { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}

