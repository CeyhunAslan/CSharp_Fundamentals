namespace Void_Methods_Examples
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaydırıcı = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnComputerName = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnCatchText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 394);
            this.listBox1.TabIndex = 0;
            // 
            // btnSaydırıcı
            // 
            this.btnSaydırıcı.Location = new System.Drawing.Point(179, 12);
            this.btnSaydırıcı.Name = "btnSaydırıcı";
            this.btnSaydırıcı.Size = new System.Drawing.Size(75, 53);
            this.btnSaydırıcı.TabIndex = 1;
            this.btnSaydırıcı.Text = "Birden Yüze Saydır";
            this.btnSaydırıcı.UseVisualStyleBackColor = true;
            this.btnSaydırıcı.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(179, 72);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 46);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.Text = "BackColor";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(179, 124);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(75, 46);
            this.btnRenk.TabIndex = 3;
            this.btnRenk.Text = "Button Renklendir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnComputerName
            // 
            this.btnComputerName.Location = new System.Drawing.Point(179, 176);
            this.btnComputerName.Name = "btnComputerName";
            this.btnComputerName.Size = new System.Drawing.Size(75, 46);
            this.btnComputerName.TabIndex = 3;
            this.btnComputerName.Text = "PC Name";
            this.btnComputerName.UseVisualStyleBackColor = true;
            this.btnComputerName.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(179, 228);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 46);
            this.btnIP.TabIndex = 3;
            this.btnIP.Text = "IP";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnCatchText
            // 
            this.btnCatchText.Location = new System.Drawing.Point(179, 280);
            this.btnCatchText.Name = "btnCatchText";
            this.btnCatchText.Size = new System.Drawing.Size(75, 46);
            this.btnCatchText.TabIndex = 3;
            this.btnCatchText.Text = "Button Text Yakala";
            this.btnCatchText.UseVisualStyleBackColor = true;
            this.btnCatchText.Click += new System.EventHandler(this.btnCatchText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnComputerName);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnCatchText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnSaydırıcı);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Void Methods";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaydırıcı;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnComputerName;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnCatchText;
    }
}

