using CommunityToolkit.Mvvm.Input;
using SosuCentre.CareApp.Views;
using SosuCentre.Entities;
using SosuCentre.Services;
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
        async Task GoToMainAsync(string UserInput)
        {

            if (int.TryParse(UserInput, out int id))
            {
                if (id > 0)
                {
                    UserId = id;

                    UserService userService = new UserService();
                    userService.SetUserId(UserId);
                    await Shell.Current.GoToAsync($"{nameof(MainPage)}");
                    
                }

            }
            return;
        }


    }
}
