using System;
using BimKon.Core.PageExtensions;
using Xamarin.Forms;

namespace BimKon.Core
{
    public class PMainPage : BottomBarPage
    {
        private PNavigationPage _mainPage;
        private PNavigationPage _sekolahPage;
        private PNavigationPage _pekerjaanPage;
        public PMainPage()
        {

            _mainPage = new PNavigationPage(new MainPage());
            _mainPage.Title = "Informasi";
            Children.Add(_mainPage);
            _sekolahPage = new PNavigationPage(new SekolahOverviewPage());
            _sekolahPage.Title = "Sekolah";
            Children.Add(_sekolahPage);
            _sekolahPage = new PNavigationPage(new SekolahOverviewPage());
            _sekolahPage.Title = "Sekolah";
            Children.Add(_sekolahPage);

            /*_navSMKOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.SMK));
            _navSMKOverviewPage.Title = "SMK";

            Children.Add(_navSMKOverviewPage);

            _navSMAOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.SMA));
            _navSMAOverviewPage.Title = "SMA";
            Children.Add(_navSMAOverviewPage);

            _navMANOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.MAN));
            _navMANOverviewPage.Title = "MAN";
            Children.Add(_navMANOverviewPage);*/
        }

    }
}

