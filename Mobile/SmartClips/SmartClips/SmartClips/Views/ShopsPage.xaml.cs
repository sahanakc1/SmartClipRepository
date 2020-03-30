using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartClips.Services;
using SmartClips.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
  
    public partial class ShopsPage : ContentPage
    {
        private PageService page;
        public ShopsPage()
        {
            try
            {
                InitializeComponent();
                page = new PageService();
                BindingContext = new ShopViewModel();
            }
            catch(Exception ex)
            {

            }
        }
        private async void LoadSaloonDetailPage(object SaloonDetails)
        {
            await page.PushAsync(new SmartClips.Views.SaloonDetailsPage(SaloonDetails));
        }
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            MyCollectionView.SelectedItem = (sender as Frame).BindingContext;
            LoadSaloonDetailPage(MyCollectionView.SelectedItem);
        }
    }
}