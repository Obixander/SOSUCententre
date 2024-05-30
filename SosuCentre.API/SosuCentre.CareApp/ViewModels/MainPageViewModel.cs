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
        }
    }

}
