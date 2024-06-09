using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SosuCentre.Entities;
using SosuCentre.Services;
using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
     
        

        private readonly ISosuService sosuService;
        private IUserService userService;

        public MainPageViewModel(ISosuService sosuService, IUserService userService)
        {
            Title = "ToDo";
            this.sosuService = sosuService;
            TodaysAssignments = new ObservableCollection<Entities.Assignment>();
            this.userService = userService;
            UpdateAssignments();

        }
        public ObservableCollection<Entities.Assignment> TodaysAssignments { get; set; }
        
        [RelayCommand]
        private async Task UpdateAssignments()
        {
            try
            {
                //this is used to show the loading spinner
                IsBusy = true;
                //clear the list of assignments to insure the list is empty before adding new assignments
                TodaysAssignments.Clear();
                var tasks = await sosuService.GetTasksForAsync(DateTime.Now, new Employee { EmployeeId = userService.GetUserId()});
                foreach (var task in tasks)
                {
                    TodaysAssignments.Add(task);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
            
        }


    }

}
