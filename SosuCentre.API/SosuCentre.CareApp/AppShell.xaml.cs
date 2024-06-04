using SosuCentre.CareApp.Views;

namespace SosuCentre.CareApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
