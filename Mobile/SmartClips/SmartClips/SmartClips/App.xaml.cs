using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartClips.Services;
using SmartClips.Views;

namespace SmartClips
{
    public partial class App : Application
    {
        public static double screenheight;
        public static double screenwidth;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
