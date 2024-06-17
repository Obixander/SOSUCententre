using CommunityToolkit.Mvvm.ComponentModel;
using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private Employee user;

        public BaseViewModel()
        {
            
        }

        public bool IsNotBusy => !isBusy;

 
    }

}
