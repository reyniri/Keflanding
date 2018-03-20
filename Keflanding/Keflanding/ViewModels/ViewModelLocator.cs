/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using Keflanding.Services;
using Keflanding.IServices;
using Keflanding.IViewModels;
using Xamarin.Forms.Popups;
using Xamarin.Forms.Navigation;

namespace Keflanding.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<IDetailsViewModel, DetailsViewModel>();

            DependencyService.Register<IUserServices, UserServices>();
            DependencyService.Register<IPopupsService, PopupsService>();
            DependencyService.Register<INavigationService, NavigationService>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }

        public IDetailsViewModel Details
        {
            get
            {
                return DependencyService.Get<IDetailsViewModel>();
            }
        }
    }
}
