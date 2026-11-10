namespace AlmostNewOutpost.Api.Models.Responses
{
    /// <summary>
    /// This shows the role of a user, for display in the admin UI.
    /// It is not used for authorization checks.
    /// </summary>
    public class RoleDto
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;

    }
}
