using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using BimKon.Core.Repositories;


using Xamarin.Forms;
using static BimKon.Core.Enums;

namespace BimKon.Core.Models
{
    public class KuliahOverviewPageViewModel : BaseViewModel
    {
        private readonly ISekolahKuliahDataSeed _sekolahKuliahDataSeed;
        public KuliahOverviewPageViewModel()
        {
            _sekolahKuliahDataSeed = new SekolahKuliahDataSeed();
            _sekolahKuliahDataSeed.Seed();
            SekolahItems = _sekolahKuliahDataSeed.SekolahKuliahItems;


        }

        private ObservableCollection<SekolahKuliahViewModel> _sekolahItems;
        public ObservableCollection<SekolahKuliahViewModel> SekolahItems
        {
            get => _sekolahItems;
            set => SetProperty(ref _sekolahItems, value, nameof(SekolahItems));
        }

    }
}
