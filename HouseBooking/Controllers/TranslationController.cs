using BusinessLayer.IService;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;

namespace HouseBooking.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        ITranslationService _translationService;
        public TranslationController(ITranslationService translationService)
        {
            this._translationService = translationService;
        }


        [HttpGet("SwithLanguage")]
        public IActionResult SwithLanguage(string language)
        {
            int translation = _translationService.SwithLanguage(language);

            if (translation != 0)
            {
                return Ok(translation);
            }
            return NotFound(language);
        }

        [HttpGet("GetAllTranslationAsync")]
        public async Task<IEnumerable<TranslationDTO>> GetAllTranslationAsync()
        {
            return await _translationService.GetAllTranslationAsync();
        }

        [HttpGet("GetTranslationByIdAsync/{id}")]
        public async Task<TranslationDTO> GetTranslationByIdAsync(int id)
        {
            return await _translationService.GetTranslationByIdAsync(id);
        }

        [HttpPost]
        public async Task AddTranslationAsync(TranslationDTO translationDTO)
        {
            await _translationService.AddTranslationAsync(translationDTO);
        }

        [HttpDelete("RemoveTranslationAsync/{id}")]
        public async Task RemoveTranslationAsync(int id)
        {
            await _translationService.RemoveTranslationAsync(id);
        }

        [HttpPut("UpdateTranslationAsync")]
        public async Task UpdateTranslationAsync(TranslationDTO translationDTO)
        {
            await _translationService.UpdateTranslationAsync(translationDTO);
        }

    }
}


