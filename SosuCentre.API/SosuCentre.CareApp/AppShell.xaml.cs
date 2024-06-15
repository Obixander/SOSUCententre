using SosuCentre.CareApp.Views;

namespace SosuCentre.CareApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SubTaskPage), typeof(SubTaskPage));
            Routing.RegisterRoute(nameof(MedicinTaskPage), typeof(MedicinTaskPage));
        }
    }
}
