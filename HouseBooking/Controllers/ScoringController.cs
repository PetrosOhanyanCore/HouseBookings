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
        public async Task<ScoringDTO> GetScoringAsync(int id)
        {
            var result = await _service.GetScoringAsync(id);
            return result;
        }

        [HttpGet("GetClientAllScoringsAsync/{clientId}")]
        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsAsync(clientId);
            return result;
        }

        [HttpGet("GetClientAllScoringsByRateAsync/{clientId}")]
        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByRateAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsByRateAsync(clientId);
            return result;
        }

        [HttpGet("GetClientAllScoringsByDateAsync/{clientId}")]
        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByDateAsync(int clientId)
        {
            var result = await _service.GetClientAllScoringsByDateAsync(clientId);
            return result;
        }


        [HttpGet("GetAllClientsByHighestScoringRateAsync/")]
        public async Task<IEnumerable<ClientDTO>> GetAllClientsByHighestScoringRateAsync()
        {
            var result = await _service.GetAllClientsByHighestScoringRateAsync();
            return result;
        }
    }
}
