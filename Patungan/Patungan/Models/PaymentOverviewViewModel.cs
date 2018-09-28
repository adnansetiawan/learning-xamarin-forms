using System;
using System.Globalization;

namespace Patungan.Models
{

    public class PaymentOverviewViewModel
    {
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDateDisplay
        {
            get { return TransactionDate.ToLocalTime().ToString("dd-MM-yyyy"); }
        }
        public decimal TotalAmount { get; set; }
        public string TotalAmountDisplay
        {
            get { return TotalAmount.ToString("C", new CultureInfo("id-ID")); }
        }
        public string ImagePath { get; set; } = "Icons/ic_circle_group_default_gray.png";
        public bool IsComplete { get; set; }
        public string Status
        {
            get
            {
                if (IsComplete)
                {
                    return "Complete";
                }
                return "Outstanding";
            }
        }
    }
}
