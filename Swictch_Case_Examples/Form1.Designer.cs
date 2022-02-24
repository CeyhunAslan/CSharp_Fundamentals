namespace Swictch_Case_Examples
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
            this.grpHaftanınGunleri = new System.Windows.Forms.GroupBox();
            this.btnGün = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.grpGirisEkranı = new System.Windows.Forms.GroupBox();
            this.msktxtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGırısYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetır = new System.Windows.Forms.Button();
            this.txtMevsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpHaftanınGunleri.SuspendLayout();
            this.grpGirisEkranı.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHaftanınGunleri
            // 
            this.grpHaftanınGunleri.Controls.Add(this.btnGün);
            this.grpHaftanınGunleri.Controls.Add(this.label1);
            this.grpHaftanınGunleri.Controls.Add(this.txtGün);
            this.grpHaftanınGunleri.Location = new System.Drawing.Point(12, 12);
            this.grpHaftanınGunleri.Name = "grpHaftanınGunleri";
            this.grpHaftanınGunleri.Size = new System.Drawing.Size(167, 89);
            this.grpHaftanınGunleri.TabIndex = 1;
            this.grpHaftanınGunleri.TabStop = false;
            this.grpHaftanınGunleri.Text = "Haftanın Hangi Günü";
            // 
            // btnGün
            // 
            this.btnGün.Location = new System.Drawing.Point(72, 45);
            this.btnGün.Name = "btnGün";
            this.btnGün.Size = new System.Drawing.Size(75, 23);
            this.btnGün.TabIndex = 2;
            this.btnGün.Text = "Getir";
            this.btnGün.UseVisualStyleBackColor = true;
            this.btnGün.Click += new System.EventHandler(this.btnGün_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaçıncı Gün :";
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(89, 19);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(58, 20);
            this.txtGün.TabIndex = 0;
            // 
            // grpGirisEkranı
            // 
            this.grpGirisEkranı.Controls.Add(this.msktxtDogumTarihi);
            this.grpGirisEkranı.Controls.Add(this.label4);
            this.grpGirisEkranı.Controls.Add(this.btnGırısYap);
            this.grpGirisEkranı.Controls.Add(this.label3);
            this.grpGirisEkranı.Controls.Add(this.label2);
            this.grpGirisEkranı.Controls.Add(this.txtPasword);
            this.grpGirisEkranı.Controls.Add(this.txtKullanıcı);
            this.grpGirisEkranı.Location = new System.Drawing.Point(194, 12);
            this.grpGirisEkranı.Name = "grpGirisEkranı";
            this.grpGirisEkranı.Size = new System.Drawing.Size(285, 117);
            this.grpGirisEkranı.TabIndex = 2;
            this.grpGirisEkranı.TabStop = false;
            this.grpGirisEkranı.Text = "Giriş Ekranı";
            // 
            // msktxtDogumTarihi
            // 
            this.msktxtDogumTarihi.Location = new System.Drawing.Point(122, 95);
            this.msktxtDogumTarihi.Mask = "00/00/0000";
            this.msktxtDogumTarihi.Name = "msktxtDogumTarihi";
            this.msktxtDogumTarihi.Size = new System.Drawing.Size(69, 20);
            this.msktxtDogumTarihi.TabIndex = 4;
            this.msktxtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // btnGırısYap
            // 
            this.btnGırısYap.Location = new System.Drawing.Point(190, 19);
            this.btnGırısYap.Name = "btnGırısYap";
            this.btnGırısYap.Size = new System.Drawing.Size(75, 56);
            this.btnGırısYap.TabIndex = 2;
            this.btnGırısYap.Text = "Giriş Yap";
            this.btnGırısYap.UseVisualStyleBackColor = true;
            this.btnGırısYap.Click += new System.EventHandler(this.btnGırısYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı :";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(71, 55);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '*';
            this.txtPasword.Size = new System.Drawing.Size(100, 20);
            this.txtPasword.TabIndex = 0;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(71, 19);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcı.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetır);
            this.groupBox3.Controls.Add(this.txtMevsim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(498, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 116);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevsimler";
            // 
            // btnGetır
            // 
            this.btnGetır.Location = new System.Drawing.Point(79, 75);
            this.btnGetır.Name = "btnGetır";
            this.btnGetır.Size = new System.Drawing.Size(75, 23);
            this.btnGetır.TabIndex = 2;
            this.btnGetır.Text = "Getir";
            this.btnGetır.UseVisualStyleBackColor = true;
            this.btnGetır.Click += new System.EventHandler(this.btnGetır_Click);
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(79, 33);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(100, 20);
            this.txtMevsim.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mevsim :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpGirisEkranı);
            this.Controls.Add(this.grpHaftanınGunleri);
            this.Name = "Form1";
            this.Text = "Swictch Case";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHaftanınGunleri.ResumeLayout(false);
            this.grpHaftanınGunleri.PerformLayout();
            this.grpGirisEkranı.ResumeLayout(false);
            this.grpGirisEkranı.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHaftanınGunleri;
        private System.Windows.Forms.Button btnGün;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.GroupBox grpGirisEkranı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGırısYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.MaskedTextBox msktxtDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetır;
        private System.Windows.Forms.TextBox txtMevsim;
        private System.Windows.Forms.Label label5;
    }
}

