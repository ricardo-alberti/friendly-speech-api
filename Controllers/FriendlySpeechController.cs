using friendly_speech_api.Data.Dtos.FriendlySpeech.Response;
using friendly_speech_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace friendly_speech_api.Controllers
{

    [ApiController]
    [Route("v1/[controller]")]
    public class FriendlySpeechController : Controller
    {
        private readonly FriendlySpeechService _service;
        public FriendlySpeechController(FriendlySpeechService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<kowalskiAnalysisResponseDTO> kowalskiAnalysis(string _text, bool _sensored)
        {
            var response = _service.kowalskiAnalysis(_text, _sensored);

            return response;
        }
    }
}
