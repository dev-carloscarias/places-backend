namespace Places.Application.Dtos;

public class AvailabilityDto
{
    public int Id { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public string From { get; set; }

    public string To { get; set; }
}