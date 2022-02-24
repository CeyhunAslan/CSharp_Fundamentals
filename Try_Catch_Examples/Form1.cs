using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Try Catch----
        //İstani Durumları Ele Alma (Exception Handling)
        //İstisna Tipleri
        //1. Çalışma Zamanı Hatalar (Runtime Exception): Çoğunlukla kullanıcı kaynaklı hatalardır. Verilerin yanlış yada eksik girilmesi gibi. Çözüm yolu try-catch'tir.
        //2. Derleme Zamanı Hataları (Compile Error) : Tamamen yazılımcı kayaklı hatalardır. Yazım hatalrı meydane geldiğinde devreye girer. EN kolya çözülen hata tipidir. Zaten daha kodu yazarken kurban olduğum visual studio bizi uyarır. Ayrıca hatalar Error List'te anlık olarak düşer ordan hata kodu ile inceleyebiliriz. Web'den bakabiliriz.
        //3. Mantıksal Hatalar (Logic Error): Tamamen yazılımcı kaynaklı hatalardır. Uygulamanın algoritmasında meydana gelir. Orneğin bolme yapılacak yerde işlemin unutlması değerin yanlış bir değer ile değiştirilmesi. Çözülmesi en zor hatalardır. Anlık olarak derleme asamasında takip edilmelidirler. Bu konuda visual studio'nun bize sağladı "Breakpoint" özelliği ile bu hatalar handle edilir.
        private void btnExample_1_Click(object sender, EventArgs e)
        {
            try
            {
                //Hata beklediğimiz kodları "try" bloğu içerisine yazıyoruz. Şayet herhangi bir sebepten ötürü burada bir istisnai durum (exception) oluşursa, uygulama artık exception fırlatmak yerine "Catch" bloğuna düşecektir. 
                int yas = Convert.ToInt32(txtYas.Text);
                MessageBox.Show($"Yaşınız: {yas}");
            }
            catch (Exception ex)
            {
                //Try bloğunda bulunan kodlarda her hangi bir hata alınırsa bu blok otomatik olarak devreye girecek.
                MessageBox.Show("Bir yaşını bile giremedin.."); //Kullanıcıya gösterilecek hata mesajı.
                //Kendimizin anlayacağı hata mesajı
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Ne olursa olsun "finally" bloğu çalışır. Hata olsada olmasada çalışacak bloktur.
                MessageBox.Show("Try bloğu sağlıklı çalışsada çalışmasada ben devreye girerim..!");
            }

        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            try
            {
                int yas = Convert.ToInt32(txtYas.Text);
            }
            catch (FormatException ex) //format hata tipi
            {
                MessageBox.Show($"Format Exception: {ex.Message}");
            }
            catch (DivideByZeroException ex) // sıfıra bölünemem hatası
            {
                MessageBox.Show($"Divided By Zero Exception: {ex.Message}");
            }
            catch (OverflowException ex) // veri tipinin boyutunu aşması durumunda kullanılır
            {
                MessageBox.Show($"Over Flow Exception: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
