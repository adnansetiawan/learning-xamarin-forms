using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PekerjaanDetail : MasterPage
    {
        public PekerjaanDetail(string title, string type)
        {
            InitializeComponent();
            Title = title;
            if (type == "rekayasa")
            {
                int i = 1;
                while (i < 7)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {

                        Aspect = Aspect.Fill,
                        Source = $"p_rekayasa_{i}",
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill
                    });
                    i++;
                }

            }
            else if (type == "agrobisnis")
            {

                pekerjaanGrid.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.Fill,
                    Source = $"p_agrobisnis",
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });



            }
            else if (type == "ekonomi")
            {

                pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.Fill,
                    Source = $"p_ekonomi",
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill
                });



            }
            else if (type == "kesehatan")
            {

                pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                {
                    Aspect = Aspect.AspectFill,
                    Source = $"p_kesehatan",
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill
                });

            }
            else if (type == "seni")
            {
                int i = 1;
                while (i < 4)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {
                        Aspect = Aspect.AspectFill,
                        Source = $"p_seni_{i}",
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill

                    });
                    i++;
                }

            }
            else if (type == "it")
            {
                int i = 1;
                while (i < 3)
                {
                    pekerjaanLayout.Children.Add(new FFImageLoading.Forms.CachedImage
                    {
                        Aspect = Aspect.AspectFill,
                        Source = $"p_it_{i}",
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill
                    });
                    i++;
                }

            }

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //pekerjaanImage1.Source = "p_rekayasa_1.png";
            //pekerjaanImage2.Source = "p_rekayasa_2.png";
        }
    }
}
