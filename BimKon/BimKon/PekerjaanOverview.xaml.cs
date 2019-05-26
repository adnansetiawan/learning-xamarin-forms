using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PekerjaanOverview : MasterPage
    {
        public PekerjaanOverview()
        {
            InitializeComponent();
            Title = "Lingkup Pekerjaan";

        }
        void OnRekayasaClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Teknologi dan Rekayasa", "rekayasa"), true);
        }
        void OnAgrobisnisClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Agrobisnis dan Agroteknologi", "agrobisnis"), true);

        }
        void OnEkonomiClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Bisnis dan Ekonomi", "ekonomi"), true);

        }
        void OnITClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Teknologi Informasi", "it"), true);

        }
        void OnKesehatanClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Kesehatan", "kesehatan"), true);

        }
        void OnSeniClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PekerjaanDetail("Seni dan Pariwisata", "seni"), true);

        }


    }
}
