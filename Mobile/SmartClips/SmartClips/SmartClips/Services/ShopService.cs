using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms;
using SmartClips.Services;
using System.Net.Http;
using System.Net.Http.Headers;
using SmartClips.Models;
using BusinessLayer.Models;

namespace SmartClips.Services
{
    public class ShopService
    {
        static ShopService _instance;
        List<SaloonUserModel> saloonUserModels = new List<SaloonUserModel>();
        public static ShopService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShopService();

                return _instance;
            }
        }
        private void Setup()
        {
            
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                foreach (var evt in saloonUserModels)
                {
                    var timespan = evt.Date - DateTime.Now;
                    evt.Timespan = timespan;
                }
                return true;
            });
        }
        public IEnumerable<SaloonUserModel>  getAllSaloons()
        {
           // List<SaloonUserModel> saloonUserModels = new List<SaloonUserModel>();
            using (var client = new HttpClient())
            { 
                client.BaseAddress = new Uri("http://10.0.0.86:92/api/login/");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                //HTTP GET
                HttpResponseMessage response = client.GetAsync("GetSaloonDetails").Result;

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<IEnumerable<SaloonUserModel>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                    foreach (var d in dataObjects)
                    {
                        d.Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(00, 00, 59).Ticks);
                        saloonUserModels.Add((SaloonUserModel)d);
                    }
                }
            }
          saloonUserModels[3].Date= new DateTime(DateTime.Now.Ticks + new TimeSpan(00, 05, 59).Ticks);
           Setup();
            return saloonUserModels;
        }
    }
}
