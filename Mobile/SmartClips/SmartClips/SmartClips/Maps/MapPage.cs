using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SmartClips.Maps
{
    public class MapPageCS : ContentPage
    {
        public MapPageCS()
        {
            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
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

           
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(10.0)));

            Content = customMap;
        }
    }
}
