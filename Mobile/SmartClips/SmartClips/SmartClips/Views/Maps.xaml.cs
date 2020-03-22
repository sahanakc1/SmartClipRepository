using SmartClips.Maps;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maps : ContentPage
    {
        public Maps()
        {
            InitializeComponent();
            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(37.674725, -121.875230),
                Label = "4318 Valley Ave",
                Address = "4318 Valley Ave",
                Name = "Home",
                Url = "http://xamarin.com/about/"
            };


            CustomPin pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(37.696535, -121.933897),
                Label = "Stonebridge Mall",
                Address = "5912 Stoneridge Mall Rd",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };


            customMap.CustomPins = new List<CustomPin> { pin,pin2 };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.674725, -121.875230), Distance.FromMiles(10.0)));

            Content = customMap;

        }
    }
}