using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PeminatanDetailPage : MasterPage
    {
        private readonly KeahlianViewModel _keahlian;

        public PeminatanDetailPage(KeahlianViewModel keahlian)
        {
            InitializeComponent();
            _keahlian = keahlian;
            Title = keahlian?.Nama;
        }
        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(_keahlian);
            ContentLayout.Children.Clear();

            foreach (var program in _viewModel.ProgramKeahlian)
            {
                var stackContentDetail = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };
                /*var stackHeader = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.FromHex("#33c5ed"),
                    HeightRequest = 30,
                    
                };*/
                stackContentDetail.Children.Add(new Label()
                {
                    Text = program.Nama,
                    TextColor = Color.White,
                    BackgroundColor = Color.FromHex("#33c5ed"),
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
                // stackContentDetail.Children.Add(stackContentDetail);
                var stackContentDetailItem = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Margin = new Thickness(10, 0, 0, 0)
                };

                foreach (var paket in program.PaketKeahlians)
                {
                    var stackContentDetailItemChild = new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        HorizontalOptions = LayoutOptions.FillAndExpand,

                    };

                    stackContentDetailItemChild.Children.Add(new Label()
                    {
                        Text = paket.Nama,
                        TextColor = Color.FromHex("#f35e20"),
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    });
                    if (!string.IsNullOrEmpty(paket.Sekolah))
                    {
                        stackContentDetailItemChild.Children.Add(new Label()
                        {
                            Text = "Sekolah Penyelenggara",
                            FontSize = 11,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.FromHex("#503026"),
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Margin = new Thickness(10, 0, 0, 0)
                        });
                        stackContentDetailItemChild.Children.Add(new Label()
                        {
                            Text = paket.Sekolah,
                            FontSize = 11,
                            TextColor = Color.FromHex("#503026"),
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Margin = new Thickness(10, 0, 0, 0)
                        });
                    }
                    stackContentDetailItem.Children.Add(stackContentDetailItemChild);
                    stackContentDetailItem.Children.Add(new BoxView
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Color = Color.Gray,
                        HeightRequest = 1,
                        Opacity = 0.2
                    });
                }
                stackContentDetail.Children.Add(stackContentDetailItem);
                ContentLayout.Children.Add(stackContentDetail);
            }


        }
        private PeminatanDetailPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is PeminatanDetailPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
