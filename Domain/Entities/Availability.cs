namespace Places.Domain.Entities;

public class Availability : EntityBase
{
    public DayOfWeek DayOfWeek { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public int SiteId { get; set; }

    public virtual Site Site { get; set; }
}