namespace SosuCentre.CareApp.Views;
using SosuCentre.CareApp.ViewModels;
public partial class SubTaskPage : ContentPage
{
	public SubTaskPage(SubTaskPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}