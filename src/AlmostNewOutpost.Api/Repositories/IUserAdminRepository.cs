using AlmostNewOutpost.Api.Models.Entities;
using AlmostNewOutpost.Api.Models.Responses;

namespace AlmostNewOutpost.Api.Repositories
{
    public interface IUserAdminRepository
    {
        Task<List<AdminUserDto>> GetAllAsync(bool includeArchived);

        Task<User?> FindByIdAsync(int userId);
        Task SaveChangesAsync();

    }
}
