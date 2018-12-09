using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Patungan.Models;
using Xamarin.Forms;

namespace Patungan
{
    public partial class PaymentOverviewPage : MasterPage
    {
        private PaymentOverviewPageViewModel _viewModel;

        public PaymentOverviewPage()
        {
            InitializeComponent();
        }
        private async void GoToCreatePaymentPage(object sender, EventArgs e)
        {
            await _viewModel.PushAsync(new CreatePaymentPage());
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is PaymentOverviewPageViewModel vm))
            {
                return;
            }

            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
        protected override void OnAppearing()
        {

            _viewModel.RefreshPaymentItems?.Execute(null);

        }
    }
}
