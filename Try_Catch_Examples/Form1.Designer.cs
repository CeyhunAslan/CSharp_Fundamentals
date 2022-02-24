namespace Try_Catch_Examples
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.btnExample_2 = new System.Windows.Forms.Button();
            this.btnExample_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yas:";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(237, 191);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(142, 20);
            this.txtYas.TabIndex = 6;
            // 
            // btnExample_2
            // 
            this.btnExample_2.Location = new System.Drawing.Point(439, 191);
            this.btnExample_2.Name = "btnExample_2";
            this.btnExample_2.Size = new System.Drawing.Size(175, 68);
            this.btnExample_2.TabIndex = 5;
            this.btnExample_2.Text = "Exception Types";
            this.btnExample_2.UseVisualStyleBackColor = true;
            this.btnExample_2.Click += new System.EventHandler(this.btnExample_2_Click);
            // 
            // btnExample_1
            // 
            this.btnExample_1.Location = new System.Drawing.Point(237, 223);
            this.btnExample_1.Name = "btnExample_1";
            this.btnExample_1.Size = new System.Drawing.Size(142, 36);
            this.btnExample_1.TabIndex = 4;
            this.btnExample_1.Text = "Example 1";
            this.btnExample_1.UseVisualStyleBackColor = true;
            this.btnExample_1.Click += new System.EventHandler(this.btnExample_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.btnExample_2);
            this.Controls.Add(this.btnExample_1);
            this.Name = "Form1";
            this.Text = "Try Catch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Button btnExample_2;
        private System.Windows.Forms.Button btnExample_1;
    }
}

