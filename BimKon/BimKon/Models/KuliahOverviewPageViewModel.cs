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
        private readonly IKuliahDataSeed _kuliahDataSeed;
        public KuliahOverviewPageViewModel()
        {
            _kuliahDataSeed = new KuliahDataSeed();


        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
                {
                    _kuliahDataSeed.Seed();
                    AllGroupItems = _kuliahDataSeed.GroupKuliahItems;
                    GroupItems = AllGroupItems;

                });
                return _init;
            }
        }
        private ICommand _search;
        public ICommand Search
        {
            get
            {

                _search = _search ?? new Command<string>((keyword) =>
                {
                    if (string.IsNullOrEmpty(keyword))
                    {
                        GroupItems = AllGroupItems;
                        return;
                    }
                    var items = AllGroupItems.Where(x => x.Any(p => p.ToLower().Contains(keyword.ToLower()))).ToArray();
                    GroupItems = new ObservableCollection<GroupKuliahViewModel>(items);
                });
                return _search;
            }
        }
        private ObservableCollection<GroupKuliahViewModel> AllGroupItems;

        private ObservableCollection<GroupKuliahViewModel> _groupItems;
        public ObservableCollection<GroupKuliahViewModel> GroupItems
        {
            get => _groupItems;
            set => SetProperty(ref _groupItems, value, nameof(GroupItems));
        }

    }
}
