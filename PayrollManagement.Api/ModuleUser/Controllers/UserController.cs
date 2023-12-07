using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleUser.Interfaces;
using PayrollManagement.Api.ModuleUser.ViewModel;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Contracts;
using PayrollManagement.Infraestructure.HelperModels;

namespace PayrollManagement.Api.ModuleUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private ILogger<UserController> _logger;
        private readonly IMapper _mapper;
         private readonly IUserRepository _userRepository;
        public UserController(IUserService userService, ILogger<UserController> logger, IMapper mapper, IUserRepository userRepository)
        {
            _userService = userService;
            _logger = logger;
            _mapper = mapper;
            _userRepository = userRepository;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] UserViewModel newUser)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var user = _mapper.Map<User>(newUser);
                    await _userService.AddAsync(user);
                    return Ok();
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _userRepository.GetUserWithUserInfo();
                if (query.Any())
                {
                    var users = _mapper.Map<List<UserQueryViewModel>>(query);
                    return Ok(users);
                }
                return NotFound();
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserViewModel updateUser)
        {
            try
            {
                if( ModelState.IsValid)
                {
                    var user = _mapper.Map<User>(updateUser);
                    await _userService.UpdateAsync(user);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                var user = await _userService.GetByIdAsync(id);
                if (user == null)
                    return NotFound("User does not exist");
                user.IsActive = false;
                user.IsDeleted = false;
                await _userService.UpdateAsync(user);
                return Accepted();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginViewModel userLogin)
        {
            try
            {
                var user = _mapper.Map<UserLogin>(userLogin);
                var query = await _userRepository.GetUserLogin(user);
                if (query != null)
                {
                    var loginUser = _mapper.Map<UserQueryViewModel>(query);
                    return Ok(loginUser);
                }
                
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
