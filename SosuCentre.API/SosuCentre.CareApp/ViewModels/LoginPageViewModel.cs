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
        private IUserService userService;
        //dependency injection of IUserService to set the userId
        public LoginPageViewModel(IUserService userService)
        {
            this.userService = userService;
        }


        [RelayCommand]
        async Task GoToMainAsync(string UserInput)
        {

            if (int.TryParse(UserInput, out int id))
            {
                if (id > 0)
                {
                    userService.SetUserId(id);
                    await Shell.Current.GoToAsync($"{nameof(MainPage)}");
                    
                }

            }
            return;
        }


    }
}
