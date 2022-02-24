namespace BuiltIn_Functions_Math_Examples
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
            this.txtVeriGirisi_1 = new System.Windows.Forms.TextBox();
            this.btnABS = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnCelling = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVeriGirisi_1
            // 
            this.txtVeriGirisi_1.Location = new System.Drawing.Point(219, 119);
            this.txtVeriGirisi_1.Name = "txtVeriGirisi_1";
            this.txtVeriGirisi_1.Size = new System.Drawing.Size(362, 20);
            this.txtVeriGirisi_1.TabIndex = 11;
            // 
            // btnABS
            // 
            this.btnABS.Location = new System.Drawing.Point(221, 204);
            this.btnABS.Margin = new System.Windows.Forms.Padding(5);
            this.btnABS.Name = "btnABS";
            this.btnABS.Size = new System.Drawing.Size(83, 35);
            this.btnABS.TabIndex = 4;
            this.btnABS.Text = "ABS";
            this.btnABS.UseVisualStyleBackColor = true;
            this.btnABS.Click += new System.EventHandler(this.btnABS_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(407, 159);
            this.btnFloor.Margin = new System.Windows.Forms.Padding(5);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(83, 35);
            this.btnFloor.TabIndex = 5;
            this.btnFloor.Text = "Floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnCelling
            // 
            this.btnCelling.Location = new System.Drawing.Point(407, 204);
            this.btnCelling.Margin = new System.Windows.Forms.Padding(5);
            this.btnCelling.Name = "btnCelling";
            this.btnCelling.Size = new System.Drawing.Size(83, 38);
            this.btnCelling.TabIndex = 6;
            this.btnCelling.Text = "Celling";
            this.btnCelling.UseVisualStyleBackColor = true;
            this.btnCelling.Click += new System.EventHandler(this.btnCelling_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(314, 159);
            this.btnRound.Margin = new System.Windows.Forms.Padding(5);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(83, 35);
            this.btnRound.TabIndex = 7;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Location = new System.Drawing.Point(314, 204);
            this.btnTruncate.Margin = new System.Windows.Forms.Padding(5);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(83, 35);
            this.btnTruncate.TabIndex = 8;
            this.btnTruncate.Text = "Trancate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(500, 159);
            this.btnPow.Margin = new System.Windows.Forms.Padding(5);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(83, 35);
            this.btnPow.TabIndex = 9;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSQRT
            // 
            this.btnSQRT.Location = new System.Drawing.Point(500, 204);
            this.btnSQRT.Margin = new System.Windows.Forms.Padding(5);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(83, 35);
            this.btnSQRT.TabIndex = 10;
            this.btnSQRT.Text = "SQRT";
            this.btnSQRT.UseVisualStyleBackColor = true;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(221, 159);
            this.btnPi.Margin = new System.Windows.Forms.Padding(5);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(83, 35);
            this.btnPi.TabIndex = 3;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVeriGirisi_1);
            this.Controls.Add(this.btnABS);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnCelling);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "BuiltIn Functions Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVeriGirisi_1;
        private System.Windows.Forms.Button btnABS;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnCelling;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnPi;
    }
}

