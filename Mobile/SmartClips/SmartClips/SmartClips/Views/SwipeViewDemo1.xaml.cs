using System;
using SmartClips.Controls;
using Xamarin.Forms;

namespace SmartClips.Views
{
   
    public partial class SwipeViewDemo1 : ContentPage
    {
        public SwipeViewDemo1()
        {
            InitializeComponent();
        }
        void OnSwipeViewModeChanged(object sender, EventArgs e)
        {
            //swipeView1.LeftItems.Mode = (SwipeMode)(sender as EnumPicker).SelectedItem;
            //swipeView2.LeftItems.Mode = (SwipeMode)(sender as EnumPicker).SelectedItem;
        }

        void OnSwipeViewBehaviorChanged(object sender, EventArgs e)
        {
            //swipeView1.LeftItems.SwipeBehaviorOnInvoked = (SwipeBehaviorOnInvoked)(sender as EnumPicker).SelectedItem;
            //swipeView2.LeftItems.SwipeBehaviorOnInvoked = (SwipeBehaviorOnInvoked)(sender as EnumPicker).SelectedItem;
        }

        async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }

        async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Favorite invoked.", "OK");
        }
    }
}