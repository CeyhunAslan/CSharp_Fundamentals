using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_String_Functions_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            //Compare To => Function kullanığım string değerle function'î parametresine verdiğimiz değer sözlük mantığı ile karşılaştırılır. Eğer harfler aynı lokasyonda ise 0, parametredeki değer ana değerimizde ise -1 sonra ise 1 dönmektedir.

            string ornekMetin = txtVeri1.Text;
            int sonuc = ornekMetin.CompareTo(txtVeri2.Text);

            string mesaj = String.Empty;

            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime işle eşleşmedi fazla karakter var..!";
                    break;
                case 0:
                    mesaj = "Kelimeler eşleşti..!";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşleşmemektedir. Eksik karekter var..!";
                    break;
                default:
                    break;
            }

            MessageBox.Show(mesaj);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains => Metin içerisinde aranan harf yada söz öbeği varsa True yoksa False döner
            string ornekMetin = txtVeri1.Text;
            bool sonuc = ornekMetin.Contains(txtVeri2.Text);


            //Yol I
            if (sonuc == true)
            {
                MessageBox.Show("İçermektedir..!");
            }
            else
            {
                MessageBox.Show("İçermemektedir..!");
            }

            //Yol II
       
            MessageBox.Show($"Aradığınız değer {(sonuc ? "İçermektedir..!" : "İçermemektedir..!")}");
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            //Startwith: Kelime istenilen harf ile başlayıp başlamadığını belirler.

            //I.Yol
            string ornekMetin = txtVeri1.Text;
            bool result = ornekMetin.StartsWith(txtVeri2.Text);

            if (result == true)
                MessageBox.Show("Başlamaktadır..!");
            else
                MessageBox.Show("Başlamamaktadır..!");
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeri1.Text.EndsWith(txtVeri2.Text) ? "Bitmektedir..!" : "Bitmemektedir");
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //Index Of: Dizilerde gördüğümüz index mantığının ile çalıır. Methodunun aldığı parametredeki karakter metin içerisindeki hangi index karşılık geliyorsa bize onu döner. Unutmayın string ifadeler char dizisidir. Ayrıca aradığımız harften birden fazla varsa bize ilk buluğu index değerini döner. Aranan harf metin içerisinde bulunmazsa -1 dönmektedir.

            //I.YOl
            string ornekMetin = txtVeri1.Text;
            int index = ornekMetin.IndexOf(txtVeri2.Text);

            MessageBox.Show(index.ToString());


            //II.YOl
            MessageBox.Show(txtVeri1.Text.IndexOf(txtVeri2.Text).ToString());//Kullanıcıdan her zaman string tipte değer gelir ve biz kullanıcıya her zaman string tipte çıktı veririz. Burada IndexOf() fonksiyonu bize int tipinde değer döndüğünden, fonksiyon sonucunda dönen veriyi ToString() fonksiyonu ile string dönüştürdü.
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeri1.Text.LastIndexOf(txtVeri2.Text).ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //1.Kullanım => Remove fonksiyonu içerisine verilen index değerinden başlayarak geri kalan indexlerdeki karakterleri siler.
            //MessageBox.Show(txtVeriGiris_1.Text.Remove(int.Parse(txtVeriGirisi_2.Text)));

            //2.Kullanım
            MessageBox.Show(txtVeri1.Text.Remove(2, 7));
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            //Replace: Bir söz öbeği yerine verilen değeri basar.
            MessageBox.Show(txtVeri1.Text.Replace("adam", "kadın"));
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //Split: Uygulandığı metinde, verilen parametreye göre metni patçalar.
            //burak.yilmaz@bilgeadam.com;can.oguz@bilgeadam.com;ridvan.aksoy@bilgeadam.com
            string mailAdresi = txtVeri1.Text;
            string[] mailAdresleri = mailAdresi.Split(';');

            foreach (string mail in mailAdresleri)
            {
                //I.Yol
                //int index = mail.IndexOf('@');
                //string fullName =  mail.Remove(index);
                //listBox1.Items.Add(fullName.Replace('.', ' '));

                //II.Yol
                listBox1.Items.Add(mail.Remove(mail.IndexOf('@')).Replace('.', ' '));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert: bir metindeki istenilen index değerinden sonraki değerden başlayarak, ikinci parametreye verilen metni ekler.

            string ornekMetin = txtVeri1.Text;
            string sonuc = ornekMetin.Insert(5, "cik");
            MessageBox.Show(sonuc);
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            //1.Kullanım: Gelen metinde istenilne değerden sonrasını alt metne ayırır
            //MessageBox.Show(txtVeriGiris_1.Text.Substring(3));

            //2.Kullanımm: Gelen metinde belirtilen başlangı index değerinden sonra ikinci parametreye bakarak alt metin oluşturu.
            MessageBox.Show(txtVeri1.Text.Substring(3, 2));
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Boşluklarla Hesplanan Karakter Sayısı: {txtVeri1.Text.Length}\n Boşluklar Silindikten Sonraki Karakter Sayısı: {txtVeri1.Text.Trim().Length}");
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeri1.Text.ToUpper());
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtVeri1.Text.ToLower());
        }
    }
}
