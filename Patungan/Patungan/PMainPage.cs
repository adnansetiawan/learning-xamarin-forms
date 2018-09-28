using System;
using Patungan.PageExtensions;
using Xamarin.Forms;

namespace Patungan
{
    public class PMainPage : BottomBarPage
    {
        private PNavigationPage _navPaymentOverviewPage;
        private PNavigationPage _navBalancePage;
        private PNavigationPage _navPaymentRequestPage;

        public PMainPage()
        {
            _navPaymentOverviewPage = new PNavigationPage(new PaymentOverviewPage());
            _navPaymentOverviewPage.Title = "Overview";
            Children.Add(_navPaymentOverviewPage);

            _navBalancePage = new PNavigationPage(new BalancePage());
            _navBalancePage.Title = "Saldo";
            Children.Add(_navBalancePage);

            _navPaymentRequestPage = new PNavigationPage(new PaymentRequestPage());
            _navPaymentRequestPage.Title = "Tagihan";
            Children.Add(_navPaymentRequestPage);
        }
    }
}

