using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Functions_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Fonksiyonlar: fonksiyonlar belirli bir işi yapması ve işi geri döndürmesi için yapılmış yapılardır.Fonksiyonların methodlardan farkı ikiside üzerlerine verilen işi yapar anca methodlar işin sonucunda bizlere değer döndürmezler
        //Fonksiyonları tanımlarken 
        //1.Fonksiyonların mutlaka bir Acces Modifier olmalıdır.Default değer internal dır
        //2.Fonksiyonumuzun tipi olacak ve fonksiyonu yaratırken tanımladığımız bu tipte bize değer dönücektir.
        //3.Parametre verilir ki bu parametreler dışardan gelebilir yada fonksiyonla birlikte sabit gelebilir.
        //4.son oalrak fonksiyon bize değer döner(return)
        public int ToplamaYap(int deger1, int deger2)
        {

            return deger1 + deger2;
        }

        string Tek_CiftSayilarinToplami()
        {
            //Not: Yukarıdaki fonksiyon işlem yapması için parametrelerine değer gelmesine ihtiyaç duymaktadır. Bu fonksiyonda bu durum söz konusu değildir. Bu bağlamda fonksiyonları ikiye ayırabiliriz. Parametreli fonksiyonlar ve parametresiz fonksiyonlar.
            int ciftlerinToplami = 0;
            int teklerinToplami = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;//ciftlerinToplami = ciftlerinToplami + i;
                }
                else
                {
                    teklerinToplami += i;
                }
            }

            return $"Çiftlerin Toplami: {ciftlerinToplami}\nTeklerin Toplami: {teklerinToplami}";
        }

        List<string> SesliHarfBul(string param)
        {
            char[] karakterler = param.ToLower().ToCharArray();
            List<string> bulunanSesliHarfler = new List<string>();
            for (int i = 0; i < karakterler.Length; i++)
            {
                switch (karakterler[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        bulunanSesliHarfler.Add(karakterler[i].ToString());
                        break;
                    default:
                        break;
                }
            }

            return bulunanSesliHarfler;
        }

  


    }
}
