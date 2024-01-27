using friendly_speech_api.Data.Dtos.FriendlySpeech.Response;

namespace friendly_speech_api.Services
{
    public class FriendlySpeechService
    {
        public FriendlySpeechService()
        {
            
        }

        public kowalskiAnalysisResponseDTO kowalskiAnalysis(string _text, bool sensored = false)
        {
            string[] ForbiddenWords = { "fodase", "bom dia", "boa tarde", "cabeça de", "cabeca de" };
            bool offensive = false;

            _text = _text.ToLower();
            _text = _text.Replace(" ", "");

            foreach (var item in ForbiddenWords)
            {
                if (_text.Contains(item.Replace(" ", "")))
                {
                    offensive = true;
                    break;
                }
            }

            return new kowalskiAnalysisResponseDTO()
            {
                isOffensive = offensive,
                input = sensored && offensive ? new string('*', _text.Length) : _text,
            };
        }
    }
}
