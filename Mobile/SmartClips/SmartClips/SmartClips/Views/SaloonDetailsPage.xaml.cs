using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartClips.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaloonDetailsPage : ContentPage
    {
        public SaloonDetailsPage(object SaloonDetails,bool isfromMaps=false)
        {
            InitializeComponent();
            BindingContext = new SaloonDetailsPageViewModel(SaloonDetails, isfromMaps);
        }
    }
}