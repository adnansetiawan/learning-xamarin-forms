using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class PeminatanPage : MasterPage
    {
        public PeminatanPage()
        {
            InitializeComponent();
            Title = "Peminatan";




        }
        protected override void OnAppearing()
        {
            _viewModel.Init?.Execute(null);

        }
        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filterBy = SearchText.Text;
            _viewModel.Search?.Execute(filterBy);


        }
        async void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as KeahlianViewModel;
            if (item == null)
                return;
            await Navigation.PushAsync(new PeminatanDetailPage(item), true);
        }
        private KeahlianPageViewModel _viewModel;

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (!(BindingContext is KeahlianPageViewModel vm))
            {
                return;
            }
            _viewModel = vm;
            _viewModel.Navigation = Navigation;
        }


    }
}
