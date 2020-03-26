using System.Collections.ObjectModel;
using SmartClips.Models;
using SmartClips.Services;
using Xamarin.Forms;
using BusinessLayer.Models;
using System.Windows.Input;
using Plugin.Messaging;

namespace SmartClips.ViewModels
{
    public class SaloonDetailsPageViewModel : BindableObject
    {
        SaloonUserModel _saloons;
        private PageService page;
        public ICommand NumberDialCommad { get; }
        public ICommand LoadMapsCommad { get; }
        public SaloonDetailsPageViewModel(object SaloonDetails,bool isfromMaps=false)
        {
            if(isfromMaps)
            {
                _saloons = new SaloonUserModel();
                var detail = (SaloonDetails as SmartClips.Maps.CustomPin);
                _saloons.id = detail.SaloonId;
                _saloons.name = detail.Name;
                _saloons.Address = detail.Address;
                _saloons.email = detail.email;
                _saloons.businesshrs_from = detail.businesshrs_from;
                _saloons.businesshrs_to = detail.businesshrs_to;
                _saloons.phone = detail.phone;
            }
            else
            {
                Saloons = (SaloonUserModel)SaloonDetails;
            }
            
            page = new PageService();
            NumberDialCommad = new Command(OnDialing);
            LoadMapsCommad = new Command(LoadMaps);
        }

        public SaloonUserModel Saloons
        {
            get { return _saloons; }
            set
            {
                _saloons = value;
                OnPropertyChanged();
            }
        }

        private void OnDialing()
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(Saloons.phone);
        }
        private async void LoadMaps()
        {
            await page.PushAsync(new SmartClips.Views.Maps());
        }
    }
}
