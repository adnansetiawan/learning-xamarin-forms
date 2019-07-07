using System;
using System.Collections.Generic;
using System.Linq;
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
            _viewModel.Init?.Execute(_sekolahInfo);
            Telp.Text = _sekolahInfo.Telpon;
            Fax.Text = _sekolahInfo.Fax;
            Email.Text = _sekolahInfo.Email;
            Alamat.Text = _sekolahInfo.Address?.DisplayedAddress;
            ContentLayout.Children.Clear();
            var stackHeaderSyaratMasuk = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#33c5ed"),
                HeightRequest = 30
            };
            stackHeaderSyaratMasuk.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.Center, Text = $"Persyaratan Masuk", TextColor = Color.White });

            var stackContentSyaratMasuk = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            int number = 1;
            var syaratMasukMain = _viewModel.SyaratsMasuk.Where(x => !x.Group.Contains("."));
            var syaratMasukChilds = _viewModel.SyaratsMasuk.Where(x => x.Group.Contains("."));

            foreach (var sy in syaratMasukMain)
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

                if (syaratMasukChilds.Any(x => x.Group.Contains(sy.Group.ToString())))
                {
                    var childs = syaratMasukChilds.Where(x => x.Group.Contains(sy.Group.ToString()));
                    foreach (var child in childs)
                    {
                        var stackContentChildDetail = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                        };
                        stackContentChildDetail.Children.Add(new Label()
                        {
                            Text = child.Group.Split('.')[1].ToString(),
                            TextColor = Color.FromHex("#f35e20"),
                            VerticalOptions = LayoutOptions.StartAndExpand

                        });
                        stackContentChildDetail.Children.Add(new Label()
                        {
                            Text = child.Description,
                            TextColor = Color.FromHex("#503026"),
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        });
                        stackContentSyaratMasuk.Children.Add(stackContentChildDetail);

                    }

                }

                number++;
            }
            var stackHeaderSyaratJurusan = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#33c5ed"),
                HeightRequest = 30
            };
            stackHeaderSyaratJurusan.Children.Add(new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, Text = $"Persyaratan Memilih Jurusan", TextColor = Color.White });

            var stackContentSyaratJurusan = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            var jurusanGroups = _viewModel.SyaratsJurusan.GroupBy(x => x.Group).ToList();
            foreach (var sy in jurusanGroups)
            {
                var stackContentGroup = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                if (sy.Any(x => x.ShowTitle))
                {
                    stackContentGroup.Children.Add(new Label()
                    {
                        Text = sy.Key.ToString(),
                        TextColor = Color.FromHex("#f35e20"),
                        HorizontalOptions = LayoutOptions.Start

                    });
                }
                var stackContentGroupDetail = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                var items = sy.Select(x => x).ToArray();
                number = 1;
                foreach (var item in items)
                {

                    stackContentGroupDetail.Children.Add(new Label()
                    {
                        Text = $"{number}.{item.Description}",
                        TextColor = Color.FromHex("#503026"),
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    });

                    number++;
                }
                stackContentSyaratJurusan.Children.Add(stackContentGroup);
                stackContentSyaratJurusan.Children.Add(stackContentGroupDetail);


            }

            var stackHeaderMataPelajaran = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#33c5ed"),
                HeightRequest = 30
            };
            stackHeaderMataPelajaran.Children.Add(new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, Text = $"Jurusan Tersedia", TextColor = Color.White });

            var stackContentMataPelajaran = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            var mataPelajaranGroups = _viewModel.MataPelajarans.GroupBy(x => x.Jurusan).ToList();
            foreach (var sy in mataPelajaranGroups)
            {
                var stackContentGroup = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                stackContentGroup.Children.Add(new Label()
                {
                    Text = sy.Key.ToString(),
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.Start

                });
                var stackContentGroupDetail = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                };
                var items = sy.Select(x => x).ToArray();
                number = 1;
                foreach (var item in items)
                {

                    stackContentGroupDetail.Children.Add(new Label()
                    {
                        Text = $"{number}.{item.MataPelajaran}",
                        TextColor = Color.FromHex("#503026"),
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    });

                    number++;
                }
                stackContentMataPelajaran.Children.Add(stackContentGroup);
                stackContentMataPelajaran.Children.Add(stackContentGroupDetail);


            }
            ContentLayout.Children.Add(stackHeaderMataPelajaran);
            ContentLayout.Children.Add(stackContentMataPelajaran);
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
