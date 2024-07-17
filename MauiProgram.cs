using Microsoft.Extensions.Logging;
using PokedexApp.Services;
using PokedexApp.View;

namespace PokedexApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //Services
            builder.Services.AddSingleton<PokeService>();

            //ViewModels
            builder.Services.AddSingleton<PokemonViewModel>();
            builder.Services.AddTransient<PokemonDetailsViewModel>();

            //Views
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<DetailsPage>();

            return builder.Build();
        }
    }
}
