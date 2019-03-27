using System;
using CsvHelper.Configuration.Attributes;

namespace BimKon.Core.Models
{
    public class SekolahDetailCsv
    {
        [Name("nama")]
        public string Nama { get; set; }
        [Name("npsn")]
        public string NPSN { get; set; }
        [Name("jenjangpendidikan")]
        public string JenjangPendidikan { get; set; }
        [Name("statussekolah")]
        public string StatusSekolah { get; set; }
        [Name("waktupenyelenggaraan")]
        public string WaktuPenyelenggaraan { get; set; }
        [Name("alamat")]
        public string Alamat { get; set; }
        [Name("kodepos")]
        public string KodePos { get; set; }
        [Name("kelurahan")]
        public string Kelurahan { get; set; }
        [Name("kecamatan")]
        public string Kecamatan { get; set; }
        [Name("kabupaten")]
        public string Kabupaten { get; set; }


    }
}
