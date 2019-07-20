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
            MataPelajarans = new ObservableCollection<MataPelajaranViewModel>();
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command<SekolahDetailViewModel>(async (s) =>
                {
                    var mataPelajarans = helper.ReadJurusanMataPelajaran(s.JenjangPendidikan);

                    if (s.JenjangPendidikan == "SMK")
                    {
                        var mappingSMK = helper.ReadJurusanMataPelajaranMappingSMK();
                        if (mappingSMK == null || mappingSMK.Count == 0)
                        {
                            return;
                        }
                        var smk = mappingSMK.FirstOrDefault(x => x.NamaSekolah == s.Nama);
                        if (smk == null)
                        {
                            return;
                        }
                        var availableJurusanKode = smk.Kode.Split(',').ToArray();
                        if (availableJurusanKode == null || availableJurusanKode.Length == 0)
                            return;
                        var availableJurusans = mataPelajarans.Where(x => availableJurusanKode.Contains(x.Kode));
                        MataPelajarans = new ObservableCollection<MataPelajaranViewModel>(availableJurusans.Select(x => new MataPelajaranViewModel
                        {
                            Jurusan = x.Jurusan,
                            MataPelajaran = x.MataPelajaran
                        }));
                    }
                    else
                    {
                        MataPelajarans = new ObservableCollection<MataPelajaranViewModel>(mataPelajarans.Select(x => new MataPelajaranViewModel
                        {
                            Jurusan = x.Jurusan,
                            MataPelajaran = x.MataPelajaran
                        }));
                    }
                    var syaratMasuk = helper.ReadSyaratMasuk(s.JenjangPendidikan);
                    SyaratsMasuk = new ObservableCollection<SyaratViewModel>(syaratMasuk.Select(x => new SyaratViewModel
                    {
                        Group = x.Kode,
                        Description = x.Description
                    }));
                    var syaratJurusan = helper.ReadSyaratJurusan(s.JenjangPendidikan);
                    SyaratsJurusan = new ObservableCollection<SyaratViewModel>(syaratJurusan.Select(x => new SyaratViewModel
                    {
                        Group = x.Jurusan,
                        Description = x.Description,
                        ShowTitle = x.ShowTitle

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
        private ObservableCollection<MataPelajaranViewModel> _mataPelajarans;
        public ObservableCollection<MataPelajaranViewModel> MataPelajarans
        {
            get => _mataPelajarans;
            set => SetProperty(ref _mataPelajarans, value, nameof(MataPelajarans));
        }



    }
}
