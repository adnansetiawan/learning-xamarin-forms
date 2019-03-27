using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class MainPage : MasterPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        void OnClickSekolahLanjutan(object sender, EventArgs e)
        {
            //MainPage = new PMainPage();
            //App.Current.MainPage = new PMainPage();
            //Navigation.PushAsync(new PMainPage());
        }
        void OnClickMengenalDiri(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MengenalDiriPage());
        }
    }
}
