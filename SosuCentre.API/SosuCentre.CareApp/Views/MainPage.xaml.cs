using SosuCentre.CareApp.ViewModels;
using SosuCentre.Services;

namespace SosuCentre.CareApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            this.viewModel = viewModel;
           
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
 

