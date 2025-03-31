namespace Places.Domain.Common;

public abstract class EntityBase
{
    [Key]
    [Required(ErrorMessage = "The Id is required")]
    public int Id { get; set; }

    public int CreatedBy { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public int UpdatedBy { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }

    public bool IsActive { get; set; } = true;
}