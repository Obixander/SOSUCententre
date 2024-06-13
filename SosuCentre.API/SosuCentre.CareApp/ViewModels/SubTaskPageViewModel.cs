using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
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

        //this was for testing
        //partial void OnAssignmentChanged(Assignment value)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
