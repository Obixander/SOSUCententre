using SosuCentre.CareApp.ViewModels;

namespace SosuCentre.CareApp.Views;

public partial class MedicinTaskPage : ContentPage
{

    public MedicinTaskPage(MedicinTaskPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }



}