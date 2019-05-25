using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{

    public class KuliahDataSeed : IKuliahDataSeed
    {
        public KuliahDataSeed()
        {
            GroupKuliahItems = new ObservableCollection<GroupKuliahViewModel>();
        }
        public ObservableCollection<GroupKuliahViewModel> GroupKuliahItems
        {
            get; set;
        }

        public void Seed()
        {
            var groupKuliahs = new List<GroupKuliahViewModel>();
            var groupSains = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Sains",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanSains = new string[]
                {"Matematika","Fisika","Kimia","Biologi","Statistika","Ilmu Komputer","Geofisika","Astronomi","Farmasi" };
            foreach (var jurusan in jurusanSains)
            {
                groupSains.Add(jurusan);

            }
            groupKuliahs.Add(groupSains);
            var groupTeknik = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Teknik",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanTeknik = new string[]
        {"Teknik kimia","Teknik fisika","Teknik geofisika","Teknik informatika","Teknik industri","Teknik mesin", "Teknik perkapalan","Teknik lingkungan","Teknik planologi", "Teknik penerbangan", "Teknik metalurgi", "Teknik geodesi", "Teknik nuklir", "Teknik geologi", "Teknik pertambangan", "Teknik perminyakan", "Teknik manufaktur", "Teknik geomatika" };
            foreach (var jurusan in jurusanTeknik)
            {
                groupTeknik.Add(jurusan);

            }
            groupKuliahs.Add(groupTeknik);

            var groupKesehatan = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Kesehatan dan Kedokteran",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanKesehatan = new string[]
            {"Pendidikan dokter","Kedokteran gigi","Kedokteran hewan","Ilmu keperawatan","Gizi dan kesehatan","Kesehatan masyarakat", "Kebidanan" };
            foreach (var jurusan in jurusanKesehatan)
            {
                groupKesehatan.Add(jurusan);

            }
            groupKuliahs.Add(groupKesehatan);

            var groupPertanian = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Pertanian, Kehutanan, dan Perikanan",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanPertanian = new string[]
           {"Ilmu tanah", "Budidaya pertanian (agronomi)", "Sosial ekonomi pertanian ( Agrobisnis)","Ilmu hama dan penyakit tumbuhan","Perikanan", "Peternakan","Kehutanan","Teknologi hasil pertanian", "Teknologi industry pertanian" };
            foreach (var jurusan in jurusanPertanian)
            {
                groupPertanian.Add(jurusan);

            }
            groupKuliahs.Add(groupPertanian);

            var groupPendidikan = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu pendidikan",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanPendidikan = new string[]
          {"Pendidikan fisika","Pendidikan matematika","Pendidikan kimia","Pendidikan biologi","Pendidikan teknik elektronika","Pendidikan teknik sipil","Pendidikan teknik mesin" };
            foreach (var jurusan in jurusanPendidikan)
            {
                groupPendidikan.Add(jurusan);

            }
            groupKuliahs.Add(groupPendidikan);

            var groupBahasa = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Bahasa dan Sastra",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanBahasa = new string[]
            { "Bahasa dan sastra Indonesia","Bahasa dan sastra inggris","Bahasa dan sastra arab","Bahasa jepang",
            "Bahasa mandarin","Bahasa jerman","Bahasa prancis"};
            foreach (var jurusan in jurusanBahasa)
            {
                groupBahasa.Add(jurusan);

            }
            groupKuliahs.Add(groupBahasa);

            var groupSeni = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Seni",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanSeni = new string[]
           { "Seni rupa","Seni musik","Seni pedalangan","Seni karawitan","Teater"};
            foreach (var jurusan in jurusanSeni)
            {
                groupSeni.Add(jurusan);

            }
            groupKuliahs.Add(groupSeni);

            var groupSospol = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Sosial dan Politik",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanSospol = new string[]
             { "Ilmu hubungan internasional","Ilmu komunikasi" };
            foreach (var jurusan in jurusanSospol)
            {
                groupSospol.Add(jurusan);

            }
            groupKuliahs.Add(groupSospol);

            var groupHukum = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Hukum",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanHukum = new string[]
             { "Hukum perdana","Hukum perdata" };
            foreach (var jurusan in jurusanHukum)
            {
                groupHukum.Add(jurusan);

            }
            groupKuliahs.Add(groupHukum);
            var groupEkonomi = new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Ekonomi",
                TipeSekolah = Enums.SchoolType.SMA,
            };
            var jurusanEkonomi = new string[]
                    { "Ekonomi akuntansi","Ekonomi manajemen","Ekonomi studi pembangunan","Ekonomi Islam Muamalat","Hukum Ekonomi Syariah"};
            foreach (var jurusan in jurusanEkonomi)
            {
                groupEkonomi.Add(jurusan);

            }
            groupKuliahs.Add(groupEkonomi);

            GroupKuliahItems = new ObservableCollection<GroupKuliahViewModel>(groupKuliahs);
        }
    }
}
