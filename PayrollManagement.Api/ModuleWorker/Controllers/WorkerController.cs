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
                var workers = _mapper.Map<List<WorkerQueryViewModel>>(query);
                return Ok(workers);

            }
            catch(Exception ex) 
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet("workerById/{id}")]

        public async Task<IActionResult> WorkerById(int id)
        {
            try
            {
                var query = await _workerService.GetByIdAsync(id);
                var worker = _mapper.Map<WorkerQueryViewModel>(query);
                return Ok(worker);

            }
            catch (Exception ex)
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

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var worker = await _workerService.GetByIdAsync(id);
                if (worker == null)
                    return NotFound("Worker does not exist");
                worker.IsDeleted = true;
                //Pending to see user that updates if its by jwt and identity
                await _workerService.UpdateAsync(worker);
                return Accepted();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet("workerByCostCenter/{id}")]
        public async Task<IActionResult> WorkerByCostCenter(long id)
        {
            try
            {
                var query = await _workerService.GetAllAsync();
                var workers = query.Where(worker => worker.CostCenterId == id).ToList(); 
                if (workers.Any())
                    return Ok(workers);
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new {message = ex.Message.ToString() });
            }

        }
    }
}
