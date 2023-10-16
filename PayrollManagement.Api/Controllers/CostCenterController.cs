using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Business.ModuleCostCenter.Interfaces;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleCostCenter.ViewModels;

namespace PayrollManagement.Api.Controllers
{
    public class CostCenterController : Controller
    {
        private readonly ICostCenterService _costCenterService;
        private readonly ILogger <CostCenterController>_logger;
        private readonly IMapper _mapper;

        public CostCenterController(ICostCenterService costCenterService, ILogger <CostCenterController> logger, IMapper mapper)
        {
            _costCenterService = costCenterService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var costCenters = _costCenterService.GetAllAsync();
                var costCenterViewModels = _mapper.Map<List<CostCenterViewModel>>(costCenters);
                return Ok(costCenterViewModels);
            }           
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);  
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CostCenterViewModel newCostCenterVM) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var costCenter = _mapper.Map<CostCenter>(newCostCenterVM);
                    await _costCenterService.AddAsync(costCenter);
                    return Ok();

                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpPut]
        public  async Task<IActionResult> Update([FromBody] CostCenterViewModel costCenterVM) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var costCenter = _mapper.Map<CostCenter>(costCenterVM);
                    await _costCenterService.UpdateAsync(costCenter);
                    return Ok();
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpDelete("delete/{id}")]

        public async Task<IActionResult> Delete (int id)
        {
            try
            {
                var costCenter = _costCenterService.GetByIdAsync(id);
                if (costCenter == null)
                    return NotFound("Cost center does not exist");
                
                //await _costCenterService.DeleteAsync(costCenter);
                return Accepted();

            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
