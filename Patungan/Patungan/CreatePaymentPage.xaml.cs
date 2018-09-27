using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Patungan.Models;
using Xamarin.Forms;

namespace Patungan
{
    public partial class CreatePaymentPage : MasterPage
    {
        public ObservableCollection<PaymentOverviewViewModel> PaymentOverviewViewModel;
        public CreatePaymentPage()
        {
            InitializeComponent();
            PaymentOverviewViewModel = new ObservableCollection<PaymentOverviewViewModel>();
        }
        protected override void OnAppearing()
        {
            var paymetOverviewList = new List<PaymentOverviewViewModel>();
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 10000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "Payment 001",
                IsComplete = true
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 200000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "XSdasm asdasdasdad"
            });
            paymetOverviewList.Add(new Models.PaymentOverviewViewModel
            {
                TotalAmount = 5000000,
                TransactionDate = DateTime.Parse("2018-09-10"),
                ImagePath = "Icons/ic_circle_group_default_gray",
                Description = "isds dajsdasd"
            });

            PaymentOverviewViewModel = new ObservableCollection<PaymentOverviewViewModel>(paymetOverviewList);
            PaymentUserListView.ItemsSource = PaymentOverviewViewModel;
        }
    }
}
