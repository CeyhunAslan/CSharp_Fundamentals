using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //While-----
        //Bir ya da bir grup deyimin, belli bir koşul sağlandığı sürece tekrarlanması
        //için kullanılan bir denetim yapısıdır.
        private void btnExample_1_Click(object sender, EventArgs e)
        {
            //while ile 1-100 arası sayıları listbox'a basalım
            int sayac = 0;
            while (sayac < 100)
            {

                listBox1.Items.Add(sayac);
                sayac = sayac + 1;
            }
        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            //1-666 arasındaki tek ve çift sayıların toplamını yazdırın
            int sayı = 0;

            int tek = 0;
            int çıft = 0;

            while (sayı < 666)
            {
                sayı = sayı + 1;
                if (sayı % 2 == 0)
                {
                    çıft = çıft + sayı;
                }
                else
                {
                    tek = tek + sayı;
                }

            }
            MessageBox.Show($"Teklerin Toplamı : {tek} \n Çiftlerin Toplamı : {çıft} ");
        }

        private void btnExample_3_Click(object sender, EventArgs e)
        {
            //1965 yıllından günümüze kadar olan yıllar arasında 1990, 1992, 2001 yıllarını listbox1're ekleyelim

            int yıl = 1965;

            while (yıl <= DateTime.Now.Year)
            {
                yıl = yıl + 1;
                if (yıl == 1990 || yıl == 1992 || yıl == 2001)
                {
                    listBox1.Items.Add(yıl);
                }
            }
        }
    }
}
