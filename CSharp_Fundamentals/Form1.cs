using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Fundamentals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form Hesap makinesi groupbox için
            cmbDortIslem.Items.Add("+");
            cmbDortIslem.Items.Add("-");
            cmbDortIslem.Items.Add("*");
            cmbDortIslem.Items.Add("/");


            Random random = new Random();
            lblRasgeleSayı.Text = Convert.ToString(random.Next(10, 100));
        }
        public void TexboxEraser(GroupBox groupBox)
        {
            // işim bitince Groupobxlarımı temizlemesi için method yazıyorum
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnHesapMakinesi_Click(object sender, EventArgs e)
        {//Combobox'ınmdaki  işleme göre  sayılara işelem yaptırım ekrana(MessageBox yoluyla) basıyorum
            decimal SayıIlk = Convert.ToDecimal(txtSayı1.Text);
            decimal SayıIkı = Convert.ToDecimal(txtSayı2.Text);

            decimal Sonuc = 0;
            if (cmbDortIslem.SelectedItem.ToString() == "+")
            {
                Sonuc = SayıIlk + SayıIkı;
            }
            else if (cmbDortIslem.SelectedItem.ToString() == "-")
            {
                Sonuc = (SayıIlk - SayıIkı);
            }
            else if (cmbDortIslem.SelectedItem.ToString() == "*")
            {
                Sonuc = SayıIlk * SayıIkı;
            }
            else if (cmbDortIslem.SelectedItem.ToString() == "/")
            {
                Sonuc = (SayıIlk / SayıIkı);
            }
            MessageBox.Show($"Sonuç : {Sonuc}");

            TexboxEraser(grpHesapMakinesi);
        }
        int kalanhak = 3;
        private void btnGırısYap_Click(object sender, EventArgs e)
        {
            //Kulanıcıdan alınan ID , ŞİFRE ve RANDOM Number ile giriş yapılabilmesinin sağlayalım 3 hatalı giriş buttonu kitler.
            if (txtId.Text == "21011205" && txtPasword.Text == "5150" && lblRasgeleSayı.Text == txtRasgeleSayi.Text)
            {
                MessageBox.Show("Başarıyla giriş yapılmıştır....!");

            }
            else
            {

                lblKalanHak.Text = Convert.ToString(kalanhak);
                kalanhak--;
                lblKalanHak.Text = kalanhak.ToString();
                if (lblKalanHak.Text != "0")
                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(10, 100);
                    lblRasgeleSayı.Text = sayı.ToString();
                }
                else
                {
                    btnGırısYap.Enabled = false;
                    MessageBox.Show("Giriş Hakkınız Dolmuştur...");
                }
                TexboxEraser(grpGirisEkranı);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kulanıcıların 1 ile 10 arası tahmın ettiği sayıları random sayı ile kıyaslayan bir oyun oynayalım.
            string oyuncu_1 = txtBırOyuncuTahmnini.Text;
            string oyuncu_2 = txtikiOyuncuTahmini.Text;

            Random r = new Random();
            int GelenSayı = r.Next(1, 10);

            if (oyuncu_1 == GelenSayı.ToString())
            {
                MessageBox.Show($"Tebrikler Birinci oyuncu kazandı...! {GelenSayı}");
            }
            else if (oyuncu_2 == GelenSayı.ToString())
            {
                MessageBox.Show($"Tebrikler İkinci oyuncu kazandı...! {GelenSayı}");
            }
            else
            {
                MessageBox.Show($"Gelen Sayı : {GelenSayı}");
            }

            TexboxEraser(grpSayıTahminOyunu);
        }

        private void btnNotHesapla_Click(object sender, EventArgs e)
        {
            //Kullanıcıdan alınan vize , final ve ödev notunun ortalaması hesaplanarak harf notu bulunuz.
            //Vize yüzde 30
            //Final yüzde 60
            //Ödev yüzde 10 etki edecektir.


            double Vize = Convert.ToDouble(txtVize.Text);
            double Final = Convert.ToDouble(txtFinal.Text);
            double Odev = Convert.ToDouble(txtOdev.Text);

            double ort = Vize * 0.3 + Final * 0.6 + 0.1;

            if (ort >= 85)
            {
                MessageBox.Show($"A {ort}");
            }
            else if (ort <= 84 && ort >= 70)
            {
                MessageBox.Show($"B {ort}");
            }
            else if (ort <= 69 && ort >= 55)
            {
                MessageBox.Show($"C {ort}");
            }
            else if (ort <= 54 && ort >= 45)
            {
                MessageBox.Show($"D {ort}");
            }
            else if (ort <= 44 && ort >= 0)
            {
                MessageBox.Show($"F {ort}");
            }
            else
            {
                MessageBox.Show("Girilen Not Geçerli Değildir.....!!!");
            }

            TexboxEraser(grpNotHesaplama);
        }

        private void btnHesapla_2_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan aldığımız üslü sayısı hesaplayıp kulanıcının cevabıyla karşılarştıralım
            double Taban = Convert.ToDouble(txtTaban.Text);
            double üst = Convert.ToDouble(txtÜst.Text);

            double usluSayi = Math.Pow(Taban, üst);

            double Cevap = Convert.ToDouble(txtCevap.Text);
            if (Cevap == usluSayi)
            {
                MessageBox.Show("Doğru Bildin Tebrikler ....!!!");
                listBox1.Items.Add(usluSayi);
            }
            else
            {
                MessageBox.Show("YANLIŞ ....!!!");
                listBox1.Items.Add(usluSayi);
            }

            TexboxEraser(grpUsluSayıHesaplama);
        }

        private void btnHesapla_3_Click(object sender, EventArgs e)
        {
            float boy = float.Parse(txtBoy.Text);
            float kılo = float.Parse(txtKılo.Text);

            float İndexB = kılo / (boy * boy);

            if (İndexB > 0 && İndexB <= 18.4)
            {
                MessageBox.Show($"Zayıf. Kişinin boyuna oranla ağırlığının yetersiz olduğunu ifade eden bu değer ile karşılaşılması durumunda kişinin diyetisyen eşliğinde sağlıklı bir şekilde kilo alması önerilir. {İndexB}");
            }
            else if (İndexB >= 18.5 && İndexB <= 24.9)
            {
                MessageBox.Show($"Normal. Bu değer aralığı kişinin ideal kiloda olduğunu gösterir. Bu değere sahip olan kişilerin düzenli, dengeli ve sağlıklı beslenmeye devam etmeleri önerilir. {İndexB }");
            }
            else if (İndexB >= 25 && İndexB <= 29.9)
            {
                MessageBox.Show($"Fazla Kilolu. Kişinin boyuna oranla kilosunun fazla olduğunu gösteren bu değer aralığında kişinin uygun diyet ile fazla kilolarından kurtulması önerilir.{İndexB }");
            }
            else if (İndexB >= 30 && İndexB <= 34.9)
            {
                MessageBox.Show($"Şişman. Birinci derece obez kategorisinde değerlendiren değer aralığında, kişinin kilosunun sağlık açısından risk oluşturabilecek düzeyde olduğu anlaşılır. Bu kişilerin diyetisyen yardımıyla kilo vermesi önerilir.{İndexB}");
            }
            else if (İndexB >= 35 && İndexB <= 44.9)
            {
                MessageBox.Show($"Şişman. İkinci derece obez olarak tanımlanan bu değerlere sahip olan kişilerde kalp ve damar hastalıkları bakımından risk artar. Kişinin kilo vermek için diyetisyene başvurması önerilir.{İndexB }");
            }
            else if (İndexB > 45)
            {
                MessageBox.Show($"Aşırı Şişman. Üçüncü derece obez kategorisinde olan bu kişilerde hastalık gelişme riski çok yüksektir. Hekim ve diyetisyen eşliğinde kilo verilmesi önerilir.{İndexB}");
            }
            else
            {
                MessageBox.Show("Geçersiz Değer girdiniz");
            }


            TexboxEraser(grpVucudIndexi);
        }
    }
}
