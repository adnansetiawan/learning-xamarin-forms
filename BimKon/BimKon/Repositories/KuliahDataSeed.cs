using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public class SekolahKuliahDataSeed : ISekolahKuliahDataSeed
    {
        public SekolahKuliahDataSeed()
        {
            SekolahKuliahItems = new ObservableCollection<SekolahKuliahViewModel>();
        }
        public ObservableCollection<SekolahKuliahViewModel> SekolahKuliahItems
        {
            get; set;
        }

        public void Seed()
        {
            var kuliahDataSeed = new KuliahDataSeed();
            kuliahDataSeed.Seed();
            var list = new List<SekolahKuliahViewModel>();
            list.Add(new SekolahKuliahViewModel
            {
                Id = Enums.SchoolType.SMA,
                Groups = kuliahDataSeed.GroupKuliahItems.Where(x => x.TipeSekolah == Enums.SchoolType.SMA).ToList()
            });
            SekolahKuliahItems = new ObservableCollection<SekolahKuliahViewModel>(list);
        }
    }
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
            groupKuliahs.Add(new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Sains",
                Jurusans = new string[]
                {"Matematika","Fisika","Kimia","Biologi","Statistika","Ilmu Komputer","Geofisika","Astronomi","Farmasi" },
                TipeSekolah = Enums.SchoolType.SMA,

            });
            groupKuliahs.Add(new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Teknik",
                Jurusans = new string[]
                {"Teknik kimia","Teknik fisika","Teknik geofisika","Teknik informatika","Teknik industri","Teknik mesin", "Teknik perkapalan","Teknik lingkungan","Teknik planologi", "Teknik penerbangan", "Teknik metalurgi", "Teknik geodesi", "Teknik nuklir", "Teknik geologi", "Teknik pertambangan", "Teknik perminyakan", "Teknik manufaktur", "Teknik geomatika" },
                TipeSekolah = Enums.SchoolType.SMA,

            });
            groupKuliahs.Add(new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu Kesehatan dan Kedokteran",
                Jurusans = new string[]
                {"Pendidikan dokter","Kedokteran gigi","Kedokteran hewan","Ilmu keperawatan","Gizi dan kesehatan","Kesehatan masyarakat", "Kebidanan" },
                TipeSekolah = Enums.SchoolType.SMA,

            });
            groupKuliahs.Add(new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Llmu Pertanian, Kehutanan, dan Perikanan",
                Jurusans = new string[]
                {"Ilmu tanah", "Budidaya pertanian (agronomi)", "Sosial ekonomi pertanian ( Agrobisnis)","Ilmu hama dan penyakit tumbuhan","Perikanan", "Peternakan","Kehutanan","Teknologi hasil pertanian", "Teknologi industry pertanian" },
                TipeSekolah = Enums.SchoolType.SMA,

            });
            groupKuliahs.Add(new GroupKuliahViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ilmu pendidikan",
                Jurusans = new string[]
                {"Pendidikan fisika","Pendidikan matematika","Pendidikan kimia","Pendidikan biologi","Pendidikan teknik elektronika","Pendidikan teknik sipil","Pendidikan teknik mesin" },
                TipeSekolah = Enums.SchoolType.SMA,

            });
            GroupKuliahItems = new ObservableCollection<GroupKuliahViewModel>(groupKuliahs);
        }
    }
}
