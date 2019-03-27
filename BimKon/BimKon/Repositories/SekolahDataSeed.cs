using System;
using System.Collections.Generic;
using System.Linq;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core.Repositories
{
    public class SekolahDataSeed
    {
        static ICsvHelper helper = DependencyService.Get<ICsvHelper>();

        public static List<SekolahDetailViewModel> GetAll()
        {
            var csvModel = helper.ReadSekolahDetail();
            if (csvModel.Count == 0)
                return new List<SekolahDetailViewModel>();
            var list = csvModel.Select(x => new SekolahDetailViewModel
            {
                Nama = x.Nama,
                NPSN = x.NPSN,
                JenjangPendidikan = x.JenjangPendidikan,
                StatusSekolah = x.StatusSekolah,
                WaktuPenyelenggaraan = x.WaktuPenyelenggaraan,
                Address = new AddressViewModel
                {
                    Alamat = x.Alamat,
                    Kelurahan = x.Kelurahan,
                    Kecamatan = x.Kecamatan,
                    Kota = x.Kabupaten,
                    KodePos = x.KodePos


                }

            }).ToList();
            return list;
        }
    }
}
