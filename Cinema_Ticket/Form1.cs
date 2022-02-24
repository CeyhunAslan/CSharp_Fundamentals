using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1.Kullanıcı özlük bilgilerini girdikten sonra aktif koltukları görecek. Lakin özlük bilgilerinde herhangi bir eksiklik olmaması gerekmektedir ki  aktif koltukları görebilsin. Kullanıcı koltukları gör butonuna bastıktan sonra ihtiyacınıza göre kullanıcının adını ve soyadını depolayın.
        //2.RunTime'da üretilen button'lara click evet'i atanması lazım ki kullanıcı koltukları click yardımıyla seçebilsin.
        //3.Satın alınan koltuk rengi hem kırmızı hemde pasife çekilecek ki tıklanamasın.
        //4. Koltuk seçme işlemi bitince, next butonu olsun ve ödeme sekmeksi açılsın. koltuk sekmesi kapansın. Ödeme sekmesinde bulunan "lblUser" etketi içerisin kullanıcının full name'ni basın.
        //5.SAtın alınan koltuk sayısına göre "payment" sekmesine total tutar yazılacak. (Koltuk 50 tl)
        //6.Payment butonu tıklandığında ShowDialogResult kullanarak kullanıya confirm yaptıralım. Fatura özeti zorla gösterelim. kullanıcın tüm işleri bitince payment sekmesini kapatalım. özlük bilgileir sekmesi açılsın ki bir sonraki kullanıcı rahat rahat ilemine devam etsin.


        void Eraser(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is MaskedTextBox)
                {
                    control.Text = String.Empty;
                }
                else if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                else if (control is RadioButton)
                {
                    rdnWoman.Checked = true;
                }
                else if (control is Label)
                {
                    if (control.Name == "lblUser")
                    {
                        control.Text = String.Empty;
                    }

                    if (control.Name == "lblTotal")
                    {
                        control.Text = String.Empty;
                    }
                }
            }
        }

        Button btn;
        int countChairs = 1;
        List<Button> buttons = new List<Button>();
        void CreateChair()
        {
            for (int satir = 0; satir < 5; satir++)
            {
                for (int sutun = 0; sutun < 10; sutun++)
                {
                    btn = new Button();
                    btn.Name = $"btn_{countChairs}";
                    btn.Text = countChairs.ToString();
                    btn.Height = 40;
                    btn.Width = 40;
                    btn.Location = new Point(40, 40);
                    btn.Left += btn.Width * sutun;
                    btn.Top += btn.Height * satir;
                    btn.BackColor = Color.Green;
                    grpChairs.Controls.Add(btn);
                    buttons.Add(btn);
                    countChairs++;
                }
            }
        }


        private void btnSeeChair_Click(object sender, EventArgs e)
        {
            lblUser.Text = txtFirstName.Text + ' ' + txtLastName.Text;
            Eraser(grpUserInfo);
            grpChairs.Visible = true;
            grpUserInfo.Visible = false;
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button yakalanan = (Button)sender;

            total += 50;

            yakalanan.BackColor = Color.Red;
            yakalanan.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChair();

            foreach (Button btn in buttons)
            {
                btn.Click += new EventHandler(btn_click);
            }
        }

        int total = 0;

        //private void btn_click(object sender, EventArgs e)
        //{
        //    Button yakalanan = (Button)sender;

        //    total += 50;

        //    yakalanan.BackColor = Color.Red;
        //    yakalanan.Enabled = false;
        //}

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    grpPayment.Visible = true;
        //    grpChairs.Visible = false;

        //    lblTotal.Text = $"{total} TL";
        //}

        //private void btnPayment_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrWhiteSpace(mskExpireDate.Text) || String.IsNullOrWhiteSpace(mskCardNumber.Text) || String.IsNullOrWhiteSpace(mskCVS.Text))
        //    {
        //        MessageBox.Show("Lüten bilgileri eksiksiz doldurun..!");
        //    }
        //    else if (mskCardNumber.Text.Length < 19 || mskCVS.Text.Length < 3 || mskExpireDate.Text.Length < 5)
        //    {
        //        MessageBox.Show("Lüten bilgileri eksiksiz doldurun..!");
        //    }
        //    else
        //    {
        //        DialogResult dr = MessageBox.Show("Ödeme işlemi tamamlansın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (dr == DialogResult.No)
        //        {
        //            MessageBox.Show("İşlem iptal edildi..!");
        //            Eraser(grpPayment);
        //            grpPayment.Visible = false;
        //            grpUserInfo.Visible = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Fatura Özeti..!");
        //            Eraser(grpPayment);
        //            grpPayment.Visible = false;
        //            grpUserInfo.Visible = true;
        //        }
        //    }


        //}

        private void btnSeeChair_Click_1(object sender, EventArgs e)
        {
            lblUser.Text = txtFirstName.Text + ' ' + txtLastName.Text;
            Eraser(grpUserInfo);
            grpChairs.Visible = true;
            grpUserInfo.Visible = false;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            grpPayment.Visible = true;
            grpChairs.Visible = false;

            lblTotal.Text = $"{total} TL";
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(mskExpireDate.Text) || String.IsNullOrWhiteSpace(mskCardNumber.Text) || String.IsNullOrWhiteSpace(mskCVS.Text))
            {
                MessageBox.Show("Lüten bilgileri eksiksiz doldurun..!");
            }
            else if (mskCardNumber.Text.Length < 19 || mskCVS.Text.Length < 3 || mskExpireDate.Text.Length < 5)
            {
                MessageBox.Show("Lüten bilgileri eksiksiz doldurun..!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Ödeme işlemi tamamlansın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No)
                {
                    MessageBox.Show("İşlem iptal edildi..!");
                    Eraser(grpPayment);
                    grpPayment.Visible = false;
                    grpUserInfo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Fatura Özeti..!");
                    Eraser(grpPayment);
                    grpPayment.Visible = false;
                    grpUserInfo.Visible = true;
                }
            }
        }
    }
}

