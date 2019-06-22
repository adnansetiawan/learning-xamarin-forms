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

        public List<SyaratJurusanCsv> ReadSyaratJurusan()
        {
            var result = new List<SyaratJurusanCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.SyaratJurusan.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SyaratJurusanCsv>();
                result = records.ToList();
            }
            return result;
        }

        public List<SyaratMasukCsv> ReadSyaratMasuk()
        {
            var result = new List<SyaratMasukCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.SyaratMasuk.csv");
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
