using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swictch_Case_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Switch-Case
        //If-Else mantığıyla çalışan bir kontrol mekanizmasıdır. Aradaki fark ise if-else yapısı büyüklük ve küçüklük gibi durumları kontrole ederken, switch-case yanlızca eşitlk durumunu kontrol eder. Switch-case kendisine has bir index yani sıralama mekanizması vardır. Bu mekanizmada şartları çok hzılı bir şeklde kontrol eder ve buludğunda diğer şartlara bakmaz. Bu index mantığı yüzünden if else'den daha hızlı çalışır. Index mekanizması kitabın içindekiler bölümü gibi düşünülebilinir. Örneğin 1050 sayfalık Napoleaon A War kitabın konusu olan Borodino savaşını okumak istediniz. Bu konuya ulaşmak için sayfa sayfa doşalmak zorunda olduğunuz senaryo if-else mantığına örnek olarak verilir. If-else yaptığımız örnekleri debug ederken gördüğünüz gibi şart bulunana kadar bütün if bloklarına break point uğramıştı. Index mantığında ise kitabun içindekiler bölümünden ilgii konuyu bularak çat diye 780 sayfaya giderek konuya erişebilirsiniz buda switch-case mantığıdır. Bu index mantığı SQL Server'da bulunmaktadır. "switch-case" mantığında her bir "case" için "break" kullanmamız gerekmektedir. "default" ise if-else bloğundaki "else" benzemektedir.

        public void TextBoxErsear(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnGün_Click(object sender, EventArgs e)
        {
            // Kulanıcıdan gelen haftanın kaçıncı günü olduğu bilgisiyle hangi gün olduğu bakalım.
            int Gun = Convert.ToInt32(txtGün.Text);

            switch (Gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi Haftanın ilk günü");
                    break;
                case 2:
                    MessageBox.Show("Salı Haftanın ikinci günü");
                    break;
                case 3:
                    MessageBox.Show("Çarşamba Haftanın üçüncü günü");
                    break;
                case 4:
                    MessageBox.Show("Perşembe dördüncü günü");
                    break;
                case 5:
                    MessageBox.Show("Cuma Mubarek gün");
                    break;
                case 6:
                    MessageBox.Show("Hafta sonu Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Hafta sonu Pazar");
                    break;
            }
            TextBoxErsear(grpHaftanınGunleri);
        }

        private void btnGırısYap_Click(object sender, EventArgs e)
        {
            //İç içe switch-case
            //Id: 5150 
            //passwaord: 1010
            //Sadece 18 yaşından büyük  üyeler alınır..
            string Id = txtKullanıcı.Text;
            string Pasword = txtPasword.Text;
            DateTime date = Convert.ToDateTime(msktxtDogumTarihi.Text);

            int Yas = DateTime.Now.Year - date.Year;

            //string yas = date.ToString("yyyy");
            //int yasH = Convert.ToInt32(yas);
            //int yaş = DateTime.Now.Year - yasH;
            if (Yas > 18)
            {
                switch (Id)
                {
                    case "5150":
                        switch (Pasword)
                        {
                            case "1010":
                                MessageBox.Show("Başarıyla giriş Yapılmıştır.....!");
                                break;
                            default:

                                MessageBox.Show("şİFRE hATALI..!!!!");
                                break;
                        }
                        break;
                    default:

                        MessageBox.Show($"Id hatalı.......!!1");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Yaşınız istenilenden küçüktür.");
            }
           
        }

        private void btnGetır_Click(object sender, EventArgs e)
        {
            //Hangi mevsim ayları konrol edelim 
            string message;
            switch (txtMevsim.Text.ToLower())
            {
                case "kış":
                    message = "Aralık-Ocak-Şubat";
                    break;
                case "ilkbahar":
                    message = "Mart-Nisan-Mayıs";
                    break;
                case "yaz":
                    message = "Haziran-Temmuz-Ağustos";
                    break;
                case "sonbahar":
                    message = "Eylül-Ekim-Kasım";
                    break;
                default:
                    message = "Böyle bir mevsim yok..!";
                    break;
            }

            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

