using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Kitaplar = new List<string>();
        //Foreach listeler ya da diziler üzerinde işlem yapmak için kullanılan döngü yapısıdır
        //.Özellikle eleman sayısının bilinmediği durumlarda büyük kolaylık sağlamaktadır.
        private void Form1_Load(object sender, EventArgs e)
        {
            Kitaplar.Add("KralKatili Güncesi");
            Kitaplar.Add("Taht Oyunları");
            Kitaplar.Add("Centilmen Piç");
            Kitaplar.Add("Yüzüklerin Efendisi");
            Kitaplar.Add("Harry Potter");
            Kitaplar.Add("Overlord");
        }
        private void btnExamples_1_Click(object sender, EventArgs e)
        {
            foreach (string item in Kitaplar)
            {
                if (txtKitap.Text == item)
                {
                    listBox1.Items.Add(item);
                    MessageBox.Show("Aradığınız Kitap");
                }
            }
        }

        private void btnExamples_2_Click(object sender, EventArgs e)
        {
            //Alfabe deki sesli harfleri bulup listbox birer ekleyelelim.
            char[] Alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] Harfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };

            foreach (char item in Alfabe)
            {
                foreach (char item2 in Harfler)
                {
                    if (item == item2)
                    {
                        listBox1.Items.Add(item);
                        break;
                    }

                }
            }
        }

        public void Ereaser(GroupBox groupBox)
        {
            //foreach en büyük kolaylığı herhangi bir koleksiyon içinde dönebilmesidir.

            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        public void RenkDeğistirme(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.DarkCyan;
                }
            }
        }
    }
}
