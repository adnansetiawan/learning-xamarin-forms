using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class KuliahOverviewPage : MasterPage
    {
        public KuliahOverviewPage()
        {
            InitializeComponent();
            Title = "Peminatan";

        }
        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(null);
            SekolahListView.ItemsSource = _viewModel.GroupItems;

        }
        void OnClickSekolah(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SekolahOverviewPage(), true);
        }

        private KuliahOverviewPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is KuliahOverviewPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            _viewModel?.Search?.Execute(e.NewTextValue);
            SekolahListView.ItemsSource = _viewModel.GroupItems;

        }
    }
}
