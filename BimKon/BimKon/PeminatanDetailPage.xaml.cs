using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PeminatanDetailPage : MasterPage
    {
        private readonly KeahlianViewModel _keahlian;

        public PeminatanDetailPage(KeahlianViewModel keahlian)
        {
            InitializeComponent();
            _keahlian = keahlian;
        }
        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(_keahlian);

        }
        private PeminatanDetailPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is PeminatanDetailPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
