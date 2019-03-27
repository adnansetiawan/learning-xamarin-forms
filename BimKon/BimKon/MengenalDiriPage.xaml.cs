using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class MengenalDiriPage : MasterPage
    {
        public MengenalDiriPage()
        {
            InitializeComponent();
            var labelTitle = new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, HorizontalTextAlignment = TextAlignment.Center, Text = "MENGENALI DIRI", FontSize = 16, FontAttributes = FontAttributes.Bold, Margin = new Thickness(0, 20, 0, 20) };
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Kamu-kamu yang berstatus siswa SMP, pastilah sering mengalami galau dan bingung,bingung?? Ya… Bingun utamanya bingung dalam menentukan disekolah mana kita akan lanjut setelah tamat SMP??? Kebingungan ini muncul ketika kita tidak mengenal diri kita, mengenal bakat, minat dan kemampuan diri sendiri.\n\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "Nah melalui aplikasi ini akan diuraikan secara singkat enam tipe kepribadian, yang bisa\nsaja adik-adik masuk diantara enam kepribadian tersebut, yuk dibaca agar lebih paham :\n", FontSize = 12 });
            var labelContent = new Label();
            labelContent.FormattedText = fs;
            ContentLayout.Children.Add(labelTitle);
            ContentLayout.Children.Add(labelContent);



        }
        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(null);

        }
        private MinatPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is MinatPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
