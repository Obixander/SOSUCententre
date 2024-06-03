using CommunityToolkit.Mvvm.Input;
using SosuCentre.Entities;
using SosuCentre.Services;
using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {      
        private readonly ISosuService sosuService;

        public MainPageViewModel(ISosuService sosuService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            UpdateAssignments();
        }
        public ObservableCollection<Entities.Task> TodaysAssignments { get; set; }

        [RelayCommand]
        private async System.Threading.Tasks.Task UpdateAssignments()
        {
            try
            {
                IsBusy = true;
                TodaysAssignments.Clear();
                //TODO: change to use real employee
                var tasks = await sosuService.GetTasksForAsync(DateTime.Now, new Employee() { EmployeeId = 1 });
                foreach (var task in tasks)
                {
                    TodaysAssignments.Add(task);
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                IsBusy = false;
            }
            
        }

    }

}
