namespace Places.Domain.Define;

public enum RoleId
{
    /// <summary>
    /// Super Administrator
    /// </summary>
    SuperAdmin = 1,

    /// <summary>
    /// Regular user (client and/or owner)
    /// </summary>
    RegularUser = 2,

    /// <summary>
    /// Administrator
    /// </summary>
    Admin = 3
}