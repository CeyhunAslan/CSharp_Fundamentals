using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //For --
        //For döngümüz tab + tab dediğimiz zaman parantez içine döngü ile ilgi herşeyi verir.
        //ilk önce ne tipte dönücem (int , string , char olabilir) Yani döngünü içinde dönecek olan değişkenin tipi
        //tipini belirleidğimiz değişkenin adı (Herhangi bir şey oalbilir)
        //bu değişkene bir değer atamak istersek ki bu tamamen seneryoya yani ne içinde nasıl dönmek istediğine bağlıdır.Boş geçileriblir.
        //ardından şartımız nekadar dönsün
        //sonra artma oranı yani dönem hızı
        private void btnExamples_1_Click(object sender, EventArgs e)
        {
            //'a' dan 'z' ye alfabenin içinde dönüp yakaladığımız char tipindeki değerleri listbox'a basalım
            char Harf;

            for (Harf = 'a'; Harf <= 'z'; Harf++)
            {
                listBox1.Items.Add(Harf);
            }
        }

        private void btnExamples_2_Click(object sender, EventArgs e)
        {
            // 101 ile 0 arasındaki tek sayıları lisbox1 'e çift sayıalrı listboxx'e yazdırıyorum
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                    listBox1.Items.Add(i);
                else
                    listBox2.Items.Add(i);
            }
        }

        private void btnExamples_3_Click(object sender, EventArgs e)
        {
            //A'dan Z'ye harfleri listbox1're yazdırın
            char Harf;

            for (Harf = 'a'; Harf <= 'z'; Harf++)
            {
                listBox1.Items.Add(Harf);
            }
        }

        private void btnExamples_4_Click(object sender, EventArgs e)
        {
            // oluşturudğumuz array ın içine 10 tane rasgele sayı basıyorum  ve sayıalrı kısyaslayarak en büyüğü buluyorum 
            Random random = new Random();

            int[] sayılar = new int[10];

            int enBuyukSayi = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = random.Next(1, 101);
                listBox1.Items.Add(sayılar[i]);
            }
            for (int i = 0; i < sayılar.Length; i++)
            {
                if (enBuyukSayi < sayılar[i])
                {
                    enBuyukSayi = sayılar[i];
                }

            }

            listBox2.Items.Add(enBuyukSayi);
        }

        private void btnExamples_5_Click(object sender, EventArgs e)
        {
            //2 farklı array'i rastgele sayılar ile dolduruyoruz. Array'lerin karşılık gelen index'lerinde tutulan değerleri toplayarak sonucu listbox1're ekliyoruz.

            Random random = new Random();

            int[] sayilar_1 = new int[10];
            int[] sayilar_2 = new int[10];

            for (int i = 0; i < sayilar_1.Length; i++)
            {
                sayilar_1[i] = random.Next(1, 101);
                sayilar_2[i] = random.Next(1, 101);
                listBox1.Items.Add($"{sayilar_1[i]} + {sayilar_2[i]} = {sayilar_1[i] + sayilar_2[i]}");
            }
        }
    }
}
