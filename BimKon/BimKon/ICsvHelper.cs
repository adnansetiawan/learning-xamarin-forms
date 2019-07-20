using System;
using System.Collections.Generic;
using BimKon.Core.Models;

namespace BimKon.Core
{
    public interface ICsvHelper
    {
        List<SekolahDetailCsv> ReadSekolahDetail();
        List<BidangKeahlianCsv> ReadBidangKeahlian();
        List<ProgramKeahlianCsv> ReadProgramKeahlian();
        List<PaketKeahlianCsv> ReadPaketKeahlian();
        List<BidangDanProgramKeahlianCsv> ReadKeahliandDanProgram();
        List<SyaratMasukCsv> ReadSyaratMasuk(string jenjangPendidikan);
        List<SyaratJurusanCsv> ReadSyaratJurusan(string jenjangPendidikan);
        List<JurusanMataPelajaranCsv> ReadJurusanMataPelajaran(string jenjangPendidikan);
        List<JurusanMataPelajaranSMKMappingCsv> ReadJurusanMataPelajaranMappingSMK();
    }
}
