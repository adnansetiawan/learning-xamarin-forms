using System;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class SekolahDetailViewModel
    {
        public string Id { get; set; }
        public string Nama { get; set; }
        public string NPSN { get; set; }
        public string JenjangPendidikan { get; set; }
        public string StatusSekolah { get; set; }
        public string WaktuPenyelenggaraan { get; set; }
        public AddressViewModel Address { get; set; }
        public Color CategoryColor
        {
            get
            {
                if (JenjangPendidikan == "SMA")
                    return Color.FromHex("#07b4ff");
                if (JenjangPendidikan == "SMK")
                    return Color.FromHex("#50adcc");
                if (JenjangPendidikan == "MA")
                    return Color.FromHex("#2d8f7b");
                return Color.FromHex("#07b4ff");
            }
        }


    }
    public class AddressViewModel
    {
        public string Alamat { get; set; }
        public string KodePos { get; set; }
        public string Kelurahan { get; set; }
        public string Kota { get; set; }
        public string Kecamatan { get; set; }

        public string DisplayedAddress
        {
            get
            {
                return $"{Alamat} {Kelurahan} {Kecamatan}";
            }
        }

    }
}
