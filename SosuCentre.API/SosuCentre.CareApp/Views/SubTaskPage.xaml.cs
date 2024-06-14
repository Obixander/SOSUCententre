namespace SosuCentre.CareApp.Views;
using SosuCentre.CareApp.ViewModels;
public partial class SubTaskPage : ContentPage
{
	private SubTaskPageViewModel viewModel;
	public SubTaskPage(SubTaskPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		this.viewModel = viewModel;
	}

    //find away to move this to the viewmodel proberly
    private void FinishedSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        viewModel.FinishedSlider_ValueChanged(sender, e);
    }
}