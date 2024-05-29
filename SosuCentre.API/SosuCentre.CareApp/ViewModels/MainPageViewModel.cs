using System.Collections.ObjectModel;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "FORSIDEN";

            var a = new Entities.Task
            {
                Resident = new()
                {
                    Name = "Ibn Halfdan"
                },
                TimeStart = new(2024, 01, 01, 12, 00, 00),
                TimeEnd = new(2024, 01, 01, 12, 30, 00)
            };
            var b = new Entities.Task
            {
                Resident = new()
                {
                    Name = "Ib Bifrost"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };

            TodaysAssignments.Add(a);
            TodaysAssignments.Add(b);
        }


        public ObservableCollection<Entities.Task> TodaysAssignments { get; } = new();
    }

}
