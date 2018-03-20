/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Keflanding.Models;
using Xamarin.Forms;
using Keflanding.IViewModels;
using Xamarin.Forms.Popups;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;

namespace Keflanding.ViewModels
{
    public class DetailsViewModel : BaseViewModel, IDetailsViewModel
    {
        private SampleModel _mySampleModel;
        public SampleModel MySampleModel
        {
            get { return _mySampleModel; }
            set
            {
                _mySampleModel = value;
                OnPropertyChanged(nameof(MySampleModel));
            }
        }

        public ICommand SelectedItemCommand { get; set; }

        [Preserve]
        public DetailsViewModel()
        {
            this._iPopupsService = DependencyService.Get<IPopupsService>(DependencyFetchTarget.GlobalInstance);
            this._iNavigationService = DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
            MySampleModel = _iNavigationService.GetParameters().GetValue<SampleModel>(nameof(SampleModel));

            SelectedItemCommand = new Command<string>(SelectedItem);
        }

        private async void SelectedItem(string param)
        {
            await _iPopupsService.DisplayAlert("SelectedItem", param, "Ok");
        }
    }
}
