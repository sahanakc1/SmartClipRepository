
using System;
using Xamarin.Forms;
using SmartClips.Views;
using Xamarin.Forms.Xaml;
using SmartClips.Controls;

namespace SmartClips
{
    public partial class App : Application
    {
        public static double screenheight;
        public static double screenwidth;

        public App()
        {

            StyleSheetRegister.RegisterStyle("-xf-horizontal-options", typeof(VisualElement), nameof(View.HorizontalOptionsProperty));
            StyleSheetRegister.RegisterStyle("-xf-shell-navbarhasshadow", typeof(Shell), nameof(Shell.NavBarHasShadowProperty));

            InitializeComponent();

            //Device.SetFlags(new[] { "CarouselView_Experimental", "IndicatorView_Experimental" });

            MainPage = new AppShell();

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
