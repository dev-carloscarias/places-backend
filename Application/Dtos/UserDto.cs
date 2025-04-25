namespace Places.Application.Dtos;

public class UserDto
{ 
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public bool MustChangePassword { get; set; }

    public int RoleId { get; set; }

    public int CountryId { get; set; }

    public bool HasProperties { get; set; }

    public bool HasTelephoneValidated { get; set; }

    public bool HasEmailValidated { get; set; }

    public int UserTypeId { get; set; }

    public string ProfilePicture { get; set; } = null!;
    public string? DocumentoId { get; set; }

    public string? DocumentoIdType { get; set; }
    public string? BusinessPatent { get; set; }
    public string? BusinessPatentType { get; set; }
    public string? LegalRepresentation { get; set; }
    public string? LegalRepresentationType { get; set; }

    public string Telephone { get; set; } = null!;

    public DateTimeOffset? DateOfBirth { get; set; }

    public bool? IsOwnerRejected { get; set; }

    public bool IsPendingToResolve { get; set; }

    public string RejectReason { get; set; } = null!;

    public bool IsOwnerApproved { get; set; }

    public DateTimeOffset? RegistrationDate { get; set; }
    public string Address { get; set; } = string.Empty;
    public string CorporateEmail { get; set; } = string.Empty;
    public string AboutMe { get; set; } = string.Empty;
    public List<HobbieDto> Hobbies { get; set; } = new List<HobbieDto>();
    public string? PhotoVerification { get; set; } = string.Empty;
}