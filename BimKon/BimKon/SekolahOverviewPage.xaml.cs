using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BimKon.Core.Models;
using Xamarin.Forms;
using static BimKon.Core.Enums;

namespace BimKon.Core
{
    public partial class SekolahOverviewPage : MasterPage
    {
        private SekolahOverviewPageViewModel _viewModel;
        private readonly SchoolType _schoolType;
        public SekolahOverviewPage()
        {
            InitializeComponent();

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is SekolahOverviewPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as JurusanViewModel;
            if (item == null)
                return;
            await Navigation.PushAsync(new PekerjaanPage(item), true);
        }

        private void RefreshListViewData(string filterBy = null)
        {
            _viewModel.Search?.Execute(filterBy);

        }
        protected override void OnAppearing()
        {
            _viewModel.CallBack = () =>
            {
                RefreshListViewData();
            };
            _viewModel.Init?.Execute(null);
            if (JenjangPendidikanGroups.Children.Count == 0)
            {
                var jenjangPendidikanGroups = new string[] { "Semua", "SMA", "SMK", "MA" };
                var buttonSemua = new Button { TextColor = Color.White, FontSize = 8, Text = $"Semua({App.SekolahItems.Count()})" };
                buttonSemua.BackgroundColor = Color.FromHex("#1a7cc8");
                buttonSemua.CornerRadius = 15;
                buttonSemua.VerticalOptions = LayoutOptions.CenterAndExpand;
                buttonSemua.WidthRequest = 80;
                buttonSemua.HeightRequest = 30;
                buttonSemua.Clicked += (sender, e) =>
                {
                    _viewModel.FilterByJenjangPendidikan?.Execute("semua");
                };
                JenjangPendidikanGroups.Children.Add(buttonSemua);
                var data = App.SekolahItems.GroupBy(x => x.JenjangPendidikan);
                foreach (var jjp in data)
                {
                    var button = new Button { TextColor = Color.White, FontSize = 8, Text = $"{jjp.Key}({jjp.Count()}) " };

                    button.BackgroundColor = jjp.First().CategoryColor;
                    button.CornerRadius = 15;
                    button.VerticalOptions = LayoutOptions.CenterAndExpand;
                    button.WidthRequest = 80;
                    button.HeightRequest = 30;
                    button.Clicked += (sender, e) =>
                    {
                        _viewModel.FilterByJenjangPendidikan?.Execute(jjp.Key);
                    };
                    JenjangPendidikanGroups.Children.Add(button);
                }
            }


        }
        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            RefreshListViewData(SearchText.Text);

        }
    }
}
