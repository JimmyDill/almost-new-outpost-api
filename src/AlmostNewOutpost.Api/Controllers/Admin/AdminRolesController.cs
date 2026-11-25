using AlmostNewOutpost.Api.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using AlmostNewOutpost.Api.Data;
using Microsoft.EntityFrameworkCore;
using AlmostNewOutpost.Api.Services;

namespace AlmostNewOutpost.Api.Controllers.Admin
{
    [ApiController]
    [Route("api/admin/roles")]
    public class AdminRolesController : ControllerBase
    {
        private readonly IAdminRolesService _roles;

        public AdminRolesController(IAdminRolesService rolesService)
        {
            _roles = rolesService;
        }

        [HttpGet]
        public async Task<List<RoleDto>> GetAll()
        {
            List<RoleDto> roles = await _roles.GetAll();
            return roles;

        }
    }
}