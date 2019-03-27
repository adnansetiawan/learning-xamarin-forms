using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;
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

            MainPage = new PMainPage();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            DependencyService.Register<CsvHelper>();
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
    }
}
