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
    public class SekolahOverviewPageViewModel : BaseViewModel
    {
        public SekolahOverviewPageViewModel()
        {
            SekolahItems = new ObservableCollection<SekolahDetailViewModel>();


        }

        private ObservableCollection<SekolahDetailViewModel> _sekolahItems;
        public ObservableCollection<SekolahDetailViewModel> SekolahItems
        {
            get => _sekolahItems;
            set => SetProperty(ref _sekolahItems, value, nameof(SekolahItems));
        }
        public Action CallBack { get; set; }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
               {
                   SekolahItems = App.SekolahItems;
                   CallBack?.Invoke();

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
                        SekolahItems = App.SekolahItems;
                        return;
                    }
                    var matchItems = App.SekolahItems.Where(x => x.Nama.ToLower().Contains(keyword.ToLower()));
                    SekolahItems = new ObservableCollection<SekolahDetailViewModel>(matchItems);

                });
                return _search;
            }
        }
        private ICommand _filterByJenjangPendidikan;
        public ICommand FilterByJenjangPendidikan
        {
            get
            {

                _filterByJenjangPendidikan = _filterByJenjangPendidikan ?? new Command<string>((jenjangPendidikan) =>
                {
                    if (jenjangPendidikan == "semua")
                    {
                        SekolahItems = App.SekolahItems;
                    }
                    else
                    {
                        SekolahItems = new ObservableCollection<SekolahDetailViewModel>(App.SekolahItems.Where(x => x.JenjangPendidikan.ToLower() == jenjangPendidikan.ToLower()));
                    }



                });
                return _filterByJenjangPendidikan;
            }
        }
    }
}
