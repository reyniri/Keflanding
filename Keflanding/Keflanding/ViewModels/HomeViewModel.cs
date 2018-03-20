﻿/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using Keflanding.Models;
using Xamarin.Forms;
using Keflanding.IViewModels;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;
using System.Collections.Generic;

namespace Keflanding.ViewModels
{
    public class HomeViewModel : BaseViewModel, IHomeViewModel
    {
        private String _welcomeText;
        public String WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                _welcomeText = value;
                OnPropertyChanged(nameof(WelcomeText));
            }
        }

        public ICommand NavigateToCommand { get; set; }

        [Preserve]
        public HomeViewModel()
        {
            this._iNavigationService = DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
            NavigateToCommand = new Command<String>(NavigateTo);

            WelcomeText = "Welcome to Empty Keflanding App !";
        }

        private async void NavigateTo(string param)
        {
            var navigationParams = new NavigationParameters();
            var MySampleModel = new SampleModel() { Id = 0, Name = "Empty Keflanding App Parameter", Items = new List<string>() { "Items 1", "Item 2", "Item 3" } };

            navigationParams.Add(nameof(SampleModel), MySampleModel);
            await _iNavigationService.NavigateTo(param, navigationParams);
        }
    }
}
