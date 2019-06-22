using System;
using System.Collections.Generic;
using System.Linq;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core.Repositories
{
    public class KeahlianDataSeed
    {
        static ICsvHelper helper = DependencyService.Get<ICsvHelper>();
        public static List<KeahlianViewModel> GetAll()
        {
            var csvKeahlian = helper.ReadBidangKeahlian();
            if (csvKeahlian.Count == 0)
                return new List<KeahlianViewModel>();
            var csvProgram = helper.ReadProgramKeahlian();
            var csvKeahlianDanProgram = helper.ReadKeahliandDanProgram();
            var result = new List<KeahlianViewModel>();
            foreach (var keahlian in csvKeahlian)
            {
                var keahlianViewModel = new KeahlianViewModel();
                keahlianViewModel.Nama = keahlian.Nama;
                var programs = csvKeahlianDanProgram.Where(x => x.Bidang == keahlian.Kode).ToList();
                var programKodes = programs.SelectMany(x => x.Program.Split(',').ToArray()).ToArray();
                if (programKodes.Length > 0)
                {
                    var programViewModels = csvProgram.Where(x => programKodes.Contains(x.Kode)).ToArray();
                    if (programViewModels.Length > 0)
                    {
                        keahlianViewModel.Programs = programViewModels.Select(x => new ProgramViewModel
                        {
                            Nama = x.Nama
                        }).ToList();
                    }
                }
                result.Add(keahlianViewModel);
            }
            return result;

        }
    }
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
                Jurusan = x.Jurusan,
                Email = x.Email,
                Fax = x.Fax,
                Telpon = x.Telpon,
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
