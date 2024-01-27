using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace friendly_speech_api.Controllers
{

    [ApiController]
    [Route("v1/[controller]")]
    public class FriendlySpeech : Controller
    {
        private string[] ForbiddenWords = {"fodase", "bom dia", "boa tarde"};

        public class Response(string _text){
            public string input = _text;
            public bool isOffensive;
            public string inputCensored = new string('*', _text.Length);
        }

        public FriendlySpeech()
        {
            //Console.WriteLine(analysis);
        }

        [HttpGet]
        public string kowalskiAnalysis(string _text)
        {
            Response analysis = new Response(_text);

            if (_text == ForbiddenWords[0])
            {
                analysis.isOffensive = true;
            }

            return $" isOffensive: {analysis.isOffensive}\n input: {analysis.input}\n inputCensored: {analysis.inputCensored}\n";
        }
    }
}
