using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SosuCentre.CareApp.Views;
using SosuCentre.Entities;
using SosuCentre.Services;

namespace SosuCentre.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class MedicinTaskPageViewModel : BaseViewModel
    {
        private readonly ISosuService sosuService;

        public MedicinTaskPageViewModel(ISosuService sosuService)
        {
            this.sosuService = sosuService;
        }

        [ObservableProperty]
        Assignment assignment;


        [RelayCommand]
        private async Task GoToSubTaskPageAsync()
        {
            sosuService.UpdateAssignment(Assignment);
            await Shell.Current.GoToAsync($"{nameof(SubTaskPage)}", true, new Dictionary<string, object>
            {
                {"Assignment", Assignment }
            });
        }

        //maybe add these commands in the baseviewmodel as they get called both here and in SubTaskPageViewModel
        [RelayCommand]
        private async Task GoToMainPageFromMedicinAsync()
        {
            sosuService.UpdateAssignment(Assignment);
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");

        }

        [RelayCommand]
        private async Task OnSwipeEnded()
        {
            if (Assignment.SubTasks.All(x => x.IsCompleted) && Assignment.MedicineTasks.All(x => x.IsCompleted))
            {
                Assignment.Completed = true;

                await GoToMainPageFromMedicinAsync();
            }
            else
            {
                Assignment.Completed = false;
                await GoToMainPageFromMedicinAsync();
            }

        }


    }
}
