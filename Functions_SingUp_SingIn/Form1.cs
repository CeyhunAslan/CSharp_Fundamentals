using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_SingUp_SingIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GeneratedCaptcha()
        {
            string captcha = Guid.NewGuid().ToString();//Üretilen Guid üzerinde string fonksiyonları uygulayacağımızdan ötürü üretile Guid string'e dönüştürülerek string tipindeki "captcha" adındaki değişkene atandı.
            string[] splitedCaptcha = captcha.Split('-');
            return splitedCaptcha[1].ToString();
        }

        //Fonksiyon yazmamızdaki amaç tek elden yönetim ve kod kalabalıklığını engellemek olduğundan bu fonksiyonuma GroupBox tipinde bir parametre verdik, böylelikle uygulamamızda ne kadar groupbox onlar için bu fonksiyonu kullanabiliriz.
        bool Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
            return true;
        }

        //Dictionary => Array, list gibi geçici olarak veri tutabileceğimiz bir collection türüdür. Aynı array ve liste olduğu gibi ilk yaratılırken içerisine atanan değerle yaratılır. Daha sonra üzerine yazılan değerleri uygulama çalıştığı sürece tutar. Uygulama kapatıldığında RAM'den kaldırılır.
        Dictionary<string, string> users = new Dictionary<string, string>();







        bool SignUp(string userName, string password)
        {
            //textbox'lardan gelen değerleri karşıladığımız parametrelerimiz boş ise if bloğu çalışacak ve fonksiyon bize false dönecek. false yada true dönmesi halinde "btnSignUp_Click" event'inde başka senaryolar çalışacatır.
            if (userName == "" && password == "")
            {
                return false;
            }
            else
            {
                users.Add(userName, password);//burada gelen değerler dolu ise sözlüğümüze ekledik
                return true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grpSignIn.Visible = false;
            lblCaptcha.Text = GeneratedCaptcha();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            //SignUp fonksiyonu textbox'lardan gelen bilgileri alarak çalışacak. fonsksiyonun içerisini incelediğinizde şayet gelen değerler boş ise bize false, dolu ise true dönecektir.
            bool result = SignUp(txtUserName.Text, txtPassword.Text);
            //şayet SignUp true dönerse yukarıdaki result değişkeni true doalcak ve if bloğu devreye girecek. şayet false dönerse MessageBox çalışacak.
            if (result == true)
            {
                grpSignIn.Visible = true;
                Eraser(grpSignUp);
            }
            else
            {
                MessageBox.Show("Lütfen bilgilernizi giriniz..!");
            }
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            //Dictionary sınıfının içerisinde gömülü olarak bulunan ContainsKey() ve value methodları ile dictionary bir değere sahip mi değil mi diye bakabiliriz
            if (users.ContainsKey(txtSigInUserName.Text) && users.ContainsValue(txtSigInPassword.Text) && txtCaptcha.Text == lblCaptcha.Text)
            {
                MessageBox.Show("Admin sayfasına yönlendiriliyorsunuz..!");
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileriniz yanlış..!");
            }
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                MessageBox.Show($"User Name: {users.ElementAt(i).Key}\nPassword: {users.ElementAt(i).Value}");
            }
        }
    }
}
