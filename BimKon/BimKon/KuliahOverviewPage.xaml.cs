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
            Title = "Sekolah";

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

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
    }
}
