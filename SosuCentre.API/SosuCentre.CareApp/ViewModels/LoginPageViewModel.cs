using CommunityToolkit.Mvvm.Input;
using SosuCentre.CareApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.CareApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        private int userId;

        public LoginPageViewModel()
        {
            
        }

        public int UserId
        {
            get => userId;
            set => SetProperty(ref userId, value);
        }
        [RelayCommand]
        async Task GoToMainAsync(int UserId)
        {
            if (UserId != 0)
            {
                await Shell.Current.GoToAsync($"{nameof(MainPage)}", true, new Dictionary<string, object>
                {
                    {"UserId", UserId }
                });
            }
        }


    }
}
