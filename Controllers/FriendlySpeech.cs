using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace friendly_speech_api.Controllers
{

    [ApiController]
    [Route("v1/[controller]")]
    public class FriendlySpeech : Controller
    {
        public FriendlySpeech()
        {
            
        }

        [HttpGet]
        public string sendAnalysis(string _text)
        {

            return "tudo errado";
        }
    }
}
