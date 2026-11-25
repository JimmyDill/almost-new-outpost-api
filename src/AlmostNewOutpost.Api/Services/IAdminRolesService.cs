using AlmostNewOutpost.Api.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlmostNewOutpost.Api.Repositories;

namespace AlmostNewOutpost.Api.Services
{
    public interface IAdminRolesService
    {
        Task<List<RoleDto>> GetAll();
    }
}
