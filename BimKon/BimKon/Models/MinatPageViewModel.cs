using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class MinatPageViewModel : BaseViewModel
    {
        public MinatPageViewModel()
        {
            MinatItems = new ObservableCollection<MinatViewModel>();
        }
        private ObservableCollection<MinatViewModel> _minatItems;
        public ObservableCollection<MinatViewModel> MinatItems
        {
            get => _minatItems;
            set => SetProperty(ref _minatItems, value, nameof(MinatItems));
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
                {
                    MinatItems = App.MinatItems;

                });
                return _init;
            }
        }
    }
}
