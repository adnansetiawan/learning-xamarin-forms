using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Patungan.Models;
using Xamarin.Forms;

namespace Patungan
{
    public partial class CreatePaymentPage : MasterPage
    {
        private ObservableCollection<UserPaymentViewModel> _userPaymentsViewModel;
        public CreatePaymentPage()
        {
            InitializeComponent();
            _userPaymentsViewModel = new ObservableCollection<UserPaymentViewModel>();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _userPaymentsViewModel.Clear();
            _userPaymentsViewModel.Add(new UserPaymentViewModel
            {
                Amount = 12000,
                JoinDate = DateTime.Parse("2018-08-03"),
                UserName = "user 1",
                UserPicture = "Icons/ic_circle_member_default_gray"


            });
            ListUserPayment.ItemsSource = _userPaymentsViewModel;
        }
        private void DeleteUserPayment_Clicked(object sender, EventArgs e)
        {

            var data = (sender as MenuItem).CommandParameter as UserPaymentViewModel;
            if (data != null)
            {
                _userPaymentsViewModel.Remove(data);
            }
        }
    }
}
