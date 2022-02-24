using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Do While-----
        //Bütün döngüler adım adım işlem yaptırırlar. BU döngülerin ortak özelliğidir. Do while diğer döngülerden farklı bir özelliği daha vardır. Do while, döngü çerisine verilen şarta bakmaksızın bir kez çalışır daha sonra dönünün şart cümleciğine bakar ve şart tutuyorsa döngü çalışmaya devam ederken şart tutmuyorsa döngü çalışmaz.
        private void btnExample_1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                sayac++;
                listBox1.Items.Add(sayac);

            }
            while (sayac < 15);
        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            int sayı = 0;

            do
            {
                sayı++;
                if (sayı % 2 == 0)
                {
                    listBox1.Items.Add(sayı);
                }


            } while (sayı < 15);
        }
    }
}
