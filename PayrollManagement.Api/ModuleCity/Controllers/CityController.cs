using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleCity.Interfaces;
using PayrollManagement.Api.ModuleCity.ViewModel;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleCity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        private ILogger <CityController> _logger;
        private IMapper _mapper;

        public CityController(ICityService cityService, ILogger<CityController> logger, IMapper mapper)
        {
            _cityService = cityService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] CityViewModel newCity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var city = _mapper.Map<City>(newCity);
                    await _cityService.AddAsync(city);
                    var cityId = city.Id;

                    return Ok(new { Id = cityId});
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
                var query = await _cityService.GetAllAsync();
                var cities = _mapper.Map<List<CityViewModel>>(query);
                return Ok(cities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });

            }
        }
        [HttpPut]
        public async Task <IActionResult> Update([FromBody] CityViewModel updateCity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var city = _mapper.Map<City>(updateCity);
                    await _cityService.UpdateAsync(city);
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
                var city = await _cityService.GetByIdAsync(id);
                if (city == null)
                    return NotFound("User does not exist");
                city.IsActive = false;
                city.IsDeleted = true;
                await _cityService.UpdateAsync(city);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
