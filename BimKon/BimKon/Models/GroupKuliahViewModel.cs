using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static BimKon.Core.Enums;

namespace BimKon.Core.Models
{
    public class SekolahKuliahViewModel
    {
        public SekolahKuliahViewModel()
        {
            Groups = new List<GroupKuliahViewModel>();
        }
        public Enums.SchoolType Id { get; set; }
        public string Name { get; set; }
        public List<GroupKuliahViewModel> Groups { get; set; }
    }

    public class GroupKuliahViewModel : ObservableCollection<string>
    {

        public string Id { get; set; }
        public SchoolType TipeSekolah { get; set; }
        public string Name { get; set; }
        //public string[] Jurusans { get; set; }

    }


}
