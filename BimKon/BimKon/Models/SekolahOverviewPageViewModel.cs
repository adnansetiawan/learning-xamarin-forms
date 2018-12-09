using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using BimKon.Core.Repositories;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;

using Xamarin.Forms;
using static BimKon.Core.Enums;

namespace BimKon.Core.Models
{
    public class SekolahOverviewPageViewModel : BaseViewModel
    {
        private IJurusanDataSeed _jurusanDataSeed;
        public SekolahOverviewPageViewModel()
        {
            JurusanItems = new ObservableCollection<JurusanViewModel>();


        }
        public SchoolType SchoolType
        {
            get; set;
        }
        private ObservableCollection<JurusanViewModel> _jurusanItems;
        public ObservableCollection<JurusanViewModel> JurusanItems
        {
            get => _jurusanItems;
            set => SetProperty(ref _jurusanItems, value, nameof(JurusanItems));
        }
        private void OnLoginComplete(GoogleUser googleUser, string message)
        {
            if (googleUser != null)
            {
                //GoogleUser = googleUser;
                //IsLogedIn = true;
            }
            else
            {
                //_dialogService.DisplayAlertAsync("Error", message, "Ok");
            }
        }
        public Action CallBack { get; set; }
        private ICommand _init;
        public ICommand Init
        {
            get
            {

                _init = _init ?? new Command(async () =>
                {
                    var database = new Firebase.Database.FirebaseClient("https://bimkon-1540534201577.firebaseio.com/");

                    var sekolahItems = await database
                     .Child("Sekolah")
                     .OnceSingleAsync<FireBaseSekolah>();

                    var peminatanItems = await database
                   .Child("Peminatan")
                   .OnceAsync<FireBasePeminatan>();
                    var peminatanViewModels = new List<JurusanViewModel>();
                    foreach (var peminatan in peminatanItems)
                    {
                        foreach (var matapelajaran in peminatan.Object.MataPelajaran)
                        {
                            var itemViewModel = new JurusanViewModel
                            {
                                Name = matapelajaran,

                                Sekolah = new SekolahViewModel
                                {
                                    Name = peminatan.Object.Sekolah
                                },
                                Parent = new JurusanViewModel
                                {
                                    Name = peminatan.Object.Nama
                                }

                            };
                            peminatanViewModels.Add(itemViewModel);
                        }
                    }
                    var tempData = new List<JurusanViewModel>();
                    if (JurusanItems.Count == 0)
                    {
                        switch (SchoolType)
                        {
                            case SchoolType.SMK:
                                // _jurusanDataSeed = new SMKDataSeed();
                                tempData = peminatanViewModels.Where(x => x.Sekolah.Name == SchoolType.SMK.ToString()).ToList();
                                break;
                            case SchoolType.SMA:
                                tempData = peminatanViewModels.Where(x => x.Sekolah.Name == SchoolType.SMA.ToString()).ToList();

                                // _jurusanDataSeed = new SMADataSeed();
                                break;

                        }
                        //if (_jurusanDataSeed != null)
                        //{
                        //    _jurusanDataSeed.Seed();
                        //    JurusanItems = _jurusanDataSeed.JurusanItems;
                        //}
                    }
                    JurusanItems = new ObservableCollection<JurusanViewModel>(tempData);

                    CallBack?.Invoke();

                });
                return _init;
            }
        }
    }
}
