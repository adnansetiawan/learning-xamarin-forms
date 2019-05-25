using System;
using System.Collections.ObjectModel;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public interface ISekolahKuliahDataSeed
    {
        ObservableCollection<SekolahKuliahViewModel> SekolahKuliahItems { get; set; }
        void Seed();
    }
    public interface IKuliahDataSeed
    {
        ObservableCollection<GroupKuliahViewModel> GroupKuliahItems { get; set; }
        void Seed();

    }
}
