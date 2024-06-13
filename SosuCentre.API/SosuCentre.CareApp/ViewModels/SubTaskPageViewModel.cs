using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SosuCentre.CareApp.Views;
using SosuCentre.Entities;
namespace SosuCentre.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class SubTaskPageViewModel : BaseViewModel
    {
        public SubTaskPageViewModel()
        {
        }

        [ObservableProperty]
        Assignment assignment;

        [RelayCommand]
        private async Task GoToMainPageAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");

        }

    }
}
