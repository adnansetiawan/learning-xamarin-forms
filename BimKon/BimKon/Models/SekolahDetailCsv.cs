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
    public class PaketKeahlianCsv
    {
        [Name("kodeprogram")]
        public string KodeProgram { get; set; }
        [Name("kode")]
        public string Kode { get; set; }
        [Name("nama")]
        public string Nama { get; set; }
        [Name("sekolah")]
        public string Sekolah { get; set; }

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
        [Name("telpon")]
        public string Telpon { get; set; }
        [Name("fax")]
        public string Fax { get; set; }
        [Name("email")]
        public string Email { get; set; }


    }
    public class SyaratMasukCsv
    {
        [Name("kode")]
        public string Kode { get; set; }
        [Name("description")]
        public string Description { get; set; }

    }
    public class SyaratJurusanCsv
    {
        [Name("ShowTitle")]
        public bool ShowTitle { get; set; }
        [Name("Jurusan")]
        public string Jurusan { get; set; }
        [Name("description")]
        public string Description { get; set; }

    }
    public class JurusanMataPelajaranCsv
    {
        [Name("Kode")]
        public string Kode { get; set; }
        [Name("JenjangPendidikan")]
        public string JenjangPendidikan { get; set; }
        [Name("Jurusan")]
        public string Jurusan { get; set; }
        [Name("MataPelajaran")]
        public string MataPelajaran { get; set; }

    }
    public class JurusanMataPelajaranSMKMappingCsv
    {
        [Name("Kode")]
        public string Kode { get; set; }
        [Name("NamaSekolah")]
        public string NamaSekolah { get; set; }

    }
}
