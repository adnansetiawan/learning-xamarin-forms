using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class MengenalDiriDetailPage : MasterPage
    {
        public MengenalDiriDetailPage()
        {
            InitializeComponent();
            Title = "6 Tipe Kepribadian";



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
