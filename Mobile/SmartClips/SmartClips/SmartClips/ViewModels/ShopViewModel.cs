using System.Collections.ObjectModel;
using SmartClips.Models;
using SmartClips.Services;
using Xamarin.Forms;
using BusinessLayer.Models;
using System.Windows.Input;

namespace SmartClips.ViewModels
{
    public class ShopViewModel:BindableObject
    {
         ObservableCollection<SaloonUserModel> _saloons;
        private PageService page;
        public ICommand LoadSaloonDetailCommad { get; }
        public ShopViewModel()
        {
            LoadSaloons();
            page = new PageService();
            LoadSaloonDetailCommad = new Command(LoadSaloonDetailsPage);
        }

        public ObservableCollection<SaloonUserModel> Saloons
        {
            get { return _saloons; }
            set
            {
                _saloons = value;
                OnPropertyChanged();
            }
        }

        private async void LoadSaloonDetailsPage()
        {
           // await page.PushAsync(new SmartClips.Views.SaloonDetailsPage());
        }
        void LoadSaloons()
        {
            var saloons = ShopService.Instance.getAllSaloons();
            Saloons = new ObservableCollection<SaloonUserModel>(saloons);
        }
    }
}
