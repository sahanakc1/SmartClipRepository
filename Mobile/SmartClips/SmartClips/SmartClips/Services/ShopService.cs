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

        public static ShopService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShopService();

                return _instance;
            }
        }
        public IEnumerable<SaloonUserModel>  getAllSaloons()
        {
            List<SaloonUserModel> saloonUserModels = new List<SaloonUserModel>();
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
                        saloonUserModels.Add((SaloonUserModel)d);
                    }
                }
            }
            return saloonUserModels;
        }
    }
}
