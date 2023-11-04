using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            this._clientService = clientService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatClientAsync([FromBody] ClientDTO client)
        {
            if (client == null)
                return BadRequest("Invalid client data.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _clientService.AddClientAsync(client);
            return Ok("Client created successfully");
        }

        [HttpGet("GetClientAsync/{id}")]
        public async Task<IActionResult> GetClientAsync(int id)
        {
            var client = await _clientService.GetClientAsync(id);

            if (client != null)
            {
                return Ok(client);
            }
            return NotFound();

        }

        [HttpGet("GetAllClientAsync")]
        public async Task<IActionResult> GetAllClientAsync()
        {
            var clients = await _clientService.GetAllClientAsync();

            if (clients != null)
            {
                return Ok(clients);
            }
            return NotFound();

        }
        [HttpPut("PutClientAsync")]
        public async Task<IActionResult> PutClientAsync([FromBody] ClientDTO client)
        {
            if (client == null)
                return BadRequest("Invalid client data.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _clientService.UpdateClientAsync(client);
            return Ok("Client updated successfully");
        }

        [HttpDelete("DeleteClientAsync")]
        public async Task<IActionResult> DeleteClientAsync([FromBody] ClientDTO client)
        {
            if (client == null)
                return BadRequest("Invalid client data.");


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _clientService.RemoveClientAsync(client);

            return Ok("Client deleted successfully");

        }



    }
}
