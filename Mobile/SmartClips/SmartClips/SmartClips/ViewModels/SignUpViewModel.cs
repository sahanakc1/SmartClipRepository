using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms;
using SmartClips.Services;

namespace SmartClips.ViewModels
{
    public class SignUpViewModel
    {
        private string email;

        private bool isInvalidEmail;
        private PageService page;

        public SignUpViewModel()
        {
            page = new PageService();
            SignUpCommand = new Command(LoadLoginPage);
        }


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
                //this.NotifyPropertyChanged();
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
              //  this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region commands
        public ICommand SignUpCommand { get; }

        private async void LoadLoginPage()
        {

           await page.PushAsync(new SmartClips.Views.LoginPage());
        }
        #endregion
    }
}
