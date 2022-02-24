namespace BuiltIn_String_Functions_Examples
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSubString = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtVeri2 = new System.Windows.Forms.TextBox();
            this.txtVeri1 = new System.Windows.Forms.TextBox();
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(277, 155);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(197, 54);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSubString
            // 
            this.btnSubString.Location = new System.Drawing.Point(277, 215);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(197, 54);
            this.btnSubString.TabIndex = 19;
            this.btnSubString.Text = "Substring";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(277, 275);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(197, 54);
            this.btnTrim.TabIndex = 18;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(277, 335);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(197, 54);
            this.btnToUpper.TabIndex = 17;
            this.btnToUpper.Text = "Upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(277, 395);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(197, 54);
            this.btnToLower.TabIndex = 16;
            this.btnToLower.Text = "Lower";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(480, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 433);
            this.listBox1.TabIndex = 15;
            // 
            // txtVeri2
            // 
            this.txtVeri2.Location = new System.Drawing.Point(277, 9);
            this.txtVeri2.Name = "txtVeri2";
            this.txtVeri2.Size = new System.Drawing.Size(197, 20);
            this.txtVeri2.TabIndex = 13;
            // 
            // txtVeri1
            // 
            this.txtVeri1.Location = new System.Drawing.Point(74, 9);
            this.txtVeri1.Name = "txtVeri1";
            this.txtVeri1.Size = new System.Drawing.Size(197, 20);
            this.txtVeri1.TabIndex = 14;
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.Location = new System.Drawing.Point(74, 35);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(197, 54);
            this.btnCompareTo.TabIndex = 4;
            this.btnCompareTo.Text = "Compare To";
            this.btnCompareTo.UseVisualStyleBackColor = true;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(74, 95);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(197, 54);
            this.btnContains.TabIndex = 10;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(74, 155);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(197, 54);
            this.btnStartWith.TabIndex = 9;
            this.btnStartWith.Text = "Start With";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(74, 215);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(197, 54);
            this.btnEndsWith.TabIndex = 8;
            this.btnEndsWith.Text = "Ends With";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(74, 275);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(197, 54);
            this.btnIndexOf.TabIndex = 7;
            this.btnIndexOf.Text = "Index Of";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(74, 335);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(197, 54);
            this.btnLastIndexOf.TabIndex = 6;
            this.btnLastIndexOf.Text = "Last Index Of";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(74, 395);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(197, 54);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(277, 35);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(197, 54);
            this.btnReplace.TabIndex = 11;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(277, 95);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(197, 54);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "Siplit";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSubString);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtVeri2);
            this.Controls.Add(this.txtVeri1);
            this.Controls.Add(this.btnCompareTo);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSplit);
            this.Name = "Form1";
            this.Text = "BuiltIn String Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtVeri2;
        private System.Windows.Forms.TextBox txtVeri1;
        private System.Windows.Forms.Button btnCompareTo;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplit;
    }
}

