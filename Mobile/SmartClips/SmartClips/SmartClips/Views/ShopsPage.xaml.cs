using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartClips.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
  
    public partial class ShopsPage : ContentPage
    {
        public ShopsPage()
        {
            InitializeComponent();
            try
            {
                BindingContext = new ShopViewModel();
            }
            catch(Exception ex)
            {

            }
        }

        private void CollectionView_Focused(object sender, FocusEventArgs e)
        {

        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CollectionView_ScrollToRequested(object sender, ScrollToRequestEventArgs e)
        {

        }

        private void Frame_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}