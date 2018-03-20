/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using System.Reflection;
using System.Globalization;

using Keflanding.Views;
using Xamarin.Forms.ToolKit.Extensions;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Keflanding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #region Init ImageResourceExtension
            ImageResourceExtension.InitImageResourceExtension("AppResources.Assets", typeof(App).GetTypeInfo().Assembly);
            #endregion

            #region Init TranslateExtension            
            TranslateExtension.InitTranslateExtension("AppResources.Localization.Resources", CultureInfo.CurrentCulture, typeof(App).GetTypeInfo().Assembly);
            #endregion

            NavigationPage navigationPage = new NavigationPage(new HomeView());
            navigationPage.BarBackgroundColor = Color.FromHex("#7E1335");
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=b1244922-828c-4121-aa6d-25cce881d18d;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
