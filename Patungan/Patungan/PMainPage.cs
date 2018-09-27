using System;
using Patungan.PageExtensions;
using Xamarin.Forms;

namespace Patungan
{
    public class PMainPage : BottomBarPage
    {
        private PNavigationPage _navCreatePaymentPage;

        public PMainPage()
        {
            _navCreatePaymentPage = new PNavigationPage(new CreatePaymentPage());
            Children.Add(_navCreatePaymentPage);
        }
    }
}

