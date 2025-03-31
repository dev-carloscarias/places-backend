using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;
public class ScheduleDto
{
    public List<DayAvailabilityDto> Days { get; set; } = new();
    public List<DateTime> UnavailableDates { get; set; } = new();
}

public class DayAvailabilityDto
{
    public int Id { get; set; }
    public DayOfWeek DayOfWeek { get; set; } 
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
}

