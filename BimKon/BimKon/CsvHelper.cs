using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using BimKon.Core.Models;
using CsvHelper;

namespace BimKon.Core
{
    public class CsvHelper : ICsvHelper
    {
        public List<BidangKeahlianCsv> ReadBidangKeahlian()
        {
            var result = new List<BidangKeahlianCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.BidangKeahlian.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<BidangKeahlianCsv>();
                result = records.ToList();
            }
            return result;
        }

        public List<JurusanMataPelajaranCsv> ReadJurusanMataPelajaran(string jenjangPendidikan)
        {
            var result = new List<JurusanMataPelajaranCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.PeminatanPelajaran.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<JurusanMataPelajaranCsv>();
                records = records.Where(x => x.JenjangPendidikan.Contains(jenjangPendidikan));
                result = records.ToList();
            }


            return result;
        }

        public List<BidangDanProgramKeahlianCsv> ReadKeahliandDanProgram()
        {
            var result = new List<BidangDanProgramKeahlianCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.BidangDanProgramKeahlian.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<BidangDanProgramKeahlianCsv>();
                result = records.ToList();
            }
            return result;
        }

        public List<ProgramKeahlianCsv> ReadProgramKeahlian()
        {
            var result = new List<ProgramKeahlianCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.ProgramKeahlian.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<ProgramKeahlianCsv>();
                result = records.ToList();
            }
            return result;
        }

        public List<SekolahDetailCsv> ReadSekolahDetail()
        {
            var result = new List<SekolahDetailCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.SekolahLanjutanOverview.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SekolahDetailCsv>();
                result = records.ToList();
            }
            return result;
        }

        public List<SyaratJurusanCsv> ReadSyaratJurusan(string jenjangPendidikan)
        {
            var result = new List<SyaratJurusanCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            var stream = assembly.GetManifestResourceStream("BimKon.Core.SyaratJurusan.csv");

            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SyaratJurusanCsv>();
                if (jenjangPendidikan == "SMK")
                {
                    records = records.Where(x => x.Jurusan == "KEJURUAN").ToList();
                }
                else if (jenjangPendidikan == "SMA")
                {
                    records = records.Where(x => x.Jurusan != "AGAMA" && x.Jurusan != "KEJURUAN").ToList();

                }
                else
                {
                    records = records.Where(x => x.Jurusan != "KEJURUAN").ToList();

                }
                result = records.ToList();
            }
            return result;
        }

        public List<SyaratMasukCsv> ReadSyaratMasuk(string jenjangPendidikan)
        {
            var result = new List<SyaratMasukCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = null;
            if (jenjangPendidikan == "SMK")
            {
                stream = assembly.GetManifestResourceStream("BimKon.Core.SyaratMasukSMK.csv");
            }
            else
            {
                stream = assembly.GetManifestResourceStream("BimKon.Core.SyaratMasuk.csv");

            }
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SyaratMasukCsv>();
                result = records.ToList();
            }

            return result;
        }
    }
}
