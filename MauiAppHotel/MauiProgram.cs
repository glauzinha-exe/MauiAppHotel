using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Chango-Regular.ttf", "Chango");
                    fonts.AddFont("Silkscreen-Regular.ttf", "Silkscreen");
                    fonts.AddFont("Silkscreen-Bold.ttf", "SilkscreenBold");
                    fonts.AddFont("Teko-Regular.ttf", "Teko"); 
                    fonts.AddFont("Coustard-Regular.ttf", "Coustard");
                    fonts.AddFont("Coustard-Black.ttf", "CoustardBlack");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
