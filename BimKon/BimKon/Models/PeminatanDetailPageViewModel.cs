using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class PeminatanDetailPageViewModel : BaseViewModel
    {
        static ICsvHelper helper = DependencyService.Get<ICsvHelper>();

        public PeminatanDetailPageViewModel()
        {
            ProgramKeahlian = new ObservableCollection<ProgramViewModel>();
        }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command<KeahlianViewModel>(async (s) =>
                {

                    var csvProgram = App.Programs;
                    var csvKeahlianDanProgram = App.BidangDanProgramKeahlianCsv;
                    var csvPaketKeahlian = App.PaketKeahlian;
                    var programs = csvKeahlianDanProgram.Where(x => x.Bidang == s.Nama).ToList();
                    var programKodes = programs.SelectMany(x => x.Program.Split(',').ToArray()).ToArray();
                    if (programKodes.Length > 0)
                    {
                        var programViewModels = csvProgram.Where(x => programKodes.Contains(x.Kode)).ToArray();
                        if (programViewModels.Length > 0)
                        {
                            var result = new List<ProgramViewModel>();
                            foreach (var program in programViewModels)
                            {
                                var paketKeahlians = csvPaketKeahlian.Where(x => x.KodeProgram == program.Kode)
                                .Select(x => new PaketKeahlianViewModel
                                {
                                    Nama = x.Nama,
                                    Sekolah = x.Sekolah
                                }).ToList();
                                result.Add(new ProgramViewModel
                                {
                                    Nama = program.Nama,
                                    PaketKeahlians = paketKeahlians

                                });
                            }
                            ProgramKeahlian = new ObservableCollection<ProgramViewModel>(result);

                        }

                    }

                });
                return _init;
            }
        }
        private ObservableCollection<ProgramViewModel> _programKeahlian;
        public ObservableCollection<ProgramViewModel> ProgramKeahlian
        {
            get => _programKeahlian;
            set => SetProperty(ref _programKeahlian, value, nameof(ProgramKeahlian));
        }




    }
}
