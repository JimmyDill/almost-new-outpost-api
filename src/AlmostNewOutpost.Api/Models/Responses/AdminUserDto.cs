namespace AlmostNewOutpost.Api.Models.Responses
{
    /// <summary>
    /// This shows the role of an admin user, for display in the admin UI.
    /// It is not used for authorization checks.
    /// </summary>
    public class AdminUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime? ArchivedAtUtc { get; set; }

    }
}
