namespace CSharp_Fundamentals
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpHesapMakinesi = new System.Windows.Forms.GroupBox();
            this.cmbDortIslem = new System.Windows.Forms.ComboBox();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.btnHesapMakinesi = new System.Windows.Forms.Button();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGırısYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGirisEkranı = new System.Windows.Forms.GroupBox();
            this.txtRasgeleSayi = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRasgeleSayı = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpSayıTahminOyunu = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBırOyuncuTahmnini = new System.Windows.Forms.TextBox();
            this.txtikiOyuncuTahmini = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpNotHesaplama = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdev = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.btnNotHesapla = new System.Windows.Forms.Button();
            this.grpUsluSayıHesaplama = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaban = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtÜst = new System.Windows.Forms.TextBox();
            this.btnUsluSayıHesapla = new System.Windows.Forms.Button();
            this.grpVucudIndexi = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKılo = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.btnEndexkHesapla = new System.Windows.Forms.Button();
            this.grpHesapMakinesi.SuspendLayout();
            this.grpGirisEkranı.SuspendLayout();
            this.grpSayıTahminOyunu.SuspendLayout();
            this.grpNotHesaplama.SuspendLayout();
            this.grpUsluSayıHesaplama.SuspendLayout();
            this.grpVucudIndexi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHesapMakinesi
            // 
            this.grpHesapMakinesi.Controls.Add(this.cmbDortIslem);
            this.grpHesapMakinesi.Controls.Add(this.txtSayı1);
            this.grpHesapMakinesi.Controls.Add(this.btnHesapMakinesi);
            this.grpHesapMakinesi.Controls.Add(this.txtSayı2);
            this.grpHesapMakinesi.Location = new System.Drawing.Point(13, 13);
            this.grpHesapMakinesi.Name = "grpHesapMakinesi";
            this.grpHesapMakinesi.Size = new System.Drawing.Size(166, 115);
            this.grpHesapMakinesi.TabIndex = 0;
            this.grpHesapMakinesi.TabStop = false;
            this.grpHesapMakinesi.Text = "Hesap Makinesi";
            // 
            // cmbDortIslem
            // 
            this.cmbDortIslem.FormattingEnabled = true;
            this.cmbDortIslem.Location = new System.Drawing.Point(67, 39);
            this.cmbDortIslem.Name = "cmbDortIslem";
            this.cmbDortIslem.Size = new System.Drawing.Size(31, 21);
            this.cmbDortIslem.TabIndex = 4;
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(19, 39);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(41, 20);
            this.txtSayı1.TabIndex = 2;
            // 
            // btnHesapMakinesi
            // 
            this.btnHesapMakinesi.Location = new System.Drawing.Point(56, 81);
            this.btnHesapMakinesi.Name = "btnHesapMakinesi";
            this.btnHesapMakinesi.Size = new System.Drawing.Size(57, 23);
            this.btnHesapMakinesi.TabIndex = 3;
            this.btnHesapMakinesi.Text = "Hesapla";
            this.btnHesapMakinesi.UseVisualStyleBackColor = true;
            this.btnHesapMakinesi.Click += new System.EventHandler(this.btnHesapMakinesi_Click);
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(114, 39);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(41, 20);
            this.txtSayı2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnGırısYap
            // 
            this.btnGırısYap.Location = new System.Drawing.Point(136, 102);
            this.btnGırısYap.Name = "btnGırısYap";
            this.btnGırısYap.Size = new System.Drawing.Size(75, 23);
            this.btnGırısYap.TabIndex = 3;
            this.btnGırısYap.Text = "Giriş Yap";
            this.btnGırısYap.UseVisualStyleBackColor = true;
            this.btnGırısYap.Click += new System.EventHandler(this.btnGırısYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // grpGirisEkranı
            // 
            this.grpGirisEkranı.Controls.Add(this.txtRasgeleSayi);
            this.grpGirisEkranı.Controls.Add(this.txtPasword);
            this.grpGirisEkranı.Controls.Add(this.txtId);
            this.grpGirisEkranı.Controls.Add(this.lblKalanHak);
            this.grpGirisEkranı.Controls.Add(this.label3);
            this.grpGirisEkranı.Controls.Add(this.btnGırısYap);
            this.grpGirisEkranı.Controls.Add(this.label4);
            this.grpGirisEkranı.Controls.Add(this.lblRasgeleSayı);
            this.grpGirisEkranı.Location = new System.Drawing.Point(185, 13);
            this.grpGirisEkranı.Name = "grpGirisEkranı";
            this.grpGirisEkranı.Size = new System.Drawing.Size(312, 131);
            this.grpGirisEkranı.TabIndex = 4;
            this.grpGirisEkranı.TabStop = false;
            this.grpGirisEkranı.Text = "Giriş Ekranı";
            // 
            // txtRasgeleSayi
            // 
            this.txtRasgeleSayi.Location = new System.Drawing.Point(236, 63);
            this.txtRasgeleSayi.Name = "txtRasgeleSayi";
            this.txtRasgeleSayi.Size = new System.Drawing.Size(53, 20);
            this.txtRasgeleSayi.TabIndex = 5;
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(83, 63);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '*';
            this.txtPasword.Size = new System.Drawing.Size(100, 20);
            this.txtPasword.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(7, 107);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(0, 13);
            this.lblKalanHak.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password :";
            // 
            // lblRasgeleSayı
            // 
            this.lblRasgeleSayı.AutoSize = true;
            this.lblRasgeleSayı.Location = new System.Drawing.Point(277, 28);
            this.lblRasgeleSayı.Name = "lblRasgeleSayı";
            this.lblRasgeleSayı.Size = new System.Drawing.Size(0, 13);
            this.lblRasgeleSayı.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(730, 398);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // grpSayıTahminOyunu
            // 
            this.grpSayıTahminOyunu.Controls.Add(this.label6);
            this.grpSayıTahminOyunu.Controls.Add(this.label5);
            this.grpSayıTahminOyunu.Controls.Add(this.txtBırOyuncuTahmnini);
            this.grpSayıTahminOyunu.Controls.Add(this.txtikiOyuncuTahmini);
            this.grpSayıTahminOyunu.Controls.Add(this.button1);
            this.grpSayıTahminOyunu.Location = new System.Drawing.Point(509, 13);
            this.grpSayıTahminOyunu.Name = "grpSayıTahminOyunu";
            this.grpSayıTahminOyunu.Size = new System.Drawing.Size(236, 152);
            this.grpSayıTahminOyunu.TabIndex = 7;
            this.grpSayıTahminOyunu.TabStop = false;
            this.grpSayıTahminOyunu.Text = "Sayı Tahmin Oyunu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "2.Oyuncu Tahmini :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "1.Oyuncu Tahmini :";
            // 
            // txtBırOyuncuTahmnini
            // 
            this.txtBırOyuncuTahmnini.Location = new System.Drawing.Point(127, 31);
            this.txtBırOyuncuTahmnini.Name = "txtBırOyuncuTahmnini";
            this.txtBırOyuncuTahmnini.Size = new System.Drawing.Size(100, 20);
            this.txtBırOyuncuTahmnini.TabIndex = 4;
            // 
            // txtikiOyuncuTahmini
            // 
            this.txtikiOyuncuTahmini.Location = new System.Drawing.Point(127, 63);
            this.txtikiOyuncuTahmini.Name = "txtikiOyuncuTahmini";
            this.txtikiOyuncuTahmini.Size = new System.Drawing.Size(100, 20);
            this.txtikiOyuncuTahmini.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpNotHesaplama
            // 
            this.grpNotHesaplama.Controls.Add(this.label9);
            this.grpNotHesaplama.Controls.Add(this.label8);
            this.grpNotHesaplama.Controls.Add(this.label7);
            this.grpNotHesaplama.Controls.Add(this.txtOdev);
            this.grpNotHesaplama.Controls.Add(this.txtFinal);
            this.grpNotHesaplama.Controls.Add(this.txtVize);
            this.grpNotHesaplama.Controls.Add(this.btnNotHesapla);
            this.grpNotHesaplama.Location = new System.Drawing.Point(5, 134);
            this.grpNotHesaplama.Name = "grpNotHesaplama";
            this.grpNotHesaplama.Size = new System.Drawing.Size(174, 201);
            this.grpNotHesaplama.TabIndex = 9;
            this.grpNotHesaplama.TabStop = false;
            this.grpNotHesaplama.Text = "Not Hesaplama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ödev :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vize : ";
            // 
            // txtOdev
            // 
            this.txtOdev.Location = new System.Drawing.Point(44, 96);
            this.txtOdev.Name = "txtOdev";
            this.txtOdev.Size = new System.Drawing.Size(100, 20);
            this.txtOdev.TabIndex = 4;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(44, 62);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 4;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(44, 33);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 4;
            // 
            // btnNotHesapla
            // 
            this.btnNotHesapla.Location = new System.Drawing.Point(44, 140);
            this.btnNotHesapla.Name = "btnNotHesapla";
            this.btnNotHesapla.Size = new System.Drawing.Size(100, 25);
            this.btnNotHesapla.TabIndex = 1;
            this.btnNotHesapla.Text = "Hesapla";
            this.btnNotHesapla.UseVisualStyleBackColor = true;
            this.btnNotHesapla.Click += new System.EventHandler(this.btnNotHesapla_Click);
            // 
            // grpUsluSayıHesaplama
            // 
            this.grpUsluSayıHesaplama.Controls.Add(this.label12);
            this.grpUsluSayıHesaplama.Controls.Add(this.listBox1);
            this.grpUsluSayıHesaplama.Controls.Add(this.label11);
            this.grpUsluSayıHesaplama.Controls.Add(this.label10);
            this.grpUsluSayıHesaplama.Controls.Add(this.txtTaban);
            this.grpUsluSayıHesaplama.Controls.Add(this.txtCevap);
            this.grpUsluSayıHesaplama.Controls.Add(this.txtÜst);
            this.grpUsluSayıHesaplama.Controls.Add(this.btnUsluSayıHesapla);
            this.grpUsluSayıHesaplama.Location = new System.Drawing.Point(185, 150);
            this.grpUsluSayıHesaplama.Name = "grpUsluSayıHesaplama";
            this.grpUsluSayıHesaplama.Size = new System.Drawing.Size(318, 185);
            this.grpUsluSayıHesaplama.TabIndex = 10;
            this.grpUsluSayıHesaplama.TabStop = false;
            this.grpUsluSayıHesaplama.Text = "Üslü Sayı Hesapla";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Cevap :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Üssü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Taban Sayı :";
            // 
            // txtTaban
            // 
            this.txtTaban.Location = new System.Drawing.Point(77, 29);
            this.txtTaban.Name = "txtTaban";
            this.txtTaban.Size = new System.Drawing.Size(100, 20);
            this.txtTaban.TabIndex = 4;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(40, 102);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(57, 20);
            this.txtCevap.TabIndex = 4;
            // 
            // txtÜst
            // 
            this.txtÜst.Location = new System.Drawing.Point(77, 66);
            this.txtÜst.Name = "txtÜst";
            this.txtÜst.Size = new System.Drawing.Size(100, 20);
            this.txtÜst.TabIndex = 4;
            // 
            // btnUsluSayıHesapla
            // 
            this.btnUsluSayıHesapla.Location = new System.Drawing.Point(122, 140);
            this.btnUsluSayıHesapla.Name = "btnUsluSayıHesapla";
            this.btnUsluSayıHesapla.Size = new System.Drawing.Size(55, 28);
            this.btnUsluSayıHesapla.TabIndex = 1;
            this.btnUsluSayıHesapla.Text = "Hesapla";
            this.btnUsluSayıHesapla.UseVisualStyleBackColor = true;
            this.btnUsluSayıHesapla.Click += new System.EventHandler(this.btnHesapla_2_Click);
            // 
            // grpVucudIndexi
            // 
            this.grpVucudIndexi.Controls.Add(this.label13);
            this.grpVucudIndexi.Controls.Add(this.label14);
            this.grpVucudIndexi.Controls.Add(this.txtKılo);
            this.grpVucudIndexi.Controls.Add(this.txtBoy);
            this.grpVucudIndexi.Controls.Add(this.btnEndexkHesapla);
            this.grpVucudIndexi.Location = new System.Drawing.Point(509, 171);
            this.grpVucudIndexi.Name = "grpVucudIndexi";
            this.grpVucudIndexi.Size = new System.Drawing.Size(236, 164);
            this.grpVucudIndexi.TabIndex = 11;
            this.grpVucudIndexi.TabStop = false;
            this.grpVucudIndexi.Text = "Vücud Endexsi Hesaplama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Boy :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Kilo :";
            // 
            // txtKılo
            // 
            this.txtKılo.Location = new System.Drawing.Point(54, 64);
            this.txtKılo.Name = "txtKılo";
            this.txtKılo.Size = new System.Drawing.Size(100, 20);
            this.txtKılo.TabIndex = 3;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(54, 20);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 20);
            this.txtBoy.TabIndex = 3;
            // 
            // btnEndexkHesapla
            // 
            this.btnEndexkHesapla.Location = new System.Drawing.Point(54, 92);
            this.btnEndexkHesapla.Name = "btnEndexkHesapla";
            this.btnEndexkHesapla.Size = new System.Drawing.Size(84, 24);
            this.btnEndexkHesapla.TabIndex = 1;
            this.btnEndexkHesapla.Text = "Hesapla";
            this.btnEndexkHesapla.UseVisualStyleBackColor = true;
            this.btnEndexkHesapla.Click += new System.EventHandler(this.btnHesapla_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 487);
            this.Controls.Add(this.grpVucudIndexi);
            this.Controls.Add(this.grpUsluSayıHesaplama);
            this.Controls.Add(this.grpNotHesaplama);
            this.Controls.Add(this.grpSayıTahminOyunu);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.grpGirisEkranı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpHesapMakinesi);
            this.Name = "Form1";
            this.Text = "İf Else";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHesapMakinesi.ResumeLayout(false);
            this.grpHesapMakinesi.PerformLayout();
            this.grpGirisEkranı.ResumeLayout(false);
            this.grpGirisEkranı.PerformLayout();
            this.grpSayıTahminOyunu.ResumeLayout(false);
            this.grpSayıTahminOyunu.PerformLayout();
            this.grpNotHesaplama.ResumeLayout(false);
            this.grpNotHesaplama.PerformLayout();
            this.grpUsluSayıHesaplama.ResumeLayout(false);
            this.grpUsluSayıHesaplama.PerformLayout();
            this.grpVucudIndexi.ResumeLayout(false);
            this.grpVucudIndexi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHesapMakinesi;
        private System.Windows.Forms.ComboBox cmbDortIslem;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.Button btnHesapMakinesi;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGırısYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGirisEkranı;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRasgeleSayı;
        private System.Windows.Forms.TextBox txtRasgeleSayi;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.GroupBox grpSayıTahminOyunu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBırOyuncuTahmnini;
        private System.Windows.Forms.TextBox txtikiOyuncuTahmini;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpNotHesaplama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdev;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Button btnNotHesapla;
        private System.Windows.Forms.GroupBox grpUsluSayıHesaplama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaban;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtÜst;
        private System.Windows.Forms.Button btnUsluSayıHesapla;
        private System.Windows.Forms.GroupBox grpVucudIndexi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKılo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Button btnEndexkHesapla;
    }
}

