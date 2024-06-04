using SosuCentre.CareApp.ViewModels;

namespace SosuCentre.CareApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	protected override void OnAppearing()
    {
        base.OnAppearing();
    }

}