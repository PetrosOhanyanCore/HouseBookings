using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoringController : ControllerBase
    {
        IScoringService _service;

        public ScoringController(IScoringService service) 
        {
            _service = service;
        }

        [HttpGet("GetScoringAsync/{id}")]
        public async Task<IActionResult> GetScoringAsync(int id)
        {
            var result = await _service.GetScoringAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetClientAllScoringsAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsAsync(clientId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetClientAllScoringsByRateAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsByRateAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsByRateAsync(clientId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetClientAllScoringsByDateAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsByDateAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsByDateAsync(clientId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpGet("GetAllClientsByHighestScoringRateAsync/")]
        public async Task<IActionResult> GetAllClientsByHighestScoringRateAsync()
        {
            var result = await _service.GetAllClientsByHighestScoringRateAsync();

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
