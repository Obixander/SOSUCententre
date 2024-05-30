using SosuCentre.Entities;
using SosuCentre.Services;
using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {      
        private readonly ISosuService sosuService;
        public ObservableCollection<Entities.Task> TodaysAssignments { get; set; } = new ObservableCollection<Entities.Task>();    

        public MainPageViewModel(ISosuService sosuService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            UpdateAssignments();
        }

        private async System.Threading.Tasks.Task UpdateAssignments()
        {
            TodaysAssignments.Clear();
            //TODO: change to use real employee
            var tasks = await sosuService.GetTasksForAsync(DateTime.Now, new Employee() { EmployeeId = 1});
            foreach (var task in tasks)
            {
                TodaysAssignments.Add(task);
            }
            
        }

    }

}
