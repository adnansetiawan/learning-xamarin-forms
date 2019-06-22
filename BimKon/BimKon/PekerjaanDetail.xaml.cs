using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PekerjaanDetail : MasterPage
    {
        private readonly string _type;
        public PekerjaanDetail(string title, string type)
        {
            InitializeComponent();
            Title = title;
            _type = type;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadData();
        }
        private void LoadData()
        {
            pekerjaanLayout.Children.Clear();
            if (_type == "rekayasa")
            {
                int i = 1;
                while (i < 7)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {

                        Aspect = Aspect.Fill,
                        Source = $"p_rekayasa_{i}",
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    });
                    i++;
                }

            }
            else if (_type == "agrobisnis")
            {

                pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.Fill,
                    Source = $"p_agrobisnis",
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });



            }
            else if (_type == "ekonomi")
            {

                pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.Fill,
                    Source = $"p_ekonomi",
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill
                });



            }
            else if (_type == "kesehatan")
            {

                pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.Fill,
                    Source = $"p_kesehatan",
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill
                });

            }
            else if (_type == "seni")
            {
                int i = 1;
                while (i < 4)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {
                        Aspect = Aspect.Fill,
                        Source = $"p_seni_{i}",
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill

                    });
                    i++;
                }

            }
            else if (_type == "it")
            {
                int i = 1;
                while (i < 3)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {
                        Aspect = Aspect.Fill,
                        Source = $"p_it_{i}",
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill
                    });
                    i++;
                }

            }

        }
    }
}
