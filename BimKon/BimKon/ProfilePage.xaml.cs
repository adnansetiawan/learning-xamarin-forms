﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class ProfilePage : MasterPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            Title = "Tentang Aplikasi";

        }

        async void OnClose_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            VersionLabel.Text = $"Versi : {App.Version}";
            DescriptionLabel.Text = "Aplikasi ini dibuat sebagai informasi untuk memilih Sekolah Lanjutan oleh siswa SMP berdasarkan peminatan mereka, dibuat sebagai alat bantu Tesis Hasni pada program Pasca Sarjana UNM bidang Bimbingan Konseling";
            DescriptionLabel.Text += "\n";
        }
    }
}
