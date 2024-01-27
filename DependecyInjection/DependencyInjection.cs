using friendly_speech_api.Services;
using System.Runtime.CompilerServices;

namespace friendly_speech_api.DependecyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterDependecies(this IServiceCollection teste)
        {
            teste.AddScoped<FriendlySpeechService>();
        }
    }
}
