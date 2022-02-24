namespace Cinema_Ticket
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
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.mskCVS = new System.Windows.Forms.MaskedTextBox();
            this.mskExpireDate = new System.Windows.Forms.MaskedTextBox();
            this.mskCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpChairs = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.btnSeeChair = new System.Windows.Forms.Button();
            this.rdnMan = new System.Windows.Forms.RadioButton();
            this.rdnWoman = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskTCNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPayment.SuspendLayout();
            this.grpChairs.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.btnPayment);
            this.grpPayment.Controls.Add(this.mskCVS);
            this.grpPayment.Controls.Add(this.mskExpireDate);
            this.grpPayment.Controls.Add(this.mskCardNumber);
            this.grpPayment.Controls.Add(this.lblUser);
            this.grpPayment.Controls.Add(this.label8);
            this.grpPayment.Controls.Add(this.label7);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.label9);
            this.grpPayment.Controls.Add(this.label6);
            this.grpPayment.Location = new System.Drawing.Point(12, 324);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(352, 306);
            this.grpPayment.TabIndex = 5;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            this.grpPayment.Visible = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(203, 193);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(123, 44);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click_1);
            // 
            // mskCVS
            // 
            this.mskCVS.Location = new System.Drawing.Point(278, 161);
            this.mskCVS.Mask = "000";
            this.mskCVS.Name = "mskCVS";
            this.mskCVS.Size = new System.Drawing.Size(47, 20);
            this.mskCVS.TabIndex = 3;
            // 
            // mskExpireDate
            // 
            this.mskExpireDate.Location = new System.Drawing.Point(129, 161);
            this.mskExpireDate.Mask = "00 00";
            this.mskExpireDate.Name = "mskExpireDate";
            this.mskExpireDate.Size = new System.Drawing.Size(55, 20);
            this.mskExpireDate.TabIndex = 3;
            // 
            // mskCardNumber
            // 
            this.mskCardNumber.Location = new System.Drawing.Point(129, 119);
            this.mskCardNumber.Mask = "0000 0000 0000 0000";
            this.mskCardNumber.Name = "mskCardNumber";
            this.mskCardNumber.Size = new System.Drawing.Size(196, 20);
            this.mskCardNumber.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CVS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Expire Date:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(125, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Card Number:";
            // 
            // grpChairs
            // 
            this.grpChairs.Controls.Add(this.btnNext);
            this.grpChairs.Location = new System.Drawing.Point(370, 18);
            this.grpChairs.Name = "grpChairs";
            this.grpChairs.Size = new System.Drawing.Size(556, 300);
            this.grpChairs.TabIndex = 4;
            this.grpChairs.TabStop = false;
            this.grpChairs.Text = "Select Chairs";
            this.grpChairs.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(425, 248);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 46);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.btnSeeChair);
            this.grpUserInfo.Controls.Add(this.rdnMan);
            this.grpUserInfo.Controls.Add(this.rdnWoman);
            this.grpUserInfo.Controls.Add(this.txtLastName);
            this.grpUserInfo.Controls.Add(this.txtFirstName);
            this.grpUserInfo.Controls.Add(this.mskPhoneNumber);
            this.grpUserInfo.Controls.Add(this.mskTCNo);
            this.grpUserInfo.Controls.Add(this.label5);
            this.grpUserInfo.Controls.Add(this.label4);
            this.grpUserInfo.Controls.Add(this.label3);
            this.grpUserInfo.Controls.Add(this.label2);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Location = new System.Drawing.Point(12, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(352, 306);
            this.grpUserInfo.TabIndex = 3;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Personal Infromation";
            // 
            // btnSeeChair
            // 
            this.btnSeeChair.Location = new System.Drawing.Point(160, 227);
            this.btnSeeChair.Name = "btnSeeChair";
            this.btnSeeChair.Size = new System.Drawing.Size(166, 50);
            this.btnSeeChair.TabIndex = 1;
            this.btnSeeChair.Text = "Select Chairs";
            this.btnSeeChair.UseVisualStyleBackColor = true;
            this.btnSeeChair.Click += new System.EventHandler(this.btnSeeChair_Click_1);
            // 
            // rdnMan
            // 
            this.rdnMan.AutoSize = true;
            this.rdnMan.Location = new System.Drawing.Point(265, 197);
            this.rdnMan.Name = "rdnMan";
            this.rdnMan.Size = new System.Drawing.Size(46, 17);
            this.rdnMan.TabIndex = 3;
            this.rdnMan.Text = "Man";
            this.rdnMan.UseVisualStyleBackColor = true;
            // 
            // rdnWoman
            // 
            this.rdnWoman.AutoSize = true;
            this.rdnWoman.Checked = true;
            this.rdnWoman.Location = new System.Drawing.Point(167, 197);
            this.rdnWoman.Name = "rdnWoman";
            this.rdnWoman.Size = new System.Drawing.Size(62, 17);
            this.rdnWoman.TabIndex = 3;
            this.rdnWoman.TabStop = true;
            this.rdnWoman.Text = "Woman";
            this.rdnWoman.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(167, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(166, 156);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(159, 20);
            this.mskPhoneNumber.TabIndex = 1;
            // 
            // mskTCNo
            // 
            this.mskTCNo.Location = new System.Drawing.Point(167, 43);
            this.mskTCNo.Mask = "00000000000";
            this.mskTCNo.Name = "mskTCNo";
            this.mskTCNo.Size = new System.Drawing.Size(159, 20);
            this.mskTCNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Family Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 639);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpChairs);
            this.Controls.Add(this.grpUserInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpChairs.ResumeLayout(false);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.MaskedTextBox mskCVS;
        private System.Windows.Forms.MaskedTextBox mskExpireDate;
        private System.Windows.Forms.MaskedTextBox mskCardNumber;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpChairs;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Button btnSeeChair;
        private System.Windows.Forms.RadioButton rdnMan;
        private System.Windows.Forms.RadioButton rdnWoman;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mskTCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

