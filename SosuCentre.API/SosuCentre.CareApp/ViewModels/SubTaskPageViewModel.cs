﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Migrations;
using SosuCentre.CareApp.Views;
using SosuCentre.Entities;
using SosuCentre.Services;

namespace SosuCentre.CareApp.ViewModels
{
    [QueryProperty(nameof(Assignment), "Assignment")]
    public partial class SubTaskPageViewModel : BaseViewModel
    {
        private ISosuService sosuService;

        public SubTaskPageViewModel(ISosuService sosuService)
        {
            this.sosuService = sosuService;
        }

        [ObservableProperty]
        Assignment assignment;


        //this goes back to the main page and saves the assignment to the database
        [RelayCommand]
        private async Task GoToMainPageAsync()
        {
            sosuService.UpdateAssignment(Assignment);
            await Shell.Current.GoToAsync($"{nameof(MainPage)}");

        }

        public async void FinishedSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //find a way to not hard code the 100 
            if (e.NewValue == 100.0)
            {
                if (Assignment.SubTasks.All(x => x.IsCompleted))
                {
                    Assignment.Completed = true;

                   await GoToMainPageAsync();
                }
                else
                {
                    Assignment.Completed = false;
                    await GoToMainPageAsync();
                }

            }
        }

        public async void OnSwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            if (Assignment.SubTasks.All(x => x.IsCompleted))
            {
                Assignment.Completed = true;

                await GoToMainPageAsync();
            }
            else
            {
                Assignment.Completed = false;
                await GoToMainPageAsync();
            }
        }

    }
}
