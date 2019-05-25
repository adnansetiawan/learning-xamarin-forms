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
            Title = "Menu";

        }
        void OnClickSekolahLanjutan(object sender, EventArgs e)
        {
            //MainPage = new PMainPage();
            //App.Current.MainPage = new PMainPage();
            Navigation.PushAsync(new SekolahOverviewPage(), true);
        }
        void OnClickMengenalDiri(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MengenalDiriPage(), true);
        }
        void OnClickPeminatan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PeminatanPage(), true);
        }
        void OnClickKuliah(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KuliahOverviewPage(), true);
        }
        void OnClickAbout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage(), true);
        }
        void OnClickChat(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("whatsapp://send?phone=+6285255324432"));
        }

    }
}
