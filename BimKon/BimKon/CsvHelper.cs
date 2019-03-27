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
        public List<SekolahDetailCsv> ReadSekolahDetail()
        {
            var result = new List<SekolahDetailCsv>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CsvHelper)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BimKon.Core.SekolahLanjutanOverview.csv");
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = "|";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SekolahDetailCsv>();
                result = records.ToList();
            }
            return result;
        }
    }
}
