namespace Places.Application.Dtos;

public class OwnerApprobationDto
{
    public int UserId { get; set; }

    public int UserApprovedId { get; set; }

    public bool IsApproved { get; set; }

    public string RejectReason { get; set; } = null!;

    public string sentAt { get; set; } = "";
}