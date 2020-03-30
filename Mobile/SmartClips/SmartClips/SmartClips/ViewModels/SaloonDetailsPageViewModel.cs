using System.Collections.ObjectModel;
using SmartClips.Models;
using SmartClips.Services;
using Xamarin.Forms;
using BusinessLayer.Models;
using System.Windows.Input;
using Plugin.Messaging;
using System.Net.Http;
using System;

namespace SmartClips.ViewModels
{
    public class SaloonDetailsPageViewModel : BindableObject
    {
        SaloonUserModel _saloons;
        private PageService page;
        public ICommand NumberDialCommad { get; }
        public ICommand LoadMapsCommad { get; }
        public ICommand CheckinCommad { get; }
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
            CheckinCommad = new Command(CheckinMethod);
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
        private void CheckinMethod()
        {
            var user = new SaloonUserModel();
            user = Saloons;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44393/api/CheckinMethod/");
                var postTask = client.PostAsJsonAsync<SaloonUserModel>("PostNewUser", user);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<SaloonUserModel>();
                    readTask.Wait();

                    var insertedStudent = readTask.Result;
                }
            }
        }
    }
}
