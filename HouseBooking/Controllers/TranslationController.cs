using BusinessLayer.IService;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
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
    }
}


