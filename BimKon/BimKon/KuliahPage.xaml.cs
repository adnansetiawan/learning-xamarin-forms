using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class KuliahPage : MasterPage
    {
        private KuliahPageViewModel _viewModel;
        private readonly Enums.SchoolType _tipeSekolah;
        public KuliahPage(Enums.SchoolType tipeSekolah)
        {

            InitializeComponent();
            KuliahListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem == null) return;



                ((ListView)sender).SelectedItem = null;
            };

        }
        protected override void OnAppearing()
        {
            Title = $"{_tipeSekolah}";
            _viewModel.Init?.Execute(null);
            KuliahListView.ItemsSource = _viewModel.KuliahItems;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is KuliahPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }
    }
}
