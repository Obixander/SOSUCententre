using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SosuCentre.Entities;
using SosuCentre.Services;
using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    [QueryProperty("UserId", "UserId")]
    public partial class MainPageViewModel : BaseViewModel
    {
        //TODO: change to use real employee by getting the employee from the login page

        private readonly ISosuService sosuService;
        private string employeeName;
        [ObservableProperty]
        private int userId;

        public MainPageViewModel(ISosuService sosuService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            TodaysAssignments = new ObservableCollection<Entities.Assignment>();
            UpdateAssignments();

        }
        public ObservableCollection<Entities.Assignment> TodaysAssignments { get; set; }
        public string EmployeeName { 
            get => employeeName;
            set
            {
                if (employeeName != value)
                {
                    employeeName = value;
                    OnPropertyChanged();
                }
            }
        }


        
        [RelayCommand]
        private async System.Threading.Tasks.Task UpdateAssignments()
        {
            try
            {
                IsBusy = true;
                TodaysAssignments.Clear();
                //TODO: change to use real employee
                
                var tasks = await sosuService.GetTasksForAsync(DateTime.Now, new Employee { EmployeeId = UserId });
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
