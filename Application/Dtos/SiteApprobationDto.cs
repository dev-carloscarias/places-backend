namespace Places.Application.Dtos;

public class SiteApprobationDto
{
    public int SiteId { get; set; }

    public bool IsApproved { get; set; }

    public string RejectReason { get; set; } = null!;
}