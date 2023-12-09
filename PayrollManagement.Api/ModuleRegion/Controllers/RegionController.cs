using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleRegion.Interfaces;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleRegion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        private ILogger<RegionController> _logger;
        
        public RegionController(IRegionService regionService, ILogger<RegionController> logger)
        {
            _regionService = regionService;            
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Region newRegion)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _regionService.AddAsync(newRegion);
                    var regionId = newRegion.Id;
                    return Ok(new { Id = regionId });
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            try
            {
                var regions = await _regionService.GetAllAsync();
                return Ok(regions);
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpPut]
        public async Task <IActionResult> Update([FromBody] Region updateRegion)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _regionService.UpdateAsync(updateRegion);
                    return Ok();
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                var region = await _regionService.GetByIdAsync(id);
                if (region == null)
                    return NotFound("Region does not exist");
                region.IsActive = false;
                region.IsDeleted = true;
                return Accepted();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
