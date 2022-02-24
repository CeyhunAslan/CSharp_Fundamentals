using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Void_Methods_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Void Methods: Geriye değer döndürmezler sadece üzerlerine yüklenen işleri yaparlar. Subrutin olarak adlandırılırlar. Methodlar yada fonksiyonlar kodları belirli işler yaptıkramk için kullanılırlar. Her ikiside parametre alabilir ve bu bağlamda aşırı yüklenebilir. Lakin aralarındaki bir fark bulunmaktadır, bu fark ise fonksiyonların değer döndürmesidir. Void methodlar değer döndürmezler, sadece üzerlerine atanan işleri icra ederler.

        //Yapacağımız işe ve ihtiyaçlarımıza göre method yada fonksiyon seçmeliyiz. Şayet bir iş sonucunda bir değer elde etmeyi ve bu elde edilen değeri başka işlerde kullanmak istiyorsak fonksiyon kullanmalıyız. Şayet iş yapılacak ve bitecek ise void method tercih etmeliyiz.

        void Renklendir()
        {
            this.BackColor = Color.Black;//this demek form demek
            this.Size = new Size(800, 800);
        }
        void Saydirici()
        {
            for (int i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        void ButtonRenk(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.BlueViolet;
                }
            
            }
        }
        void Compture()
        {
            string MaciheName = Environment.MachineName;//Dns.GetHostName();
            MessageBox.Show($" PC ADI : {MaciheName}");
        
        }
        void IP()
        {
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                listBox1.Items.Add("Ip Adresi: " + adres);

            }
        }
        void CatchText(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is Button )
                {
                    item.Text = "Herşey Güzel Olacak.....!!!";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Saydirici();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            Renklendir();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            ButtonRenk(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compture();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            IP();
        }

        private void btnCatchText_Click(object sender, EventArgs e)
        {
            CatchText(this);
        }
    }
}
