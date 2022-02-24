namespace Functions_SingUp_SingIn
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
            this.btnTest = new System.Windows.Forms.Button();
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.txtSigInUserName = new System.Windows.Forms.TextBox();
            this.txtSigInPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tctFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSignIn.SuspendLayout();
            this.grpSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(100, 361);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(210, 47);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Dictionary Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // grpSignIn
            // 
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.txtCaptcha);
            this.grpSignIn.Controls.Add(this.txtSigInUserName);
            this.grpSignIn.Controls.Add(this.txtSigInPassword);
            this.grpSignIn.Controls.Add(this.label5);
            this.grpSignIn.Controls.Add(this.label6);
            this.grpSignIn.Controls.Add(this.lblCaptcha);
            this.grpSignIn.Controls.Add(this.label7);
            this.grpSignIn.Location = new System.Drawing.Point(409, 42);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.Size = new System.Drawing.Size(291, 302);
            this.grpSignIn.TabIndex = 5;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "Sign In";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(132, 230);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(120, 35);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "SignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(132, 187);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(120, 20);
            this.txtCaptcha.TabIndex = 1;
            // 
            // txtSigInUserName
            // 
            this.txtSigInUserName.Location = new System.Drawing.Point(132, 44);
            this.txtSigInUserName.Name = "txtSigInUserName";
            this.txtSigInUserName.Size = new System.Drawing.Size(120, 20);
            this.txtSigInUserName.TabIndex = 1;
            // 
            // txtSigInPassword
            // 
            this.txtSigInPassword.Location = new System.Drawing.Point(132, 89);
            this.txtSigInPassword.Name = "txtSigInPassword";
            this.txtSigInPassword.PasswordChar = '*';
            this.txtSigInPassword.Size = new System.Drawing.Size(120, 20);
            this.txtSigInPassword.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Location = new System.Drawing.Point(128, 142);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(0, 13);
            this.lblCaptcha.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Captcha:";
            // 
            // grpSignUp
            // 
            this.grpSignUp.Controls.Add(this.btnSignUp);
            this.grpSignUp.Controls.Add(this.txtPassword);
            this.grpSignUp.Controls.Add(this.label4);
            this.grpSignUp.Controls.Add(this.txtLastName);
            this.grpSignUp.Controls.Add(this.txtUserName);
            this.grpSignUp.Controls.Add(this.label2);
            this.grpSignUp.Controls.Add(this.label3);
            this.grpSignUp.Controls.Add(this.tctFirstName);
            this.grpSignUp.Controls.Add(this.label1);
            this.grpSignUp.Location = new System.Drawing.Point(100, 42);
            this.grpSignUp.Name = "grpSignUp";
            this.grpSignUp.Size = new System.Drawing.Size(303, 302);
            this.grpSignUp.TabIndex = 4;
            this.grpSignUp.TabStop = false;
            this.grpSignUp.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(144, 230);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(120, 35);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(144, 139);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(120, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // tctFirstName
            // 
            this.tctFirstName.Location = new System.Drawing.Point(144, 47);
            this.tctFirstName.Name = "tctFirstName";
            this.tctFirstName.Size = new System.Drawing.Size(120, 20);
            this.tctFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.grpSignIn);
            this.Controls.Add(this.grpSignUp);
            this.Name = "Form1";
            this.Text = "Functions SingUp SingIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.grpSignUp.ResumeLayout(false);
            this.grpSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox grpSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.TextBox txtSigInUserName;
        private System.Windows.Forms.TextBox txtSigInPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tctFirstName;
        private System.Windows.Forms.Label label1;
    }
}

