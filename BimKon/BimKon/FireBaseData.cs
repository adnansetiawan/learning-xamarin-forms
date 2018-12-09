using System;
namespace BimKon.Core
{

    public class FireBaseSekolah
    {
        public string[] Tipe { get; set; }

    }
    public class FireBasePeminatan
    {
        public string Nama { get; set; }
        public string Sekolah { get; set; }
        public string[] MataPelajaran { get; set; }
    }

}
