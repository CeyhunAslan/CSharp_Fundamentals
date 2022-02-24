namespace For_Examples
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
            this.btnExamples_5 = new System.Windows.Forms.Button();
            this.btnExamples_4 = new System.Windows.Forms.Button();
            this.btnExamples_3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnExamples_2 = new System.Windows.Forms.Button();
            this.btnExamples_1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExamples_5
            // 
            this.btnExamples_5.Location = new System.Drawing.Point(189, 222);
            this.btnExamples_5.Name = "btnExamples_5";
            this.btnExamples_5.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_5.TabIndex = 13;
            this.btnExamples_5.Text = "Examples 5";
            this.btnExamples_5.UseVisualStyleBackColor = true;
            this.btnExamples_5.Click += new System.EventHandler(this.btnExamples_5_Click);
            // 
            // btnExamples_4
            // 
            this.btnExamples_4.Location = new System.Drawing.Point(189, 193);
            this.btnExamples_4.Name = "btnExamples_4";
            this.btnExamples_4.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_4.TabIndex = 12;
            this.btnExamples_4.Text = "Examples 4";
            this.btnExamples_4.UseVisualStyleBackColor = true;
            this.btnExamples_4.Click += new System.EventHandler(this.btnExamples_4_Click);
            // 
            // btnExamples_3
            // 
            this.btnExamples_3.Location = new System.Drawing.Point(189, 164);
            this.btnExamples_3.Name = "btnExamples_3";
            this.btnExamples_3.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_3.TabIndex = 11;
            this.btnExamples_3.Text = "Examples 3";
            this.btnExamples_3.UseVisualStyleBackColor = true;
            this.btnExamples_3.Click += new System.EventHandler(this.btnExamples_3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(437, 107);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 212);
            this.listBox2.TabIndex = 10;
            // 
            // btnExamples_2
            // 
            this.btnExamples_2.Location = new System.Drawing.Point(189, 135);
            this.btnExamples_2.Name = "btnExamples_2";
            this.btnExamples_2.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_2.TabIndex = 9;
            this.btnExamples_2.Text = "Examples 2";
            this.btnExamples_2.UseVisualStyleBackColor = true;
            this.btnExamples_2.Click += new System.EventHandler(this.btnExamples_2_Click);
            // 
            // btnExamples_1
            // 
            this.btnExamples_1.Location = new System.Drawing.Point(189, 106);
            this.btnExamples_1.Name = "btnExamples_1";
            this.btnExamples_1.Size = new System.Drawing.Size(75, 23);
            this.btnExamples_1.TabIndex = 8;
            this.btnExamples_1.Text = "Example 1";
            this.btnExamples_1.UseVisualStyleBackColor = true;
            this.btnExamples_1.Click += new System.EventHandler(this.btnExamples_1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(310, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExamples_5);
            this.Controls.Add(this.btnExamples_4);
            this.Controls.Add(this.btnExamples_3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnExamples_2);
            this.Controls.Add(this.btnExamples_1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "For";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExamples_5;
        private System.Windows.Forms.Button btnExamples_4;
        private System.Windows.Forms.Button btnExamples_3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnExamples_2;
        private System.Windows.Forms.Button btnExamples_1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

