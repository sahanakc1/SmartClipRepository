using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoard : TabbedPage
    {
        public DashBoard()
        {
            InitializeComponent();
        }
    }
}