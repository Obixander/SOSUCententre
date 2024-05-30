using Microsoft.Extensions.Logging;

using SosuCentre.CareApp.ViewModels;
using SosuCentre.CareApp.Views;
using SosuCentre.Services;

namespace SosuCentre.CareApp
{
    public static class MauiProgram
    {
        private const string uri = "https://localhost:7044/api/";
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
            Uri baseUri = new Uri(uri);
            builder.Services.AddScoped<ISosuService>(x=> new ApiService(baseUri));
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
