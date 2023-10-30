using BusinessLayer.IService;
using HouseBooking.IControllers;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase, IClientController
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientAsync(int id)
        {
            var client = await _clientService.GetClientAsync(id);

            if (client != null)
            {
                return Ok(client);
            }
            return NotFound();

        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientAsync()
        {
            var clients = await _clientService.GetAllClientAsync();

            if (clients != null)
            {
                return Ok(clients);
            }
            return NotFound();

        }
        [HttpPut]
        public async Task<IActionResult> PutClientAsync([FromBody] ClientDTO client) 
        {
            if (client == null)
                return BadRequest("Invalid client data.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _clientService.UpdateClientAsync(client);
            return Ok("Client updated successfully");
        }

        [HttpDelete]
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
