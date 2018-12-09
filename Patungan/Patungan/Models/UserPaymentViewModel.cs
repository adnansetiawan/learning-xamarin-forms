using System;
using System.Globalization;

namespace Patungan.Models
{
    public class UserPaymentViewModel : BaseViewModel
    {
        public string UserName { get; set; }
        public string UserPicture { get; set; }
        public decimal Amount { get; set; }
        public string AmountDisplay
        {
            get
            {
                return Amount.ToString("C", new CultureInfo("id-ID"));
            }
        }
        public DateTime JoinDate { get; set; }
        public string JoinDateDisplay
        {
            get
            {
                return JoinDate.ToString("dd-MM-yyyy");
            }
        }


    }
}
