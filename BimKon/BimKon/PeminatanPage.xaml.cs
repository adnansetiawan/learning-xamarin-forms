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
