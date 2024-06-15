namespace SosuCentre.CareApp.Views;
using SosuCentre.CareApp.ViewModels;
using Microsoft.Maui.Controls;
using SosuCentre.Entities;
using CommunityToolkit.Mvvm.Input;

public partial class SubTaskPage : ContentPage
{
	public SubTaskPage(SubTaskPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    

   
}