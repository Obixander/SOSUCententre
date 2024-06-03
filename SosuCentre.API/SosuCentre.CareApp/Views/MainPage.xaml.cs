using SosuCentre.CareApp.ViewModels;
using SosuCentre.Services;

namespace SosuCentre.CareApp.Views
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
           
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
 

