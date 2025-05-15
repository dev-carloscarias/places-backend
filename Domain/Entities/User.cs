namespace Places.Domain.Entities;

public class User : EntityBase
{ 
    public string Email { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateTimeOffset? DateOfBirth { get; set; }

    public DateTimeOffset? RegistrationDate { get; set; }

    public string? Salt { get; set; } = null!;

    public string? HashedPassword { get; set; } = null!;

    public bool MustChangePassword { get; set; } = false;

    public string? PlatformId { get; set; } = null!;

    public int UserTypeId { get; set; } = 1;

    public int RoleId { get; set; } = 2;

    public int CountryId { get; set; } = 80;

    public bool HasProperties { get; set; } = false;

    public string? ProfilePicture { get; set; } = null!;
    public string? DocumentoId { get; set; }

    public string? DocumentoIdType { get; set; }
    public string? BusinessPatent { get; set; }
    public string? BusinessPatentType { get; set; }
    public string? LegalRepresentation { get; set; }
    public string? LegalRepresentationType { get; set; }

    public string? Telephone { get; set; } = null!;

    public bool HasEmailValidated { get; set; } = false;

    public string EmailCodeValidation { get; set; } = null!;

    public bool HasTelephoneValidated { get; set; } = false;

    public string TelephoneCodeValidation { get; set; } = null!;

    public bool IsOwnerApproved { get; set; } = false;

    public bool? IsOwnerRejected { get; set; }

    public bool IsPendingToResolve { get; set; } = false;

    public string? RejectReason { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public string? CorporateEmail { get; set; } = string.Empty;
    public string? AboutMe { get; set; } = string.Empty;
    public ICollection<Hobbie> Hobbies { get; set; } = new List<Hobbie>();

    public virtual UserType UserType { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;
    public string? PhotoVerification { get; set; }
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

}