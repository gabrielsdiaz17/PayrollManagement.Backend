﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleCostcenter.Interfaces;
using PayrollManagement.Api.ModuleCostcenter.ViewModel;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleCostcenter.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostCenterController : ControllerBase
    {
        private readonly ICostCenterService _costCenterService;
        private ILogger<CostCenterController> _logger;
        private readonly IMapper _mapper;
        public CostCenterController(ICostCenterService costCenterService, IMapper mapper, ILogger<CostCenterController> logger)
        {
            _costCenterService = costCenterService;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CostCenterViewModel newCostCenterVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var costCenter = _mapper.Map<CostCenter>(newCostCenterVM);
                    await _costCenterService.AddAsync(costCenter);
                    var costCenterId = costCenter.Id;
                    return Ok(new { Id = costCenterId});

                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString()});
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _costCenterService.GetCostCenterWithUser();
                if (query.Any())
                {
                    var costCenters = _mapper.Map<List<CostCenterQueryViewModel>>(query);
                    return Ok(costCenters);
                }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CostCenterViewModel costCenterVM)
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
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                var costCenter = await _costCenterService.GetByIdAsync(id);
                
                if (costCenter == null)
                    return NotFound("Cost Center does not exist");
                costCenter.IsActive = false;
                costCenter.IsDeleted = true;
                //Pending to see user that updates if its by jwt and identity
                await _costCenterService.UpdateAsync(costCenter);
                return Accepted();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
            
        }
        [HttpGet("costCentersBySupervisor/{id}")]
        public async Task<IActionResult> CostCentersBySupervisor(long id)
        {
            try
            {
                var query = await _costCenterService.GetCostCenterWithUser();
                if (query.Any())
                {
                    var costCenters = _mapper.Map<List<CostCenter>>(query);
                    costCenters = query.Where(costCenter => costCenter.UserId == id).ToList();
                    return Ok(costCenters);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }

        }
    }
}
