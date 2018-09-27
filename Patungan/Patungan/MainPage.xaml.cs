using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Patungan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {

            var m = new NavigationPage(new CreatePaymentPage());
        }
    }
}
