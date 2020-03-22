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

namespace SmartClips.ViewModels
{
    [Preserve(AllMembers = true)]
    public class LoginViewModel : BaseViewModel
    {
        #region Fields

        private string email;

        private bool isInvalidEmail;
        private PageService page;

        public LoginViewModel()
        {
            page = new PageService();
            LoginCommand = new Command(LoadMaps);
            SignUpCommand = new Command(LoadSignUp);
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the email ID from user in the login page.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (this.email == value)
                {
                    return;
                }

                this.email = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the entered email is valid or invalid.
        /// </summary>
        public bool IsInvalidEmail
        {
            get
            {
                return this.isInvalidEmail;
            }

            set
            {
                if (this.isInvalidEmail == value)
                {
                    return;
                }

                this.isInvalidEmail = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region commands
        public ICommand LoginCommand { get;}
        public ICommand SignUpCommand { get; }

        private async void LoadMaps()
        {
            try
            {
                await page.PushAsync(new SmartClips.Views.DashBoard());
            }
            catch(Exception ex)
            {

            }
          //  await page.PushAsync(new SmartClips.Views.Maps());
          //    await page.PushAsync(new SmartClips.Views.MapPage());
        }

        private async void LoadSignUp()
        {

            await page.PushAsync(new SmartClips.Views.SignUpPage());
        }

       
        private void getUserNameAndPassword()
        {
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
                        Console.WriteLine("{0}", d.saloon_name);
                    }
                }
            }
        }

        private void postUserDetails()
        {
            //var user = new UserModel() { name = "sahana" };
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44393/api/login/");
            //    var postTask = client.PostAsJsonAsync<UserModel>("PostNewUser", user);
            //    postTask.Wait();

            //    var result = postTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<UserModel>();
            //        readTask.Wait();

            //        var insertedStudent = readTask.Result;
            //    }
            //}
        }
        #endregion
    }
}
