using Microsoft.Extensions.Logging;

using SosuCentre.CareApp.ViewModels;
using SosuCentre.CareApp.Views;
using SosuCentre.Services;

namespace SosuCentre.CareApp
{
    public static class MauiProgram
    {
       // private const string uri = "https://localhost:7044/api/";
        private const string uri = "https://10.0.2.2:7044/api/";
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
            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddScoped<LoginPage>();

            builder.Services.AddSingleton<MainPageViewModel>();

            //im pretty sure this is causing problems by stacking but im not sure how to fix it
            //i might want to change all of this to a scoped service but i dont have time to test if it will cause problems
            builder.Services.AddTransient<MainPage>();

            builder.Services.AddSingleton<SubTaskPageViewModel>();
            builder.Services.AddSingleton<SubTaskPage>();
            
            builder.Services.AddSingleton<MedicinTaskPageViewModel>();
            builder.Services.AddSingleton<MedicinTaskPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
