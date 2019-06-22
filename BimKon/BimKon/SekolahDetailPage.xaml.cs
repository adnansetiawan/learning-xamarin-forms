using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class SekolahDetailPage : MasterPage
    {

        public SekolahDetailPage(SekolahDetailViewModel sekolahDetailViewModel)
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(null);

        }
        private SekolahDetailPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is SekolahDetailPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
