﻿namespace While_Examples
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
            this.btnExample_3 = new System.Windows.Forms.Button();
            this.btnExample_2 = new System.Windows.Forms.Button();
            this.btnExample_1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExample_3
            // 
            this.btnExample_3.Location = new System.Drawing.Point(12, 90);
            this.btnExample_3.Name = "btnExample_3";
            this.btnExample_3.Size = new System.Drawing.Size(75, 23);
            this.btnExample_3.TabIndex = 7;
            this.btnExample_3.Text = "Example 3";
            this.btnExample_3.UseVisualStyleBackColor = true;
            this.btnExample_3.Click += new System.EventHandler(this.btnExample_3_Click);
            // 
            // btnExample_2
            // 
            this.btnExample_2.Location = new System.Drawing.Point(12, 50);
            this.btnExample_2.Name = "btnExample_2";
            this.btnExample_2.Size = new System.Drawing.Size(75, 23);
            this.btnExample_2.TabIndex = 6;
            this.btnExample_2.Text = "Example 2";
            this.btnExample_2.UseVisualStyleBackColor = true;
            this.btnExample_2.Click += new System.EventHandler(this.btnExample_2_Click);
            // 
            // btnExample_1
            // 
            this.btnExample_1.Location = new System.Drawing.Point(12, 12);
            this.btnExample_1.Name = "btnExample_1";
            this.btnExample_1.Size = new System.Drawing.Size(75, 23);
            this.btnExample_1.TabIndex = 5;
            this.btnExample_1.Text = "Example 1";
            this.btnExample_1.UseVisualStyleBackColor = true;
            this.btnExample_1.Click += new System.EventHandler(this.btnExample_1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(140, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExample_3);
            this.Controls.Add(this.btnExample_2);
            this.Controls.Add(this.btnExample_1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExample_3;
        private System.Windows.Forms.Button btnExample_2;
        private System.Windows.Forms.Button btnExample_1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

