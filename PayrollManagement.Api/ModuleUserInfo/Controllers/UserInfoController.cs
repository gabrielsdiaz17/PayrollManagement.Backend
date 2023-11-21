using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleUserInfo.Interface;
using PayrollManagement.Api.ModuleUserInfo.Services;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleUserInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        private ILogger<UserInfoController> _logger;
        private readonly IMapper _mapper;

        public UserInfoController(IUserInfoService userInfoService, ILogger<UserInfoController> logger, IMapper mapper)
        {
            _userInfoService = userInfoService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserInfoViewModel newUserInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userInfo = _mapper.Map<UserInfo>(newUserInfo);
                    await _userInfoService.AddAsync(userInfo);

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
                var query = await _userInfoService.GetAllAsync();
                var userInfoList = _mapper.Map<List<UserInfo>>(query);
                return Ok(userInfoList);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task <IActionResult> Update([FromBody] UserInfoViewModel updateUserInfo)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var userInfo = _mapper.Map<UserInfo>(updateUserInfo);
                    await _userInfoService.UpdateAsync(userInfo);
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
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var userInfo = await _userInfoService.GetByIdAsync(id);
                if (userInfo == null)
                    return NotFound("User info not found");
                userInfo.IsDeleted = true;
                userInfo.IsActive = false;
                await _userInfoService.UpdateAsync(userInfo);
                return Accepted();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
