﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BimKon.Core.Models;
using BimKon.Core.PageExtensions;
using Version.Plugin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace BimKon.Core
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //MainPage = new PMainPage();
            MainPage = new PNavigationPage(new Core.MainPage());
        }

        protected override void OnStart()
        {
            DependencyService.Register<CsvHelper>();
            _sekolahItems = new ObservableCollection<SekolahDetailViewModel>(Repositories.SekolahDataSeed.GetAll());
            _minatItems = new ObservableCollection<MinatViewModel>(Repositories.MinatDataSeed.GetAll());
            _keahlians = new ObservableCollection<KeahlianViewModel>(Repositories.KeahlianDataSeed.GetAll());


            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        public static string Version
        {
            get
            {
                return CrossVersion.Current.Version;
            }
        }
        static ObservableCollection<SekolahDetailViewModel> _sekolahItems;
        public static ObservableCollection<SekolahDetailViewModel> SekolahItems
        {
            get
            {
                if (_sekolahItems == null)
                {
                    _sekolahItems = new ObservableCollection<SekolahDetailViewModel>(Repositories.SekolahDataSeed.GetAll());
                }
                return _sekolahItems;
            }
        }
        static ObservableCollection<MinatViewModel> _minatItems;
        public static ObservableCollection<MinatViewModel> MinatItems
        {
            get
            {
                if (_minatItems == null)
                {
                    _minatItems = new ObservableCollection<MinatViewModel>(Repositories.MinatDataSeed.GetAll());
                }
                return _minatItems;
            }
        }
        static ObservableCollection<KeahlianViewModel> _keahlians;
        public static ObservableCollection<KeahlianViewModel> Keahlians
        {
            get
            {
                if (_keahlians == null)
                {
                    _keahlians = new ObservableCollection<KeahlianViewModel>(Repositories.KeahlianDataSeed.GetAll());
                }
                return _keahlians;
            }
        }
        static List<ProgramKeahlianCsv> _programs;
        public static List<ProgramKeahlianCsv> Programs
        {
            get
            {
                if (_programs == null)
                {
                    _programs = Repositories.ProgramDataSeed.GetAll();
                }
                return _programs;
            }
        }
        static List<PaketKeahlianCsv> _paketKeahlian;
        public static List<PaketKeahlianCsv> PaketKeahlian
        {
            get
            {
                if (_paketKeahlian == null)
                {
                    _paketKeahlian = Repositories.PaketKeahlianDataSeed.GetAll();
                }
                return _paketKeahlian;
            }
        }
        static List<BidangDanProgramKeahlianCsv> _bidangDanProgramKeahlianCsv;
        public static List<BidangDanProgramKeahlianCsv> BidangDanProgramKeahlianCsv
        {
            get
            {
                if (_bidangDanProgramKeahlianCsv == null)
                {
                    _bidangDanProgramKeahlianCsv = Repositories.KeahlianDanProgramDataSeed.GetAll();
                }
                return _bidangDanProgramKeahlianCsv;
            }
        }
    }
}
