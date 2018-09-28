using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Patungan.Models
{
    public class PaymentOverviewPageViewModel : BaseViewModel
    {

        public PaymentOverviewPageViewModel()
        {
            PaymentOverviewViewModels = new ObservableCollection<PaymentOverviewViewModel>();
        }
        private ObservableCollection<PaymentOverviewViewModel> _paymentOverviewViewModels;
        public ObservableCollection<PaymentOverviewViewModel> PaymentOverviewViewModels
        {
            get => _paymentOverviewViewModels;
            set => SetProperty(ref _paymentOverviewViewModels, value, nameof(PaymentOverviewViewModels));
        }
        private ICommand _refreshPaymentItems;
        public ICommand RefreshPaymentItems
        {
            get
            {

                _refreshPaymentItems = new Command(() =>
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
                    PaymentOverviewViewModels = new ObservableCollection<PaymentOverviewViewModel>(paymetOverviewList);
                });

                return _refreshPaymentItems;
            }
        }

    }
}
