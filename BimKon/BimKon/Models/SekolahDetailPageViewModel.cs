using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class SekolahDetailPageViewModel : BaseViewModel
    {
        static ICsvHelper helper = DependencyService.Get<ICsvHelper>();

        public SekolahDetailPageViewModel()
        {
            SyaratsMasuk = new ObservableCollection<SyaratViewModel>();
            SyaratsJurusan = new ObservableCollection<SyaratViewModel>();
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(() =>
                {

                    var syaratMasuk = helper.ReadSyaratMasuk();
                    SyaratsMasuk = new ObservableCollection<SyaratViewModel>(syaratMasuk.Select(x => new SyaratViewModel
                    {
                        Group = x.Kode,
                        Description = x.Description
                    }));
                    var syaratJurusan = helper.ReadSyaratJurusan();
                    SyaratsJurusan = new ObservableCollection<SyaratViewModel>(syaratJurusan.Select(x => new SyaratViewModel
                    {
                        Group = x.Jurusan,
                        Description = x.Description
                    }));
                });
                return _init;
            }
        }
        private ObservableCollection<SyaratViewModel> _syaratsMasuk;
        public ObservableCollection<SyaratViewModel> SyaratsMasuk
        {
            get => _syaratsMasuk;
            set => SetProperty(ref _syaratsMasuk, value, nameof(SyaratsMasuk));
        }
        private ObservableCollection<SyaratViewModel> _syaratsJurusan;
        public ObservableCollection<SyaratViewModel> SyaratsJurusan
        {
            get => _syaratsJurusan;
            set => SetProperty(ref _syaratsJurusan, value, nameof(SyaratsJurusan));
        }


    }
}
