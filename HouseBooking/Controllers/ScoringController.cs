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
            try
            {
                var result = await _service.GetScoringAsync(id);
                return Ok(result);
            }
            catch (Exception)
            {
                    return NotFound();
                }
        }

        [HttpGet("GetClientAllScoringsAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsAsync(int clientId)
        {
            try
            {
                var result = await _service.GetClientAllScoringsAsync(clientId);
                return Ok(result);
            }
            catch (Exception)
            {
                    return NotFound();
            }
        }

        [HttpGet("GetClientAllScoringsByRateAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsByRateAsync(int clientId)
        {
            try
            {
                var result = await _service.GetClientAllScoringsByRateAsync(clientId);
                return Ok(result);
            }
            catch (Exception)
            {
                    return NotFound();
                }
        }

        [HttpGet("GetClientAllScoringsByDateAsync/{clientId}")]
        public async Task<IActionResult> GetClientAllScoringsByDateAsync(int clientId)
        {
            try
            {
                var result = await _service.GetClientAllScoringsByDateAsync(clientId);
                return Ok(result);
            }
            catch (Exception)
            {
                    return NotFound();
                }
        }


        [HttpGet("GetAllClientsByHighestScoringRateAsync/")]
        public async Task<IActionResult> GetAllClientsByHighestScoringRateAsync()
        {
            try
            {
                var result = await _service.GetAllClientsByHighestScoringRateAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
