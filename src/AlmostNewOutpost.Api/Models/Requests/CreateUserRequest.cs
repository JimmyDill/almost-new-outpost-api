using AlmostNewOutpost.Api.Data;
using AlmostNewOutpost.Api.Models.Responses;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

    namespace AlmostNewOutpost.Api.Models.Requests;
    



public class CreateUserRequest
{
    private readonly OutpostDbContext _db;

    public CreateUserRequest(OutpostDbContext db)
    {
        _db = db;
    }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9_]+$", ErrorMessage = "Username can only use letters, digits and underscores.")]
    public string Username { get; set; }

    [Required]
    [StringLength(128, MinimumLength = 8, ErrorMessage = "Password must be 8 to 128 characters.")]
    public string Password { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Choose a role.")]
    public int? RoleId { get; set; }



        private async Task<AdminUserDto> FindUserAsync(int id)
        {
            AdminUserDto? adminUser = await(
                from user in _db.Users
                join role in _db.Roles on user.RoleId equals role.RoleId
                where user.UserId == id
                orderby user.Username
                select new AdminUserDto
                {
                    Id = user.UserId,
                    Username = user.Username,
                    RoleId = role.RoleId,
                    Role = role.RoleName,
                    ArchivedAtUtc = user.ArchivedAtUtc,
                }).FirstOrDefaultAsync();
            return adminUser;
    }
    }
