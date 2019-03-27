using System;
using System.Collections.Generic;
using BimKon.Core.Models;

namespace BimKon.Core.Repositories
{
    public class MinatDataSeed
    {
        public static List<MinatViewModel> GetAll()
        {
            var result = new List<MinatViewModel>();
            result.Add(new MinatViewModel
            {
                Minat = "Anda senang bekerja terutama dengan menggunakan fisik, kekuatan otot, keterampilan fisik, seperti dengan tangan membuat, memperbaiki, merakit atau membangun sesuatu, menggunakan dan mengoperasikan peralatan, atau mesin yang sering anda sukai untuk bekerja diluar ruangan",
                Tipe = "Realistik (Motorik)",
                MataPelajaran = "Bahasa inggris, Matematika,  Lokakarya, Sains, Komputer, Studi Bisnis, Holtikultura, Pertanian, Pendidikan, Jasmani",
                Pekerjaan = "Pilot, petani, tukang pelapis, listrik, teknologi, komputer, hortikultura, pembangun, insinyur, personal, layanan bersenjata,mekanik,penjaga taman,olahragawan",
                Keterampilan = "Menggunakan dan mengoperasikan alat, peralatan dan mesin, merancang, membangun, memperbaiki,   memelihara, mengukur, bekerja secara detail, mengemudi, bergerak, merawat hewan, bekerja dengan tanaman"
            });
            result.Add(new MinatViewModel
            {
                Tipe = "Investigasi (Intelektual)",
                Minat = "Anda suka menemukan ide dan meneliti, mengamati,menginvestigasi,dan bereksperimen,mengajukan pertanyaan, dan menyelesaikan pertanyaan",
                MataPelajaran = "Bahasa Inggris, Matematika, Sains, Komputer, Teknologi",
                Pekerjaan = "Ilmu pengetahuan,teknisi penelitian,laboratorium medis,pertanian,pekerjaan medis dan kesehatan,ahli kimia, ilmuan kelautan, ahli kehutanan, ahli zoology,dokter gigi,dokter umum",
                Keterampilan = "Berfikir analitis dan logis, komputasi,berkomunikasi dengan menulis dan berbicara, merancang, merumuskan, menghitung, mendiagnosa,bereksperimen dan menyelidiki"
            });
            result.Add(new MinatViewModel
            {
                Tipe = "Artistik (Estetik)",
                Minat = "Anda suka menggunakan kata-kata seni, musik atau drama untuk mengekspresikan diri, berkomunikasi atau melakukan atau anda suka membuat atau merancang sesuatu",
                MataPelajaran = "Bahasa inggris, Drama,desain grafis seni,Studi bisnis,Bahasa",
                Pekerjaan = "Pekerjaan dengan komponen praktis, artis, fotografer, illustrator, penulis, composer, penari, actor, piñata rambut, perancang busana, reporter, penulis, editor, dan lainnya yang sejenis",
                Keterampilan = "Orang model artistik ini ditandai dengan berbagai macam tugas dan masalah yang memerlukan interpretasi atau kreasi bentuk-bentuk artistic melalui cita rasa, perasaan dan imajinasi"
            });
            result.Add(new MinatViewModel
            {
                Tipe = "Sosial (Supportive)",
                Minat = "Anda suka bekerja dengan orang-orang untuk mengajar, melatih, member informasi, membantu, melayani, dan menyapa, anda memperhatikan kesejahtraan dan kesejahtraan orang lain. ",
                MataPelajaran = "Bahasa Inggris,Ilmu sosial,Matematika,Sains,Kesehatan,Pendidikan jasmani",
                Pekerjaan = "Guru, penasehat, perawat, peyugas polisi, tenaga penjualan, pekerja social, sekretaris, petugas pelayan, konselor, psikolog klinik, terapis, dan pekerjaan lain yang sejenis.",
                Keterampilan = "Ciri dari tipe ini adalah pandai bergaul dan berbicara, bersifat responsive, bertanggung jawab, kemanusiaan, bersifat religious, membutuhkan perhatian, memiliki kecakapan verbal, hubungan antar pribadi, kegiata-kegiatan rapid an teratur, menjauhkan bentuk pemecahan masalah secara intelektual dan berorientasi pada perasaan. "
            });
            result.Add(new MinatViewModel
            {
                Tipe = "Enterprising (Persuasive)",
                Minat = "Anda suka bertemu orang, berbicara dan mempengaruhi orang lain, mendorong orang lain, menganggap dirinya paling kuat, jantan, mudah adaptasi, menyenangi tugas social, perhatian besar pada kekuasaan, status dan kepemimpinan, agresif dalam kegiatan lisan.",
                Keterampilan = "Tipe ini cocok dalam hal menjual, mempromosikan dan membujuk, mengembangkan ide-ide, berbicara di depan umu, mengelola, mengatur, memimpin, menghitung, merencanakan.",
                Pekerjaan = "Pedagang, politikus, manajer, pemimpin eksekutif perusahaan, perwakilan dagang dan pekerjaan lain yang sejenis.",
                MataPelajaran = "Bahasa Inggris,IPS,Matematika,Sains,Kesehatan,Pendidikan Jasmani,Seni,Komputasi,Studi bisnis, Bahasa"
            });
            result.Add(new MinatViewModel
            {
                Tipe = "Conventional (Conforming)",
                Minat = "Tipe model ini memiliki anda suka bekerja di dalam ruangan dan melakukan tugas-tugas yang melibatkan pengorganisasian dan akurasi, mengikuti prosedur, bekerja dengan data atau angka, merencanakan pekerjaan, dan acara.",
                Keterampilan = "Tipe ini terampil dalam menghitung, menyapa, melakukan pengetikan, merekam, dan menyimpan catatan, memperhatikan secara detail, sistematis, dan perhitungan, menangani uang, mengatur, bekerja secara mandiri. ",
                Pekerjaan = "Sekretaris, resepsionis, pekerjaan kantor, pustakwan, petugas bank, operator komputer, kasir, statistika, pemegang buku, pegawai arsip, petugas pengiriman dan pekerjaan lain yang sejenis.",
                MataPelajaran = "Bahasa inggris,Matematika,Studi bisnis,Akuntansi,Ekonomi,Computer"
            });
            return result;
        }
    }
}
