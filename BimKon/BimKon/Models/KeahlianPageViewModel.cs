using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class KeahlianPageViewModel : BaseViewModel
    {
        public KeahlianPageViewModel()
        {
            Keahlians = new ObservableCollection<KeahlianViewModel>();
        }
        private ObservableCollection<KeahlianViewModel> _keahlians;
        public ObservableCollection<KeahlianViewModel> Keahlians
        {
            get => _keahlians;
            set => SetProperty(ref _keahlians, value, nameof(Keahlians));
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
                {
                    Keahlians = App.Keahlians;

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
                        Keahlians = App.Keahlians;
                        return;
                    }
                    var matchItems = App.Keahlians.Where(x => x.Nama.ToLower().Contains(keyword.ToLower()));
                    Keahlians = new ObservableCollection<KeahlianViewModel>(matchItems);

                });
                return _search;
            }
        }
    }
}
