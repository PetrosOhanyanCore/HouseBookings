using BusinessLayer.IService;
using BusinessLayer.Service;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController: ControllerBase
    {
        private readonly IOptionsService _optionsService;
        public OptionsController(IOptionsService optionsService)
        {
            _optionsService = optionsService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOptionsAsync([FromBody] OptionsDTO option) 
        {
            try
            {

                if (option == null)
                    return BadRequest("Invalid option data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _optionsService.AddOptionsAsync(option);
            
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }

            return Ok("Option added successfully");

        }

        [HttpGet("GetOptionByIdAsync/{id}")]
        public async Task<IActionResult> GetOptionByIdAsync(int id)
        {
            try
            {
                var option = await _optionsService.GetOptionByIdAsync(id);

                if (option != null)
                {
                    return Ok(option);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("RemoveOptionsAsync/{id}")]
        public async Task<IActionResult> RemoveOptionsAsync(int id)
        {
            try
            {
                await _optionsService.RemoveOptionsAsync(id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Option added successfully");

        }

        [HttpPut("UpdateOptionsAsync")]
        public async Task<IActionResult> UpdateOptionsAsync([FromBody] OptionsDTO option)
        {
            try
            {
                if (option == null)
                    return BadRequest("Invalid option data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _optionsService.UpdateOptionsAsync(option);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Option added successfully");

        }

    }
}
