namespace Foreach_Examples
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
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.btnExamples_2 = new System.Windows.Forms.Button();
            this.btnExamples_1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(344, 103);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(65, 20);
            this.txtKitap.TabIndex = 6;
            // 
            // btnExamples_2
            // 
            this.btnExamples_2.Location = new System.Drawing.Point(250, 142);
            this.btnExamples_2.Name = "btnExamples_2";
            this.btnExamples_2.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_2.TabIndex = 4;
            this.btnExamples_2.Text = "Examples 2";
            this.btnExamples_2.UseVisualStyleBackColor = true;
            this.btnExamples_2.Click += new System.EventHandler(this.btnExamples_2_Click);
            // 
            // btnExamples_1
            // 
            this.btnExamples_1.Location = new System.Drawing.Point(250, 100);
            this.btnExamples_1.Name = "btnExamples_1";
            this.btnExamples_1.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_1.TabIndex = 5;
            this.btnExamples_1.Text = "Examples 1";
            this.btnExamples_1.UseVisualStyleBackColor = true;
            this.btnExamples_1.Click += new System.EventHandler(this.btnExamples_1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(431, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.btnExamples_2);
            this.Controls.Add(this.btnExamples_1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Foreach";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitap;
        private System.Windows.Forms.Button btnExamples_2;
        private System.Windows.Forms.Button btnExamples_1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

