using System;
using Xamarin.Forms.Maps;

namespace SmartClips.Maps
{
    public class CustomPin : Pin
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public int SaloonId { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string zipcode { get; set; }
        public int role_id { get; set; }
        public Nullable<System.TimeSpan> businesshrs_from { get; set; }
        public Nullable<System.TimeSpan> businesshrs_to { get; set; }
    }
}
