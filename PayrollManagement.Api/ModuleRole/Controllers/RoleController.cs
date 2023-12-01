using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleRole.Interfaces;
using PayrollManagement.Api.ModuleRole.ViewModel;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private ILogger <RoleController> _logger;
        private readonly IMapper _mapper;
        public RoleController(IRoleService roleService, ILogger<RoleController> logger, IMapper mapper)
        {
            _roleService = roleService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] RoleViewModel newRole)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var role = _mapper.Map<Role>(newRole);
                    await _roleService.AddAsync(role);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _roleService.GetAllAsync();
                var roles = _mapper.Map<List<Role>>(query);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task <IActionResult> Update([FromBody] RoleViewModel updateRole)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var role = _mapper.Map<Role>(updateRole);
                    await _roleService.UpdateAsync(role);
                    return Ok();
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpDelete("id")]
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                var role = await _roleService.GetByIdAsync(id);
                if (role == null)
                    return NotFound("Role does not exist");
                role.IsActive = false;
                role.IsDeleted = true;
                await _roleService.UpdateAsync(role);
                return Accepted();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
