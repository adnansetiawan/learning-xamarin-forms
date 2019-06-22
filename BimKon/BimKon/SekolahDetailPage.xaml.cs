using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class SekolahDetailPage : MasterPage
    {
        private readonly SekolahDetailViewModel _sekolahInfo;
        public SekolahDetailPage(SekolahDetailViewModel sekolahInfo)
        {
            InitializeComponent();
            _sekolahInfo = sekolahInfo;
            Title = _sekolahInfo.Nama;

        }

        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(null);
            Telp.Text = _sekolahInfo.Telpon;
            Fax.Text = _sekolahInfo.Fax;
            Email.Text = _sekolahInfo.Email;
            Alamat.Text = _sekolahInfo.Address?.DisplayedAddress;
            ContentLayout.Children.Clear();
            var stackHeaderSyaratMasuk = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            stackHeaderSyaratMasuk.Children.Add(new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, Text = $"Persyaratan Masuk" });
            var stackContentSyaratMasuk = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            int number = 1;
            foreach (var sy in _viewModel.SyaratsMasuk)
            {
                var stackContentDetail = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                stackContentDetail.Children.Add(new Label()
                {
                    Text = number.ToString(),
                    TextColor = Color.FromHex("#f35e20"),
                    VerticalOptions = LayoutOptions.StartAndExpand

                });
                stackContentDetail.Children.Add(new Label()
                {
                    Text = sy.Description,
                    TextColor = Color.FromHex("#503026"),
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.StartAndExpand
                });
                stackContentSyaratMasuk.Children.Add(stackContentDetail);
                number++;
            }
            number = 1;
            var stackHeaderSyaratJurusan = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            stackHeaderSyaratJurusan.Children.Add(new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, Text = $"Persyaratan Memilih Jurusan" });

            var stackContentSyaratJurusan = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            foreach (var sy in _viewModel.SyaratsJurusan)
            {
                var stackContentDetail = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                stackContentDetail.Children.Add(new Label()
                {
                    Text = number.ToString(),
                    TextColor = Color.FromHex("#f35e20"),
                    VerticalOptions = LayoutOptions.StartAndExpand

                });
                stackContentDetail.Children.Add(new Label()
                {
                    Text = sy.Description,
                    TextColor = Color.FromHex("#503026"),
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    HorizontalOptions = LayoutOptions.StartAndExpand
                });
                stackContentSyaratJurusan.Children.Add(stackContentDetail);
                number++;
            }

            ContentLayout.Children.Add(stackHeaderSyaratMasuk);
            ContentLayout.Children.Add(stackContentSyaratMasuk);
            ContentLayout.Children.Add(stackHeaderSyaratJurusan);
            ContentLayout.Children.Add(stackContentSyaratJurusan);

        }
        private SekolahDetailPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is SekolahDetailPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
