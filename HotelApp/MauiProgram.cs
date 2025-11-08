using Microsoft.Extensions.Logging;

namespace HotelApp
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
                    fonts.AddFont("Carattere-Regular.ttf", "Cat"); //guardando as fontes para depois serem usadas
                    fonts.AddFont("PoiretOne-Regular.ttf", "Bunny");
                    fonts.AddFont("AlfaSlabOne-Regular.ttf", "Alfa");
                    fonts.AddFont("JotiOne-Regular.ttf", "Jot");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
