using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_Functions_Math_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnPi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pi Sayısı: {Math.PI}");
        }

        private void btnABS_Click(object sender, EventArgs e)
        {
            //Mutlak Değer hesaplar
            MessageBox.Show(Math.Abs(-12.5).ToString());
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Verilen ondalıklı değeri, bir alt değer yuvarlar. Örneğin 12.3 gelirse 12'ye yuvarlar
            MessageBox.Show($"Floor: {Math.Floor(Double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnCelling_Click(object sender, EventArgs e)
        {
            //Ceilling: Verilen ondalıklı değeri bir üst tam sayıya tamamlar
            MessageBox.Show($"Ceiling: {Math.Ceiling(Decimal.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Round: Verilen sayının ondalıklı kısmı 50'nin altında ise aşağıya , üstünde ise bir üst tam sayıya yuvarlanır.

            MessageBox.Show($"Round: {Math.Round(Double.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Ondalıklı kısma bakmaksızın tam kısmı size teslim eder.
            MessageBox.Show($"Truncate: {Math.Truncate(decimal.Parse(txtVeriGirisi_1.Text))}");
        }

        private void btnPow_Click(object sender, EventArgs e)
        {  //Kendisine geçirilen base parametrenin exp parametre değeri kadar üs değerini hesaplar.
            MessageBox.Show($"Pow: {Math.Pow(3, Math.Pow(int.Parse(txtVeriGirisi_1.Text), 2))}");
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"SQRT: {Math.Sqrt(double.Parse(txtVeriGirisi_1.Text))}");
        }
    }
}
