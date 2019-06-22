using System;
using System.Collections.Generic;
using BimKon.Core.Models;
using Xamarin.Forms;

namespace BimKon.Core
{
    public partial class MengenalDiriPage : MasterPage
    {
        public MengenalDiriPage()
        {
            InitializeComponent();
            Title = "Mengenal Diri";
            var labelTitle = new Label { HorizontalOptions = LayoutOptions.CenterAndExpand, HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.FromHex("#3e89d5"), Text = "Kenali Tipe Kepribadianmu Berdasarkan teori Holland", FontSize = 16, FontAttributes = FontAttributes.Bold, Margin = new Thickness(0, 20, 0, 20) };
            var fs = new FormattedString();
            fs.Spans.Add(new Span { Text = "Perlu kamu ketahui bahwa sifat dari tugas, keterampilan, dan pengetahuan yang digunakan dalam suatu pekerjaan harus sesuai dengan hal - hal yang kamu sukai agar kamu dapat menjalankan pekerjaan tersebut dengan baik. Hal tersebut dapat kamu ketahui melalui hal - hal kecil yang kamu lakukan sehari - hari, misalnya seperti hoby dan mata pelajaran yang paling kamu sukai di sekolah.\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "Selain mengamati hal – hal yang sering kamu lakukan kamu juga dapat melakukan beberapa tes yang dapat membantu kamu mendapatkan gambaran mengenai dirimu sendiri, seperti minat, nilai, kepribadian, dan lain - lain.\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "Sejauh ini alat penilaian yang paling sering digunakan dalam perencanaan karier adalah RIASEK.\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "APA ITU RIASEK?\n", FontAttributes = FontAttributes.Bold, FontSize = 12 });
            fs.Spans.Add(new Span { Text = "RIASEK adalah gambaran tipe kepribadian yang dijelaskan oleh JOHN L.HOLLAND\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "Menurut HOLLAND cara terbaik yang mungkin cocok dengan kita adalah dengan menganalisisi pekerjaan yang berkaitan terhadap karakteristik kepribadian kita dan mencocokkannya dengan berbagai jenis lingkungan kerja.\n", FontSize = 12 });
            fs.Spans.Add(new Span { Text = "Jadi untuk adik-adik yang ingin mengenal dirinya lebih jauh lagi maka bisa mencoba menganalisas 6 tipe kepribadian ini:\n", FontSize = 12 });

            var labelContent = new Label();
            labelContent.FormattedText = fs;
            ContentLayout.Children.Add(labelTitle);
            ContentLayout.Children.Add(labelContent);



        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MengenalDiriDetailPage(), true);
        }
    }
}
