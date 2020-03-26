﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SmartClips.Views;

namespace SmartClips.Views
{
    public partial class AppShell : Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
       

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            routes.Add("Login", typeof(LoginPage));
            routes.Add("ShopsList", typeof(ShopsPage));
            routes.Add("Maps", typeof(SmartClips.Views.Maps));
            routes.Add("Logout", typeof(LogoutPage));
            routes.Add("About", typeof(AboutPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
            string animalName = null;

            switch (destinationRoute)
            {
                case "monkeydetails":
                   // animalName = MonkeyData.Monkeys.ElementAt(rand.Next(0, MonkeyData.Monkeys.Count)).Name;
                    break;
                case "catdetails":
                  //  animalName = CatData.Cats.ElementAt(rand.Next(0, CatData.Cats.Count)).Name;
                    break;
                case "dogdetails":
                  //  animalName = DogData.Dogs.ElementAt(rand.Next(0, DogData.Dogs.Count)).Name;
                    break;
               
            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?name={animalName}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Cancel any back navigation
            //if (e.Source == ShellNavigationSource.Pop)
            //{
            //    e.Cancel();
            //}
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }

       
    }
}