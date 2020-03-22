using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartClips.Services
{
    public class PageService : IPageService
    {
        public void InsertPageBefore(Page page, Page before)
        {
            MainPage.Navigation.InsertPageBefore(page,before);
        }

        public async Task<Page> PopAsync()
        {
            return await MainPage.Navigation.PopAsync();
        }

        public async Task<Page> PopAsync(bool animated)
        {
            return await MainPage.Navigation.PopAsync(animated);
        }

        public async Task<Page> PopModalAsync()
        {
            return await MainPage.Navigation.PopModalAsync();
        }

        public async Task<Page> PopModalAsync(bool animated)
        {
            return await MainPage.Navigation.PopModalAsync(animated);
        }

        public async Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public async Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public async Task PushAsync(Page page)
        {
             await MainPage.Navigation.PushAsync(page);
        }

        public async Task PushAsync(Page page, bool animated)
        {
            await MainPage.Navigation.PushAsync(page,animated);
        }

        public async Task PushModalAsync(Page page)
        {
            await MainPage.Navigation.PushAsync(page);
        }

        public async Task PushModalAsync(Page page, bool animated)
        {
            await MainPage.Navigation.PushAsync(page, animated);
        }

        public void RemovePage(Page page)
        {
             MainPage.Navigation.RemovePage(page);
        }

        private Page MainPage
        {
            get {return Application.Current.MainPage; }
        }
    }
}
