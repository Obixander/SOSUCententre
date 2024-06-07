using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SosuCentre.Entities;
using SosuCentre.Services;
using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        //change later
        private int id;
        

        private readonly ISosuService sosuService;
        //remove later
        private string employeeName;




        public MainPageViewModel(ISosuService sosuService, IUserService userService)
        {
            Title = "FORSIDEN";
            this.sosuService = sosuService;
            TodaysAssignments = new ObservableCollection<Entities.Assignment>();
            Id = userService.GetUserId();
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

        public int Id { get => id; set => id = value; }

        [RelayCommand]
        private async System.Threading.Tasks.Task UpdateAssignments()
        {
            try
            {
                IsBusy = true;
                TodaysAssignments.Clear();
                //TODO: change to use real employee
                
                var tasks = await sosuService.GetTasksForAsync(DateTime.Now, new Employee { EmployeeId = Id});
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
