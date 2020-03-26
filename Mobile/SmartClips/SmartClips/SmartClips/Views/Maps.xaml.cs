using BusinessLayer.Models;
using SmartClips.Maps;
using SmartClips.Services;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Maps : ContentPage
    {
        IEnumerable<SaloonUserModel> saloons;
        public Maps()
        {
            InitializeComponent();
            saloons=ShopService.Instance.getAllSaloons();
            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

            customMap.CustomPins = new List<CustomPin> ();
          
            foreach (var saloon in saloons)
            {
                CustomPin pin = new CustomPin
                {
                    SaloonId = saloon.id,
                    phone = saloon.phone,
                    businesshrs_from=saloon.businesshrs_from,
                    businesshrs_to=saloon.businesshrs_to,
                    zipcode=saloon.zipcode,
                    email=saloon.email,
                    Type = PinType.Place,
                    Position = new Position(saloon.lattitude,saloon.longitude),
                    Label = saloon.zipcode,
                    Address = saloon.Address,
                    Name = saloon.saloon_name,
                    Url = "http://xamarin.com/about/"
                };

                customMap.Pins.Add(pin);
                customMap.CustomPins.Add(pin);
            }
            
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.674725, -121.875230), Distance.FromMiles(10.0)));

            Content = customMap;

        }
    }
}