using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleCostCenter.ViewModels;
using PayrollManagement.Business.ModuleWorker.Interfaces;
using PayrollManagement.Business.ModuleWorker.Models;
using PayrollManagement.Business.ModuleWorker.ViewModels;

namespace PayrollManagement.Api.Controllers
{
    public class WorkerController : ControllerBase
    {
        public IWorkerService _workerService;
        public ILogger<WorkerController> _loggger;
        public IMapper _mapper;
        public WorkerController(IWorkerService workerService, ILogger<WorkerController> logger, IMapper mapper) 
        {
            _workerService = workerService;
            _loggger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WorkerViewModel newWorkerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var worker = _mapper.Map<Worker>(newWorkerVM);
                    //await _workerService.AddAsync(worker);
                    return Ok();

                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        public async Task<IActionResult> Update([FromBody] WorkerViewModel workerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var worker = _mapper.Map<Worker>(workerVM);
                    //await _workerService.UpdateAsync(worker);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpDelete("delete/{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                //var worker = _workerService.GetByIdAsync(id);
                //if (worker == null)
                    return NotFound("Cost center does not exist");

                //await _workerService.DeleteAsync(worker);
                return Accepted();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
