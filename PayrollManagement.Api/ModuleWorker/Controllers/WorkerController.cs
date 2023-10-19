using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Api.ModuleWorker.Interfaces;
using PayrollManagement.Api.ModuleWorker.ViewModels;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleWorker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        public ILogger<WorkerController> _loggger;
        private readonly IMapper _mapper;
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
                    var worker = _mapper.Map<Worker>(newWorkerVM);
                    await _workerService.AddAsync(worker);
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
                var query = await _workerService.GetAllAsync();
                var items = query.Select(x => new WorkerViewModel
                {
                    Id = x.Id,
                    UserInfoId = x.UserInfoId,
                    UserInfo = x.UserInfo
                });
                return Ok(items);

            }
            catch(Exception ex) 
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] WorkerViewModel workerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var worker = _mapper.Map<Worker>(workerVM);
                    await _workerService.UpdateAsync(worker);
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
                var worker = _workerService.GetByIdAsync(id);
                if (worker == null)
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
