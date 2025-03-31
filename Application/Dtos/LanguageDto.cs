using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;

public class LanguageDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string NameTranslated { get; set; }

    public string LanguageCode { get; set; } = string.Empty;
}