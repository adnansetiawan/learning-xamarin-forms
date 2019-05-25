using System;
using CsvHelper.Configuration.Attributes;

namespace BimKon.Core.Models
{
    public class BidangDanProgramKeahlianCsv
    {
        [Name("bidang")]
        public string Bidang { get; set; }
        [Name("program")]
        public string Program { get; set; }

    }
    public class BidangKeahlianCsv
    {
        [Name("kode")]
        public string Kode { get; set; }
        [Name("nama")]
        public string Nama { get; set; }

    }
    public class ProgramKeahlianCsv
    {
        [Name("kode")]
        public string Kode { get; set; }
        [Name("nama")]
        public string Nama { get; set; }

    }
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
        [Name("jurusan")]
        public string Jurusan { get; set; }


    }
}
