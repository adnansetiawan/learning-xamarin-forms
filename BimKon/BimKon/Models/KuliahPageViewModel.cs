using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BimKon.Core.Repositories;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class KuliahPageViewModel : BaseViewModel
    {
        private IKuliahDataSeed _kuliahDataSeed;
        public KuliahPageViewModel()
        {
            _kuliahItems = new ObservableCollection<GroupKuliahViewModel>();
        }
        private ObservableCollection<GroupKuliahViewModel> _kuliahItems;
        public ObservableCollection<GroupKuliahViewModel> KuliahItems
        {
            get => _kuliahItems;
            set => SetProperty(ref _kuliahItems, value, nameof(KuliahItems));
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command<JurusanViewModel>((jurusan) =>
                {
                    _kuliahDataSeed = new KuliahDataSeed();
                    _kuliahDataSeed.Seed();
                    KuliahItems = _kuliahDataSeed.GroupKuliahItems;

                });
                return _init;

            }
        }
    }
}
