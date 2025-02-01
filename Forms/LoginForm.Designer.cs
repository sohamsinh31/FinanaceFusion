using FinanceFusion.Feeders;

namespace FinanceFusion.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnregisterpage = new Button();
            btnloginpage = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblClose = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            lblerremail = new Label();
            lblerrpasword = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 48, 84);
            panel1.Controls.Add(btnregisterpage);
            panel1.Controls.Add(btnloginpage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 635);
            panel1.TabIndex = 6;
            // 
            // btnregisterpage
            // 
            btnregisterpage.BackColor = Color.FromArgb(20, 53, 197);
            btnregisterpage.Cursor = Cursors.Hand;
            btnregisterpage.FlatAppearance.BorderSize = 0;
            btnregisterpage.FlatAppearance.MouseDownBackColor = Color.Green;
            btnregisterpage.FlatAppearance.MouseOverBackColor = Color.Green;
            btnregisterpage.FlatStyle = FlatStyle.Flat;
            btnregisterpage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregisterpage.ForeColor = Color.FromArgb(255, 255, 255);
            btnregisterpage.Location = new Point(13, 448);
            btnregisterpage.Margin = new Padding(3, 4, 3, 4);
            btnregisterpage.Name = "btnregisterpage";
            btnregisterpage.Size = new Size(236, 49);
            btnregisterpage.TabIndex = 6;
            btnregisterpage.Text = "REGISTER HERE";
            btnregisterpage.UseVisualStyleBackColor = false;
            btnregisterpage.Click += Registration_Click;
            // 
            // btnloginpage
            // 
            btnloginpage.BackColor = Color.FromArgb(20, 53, 197);
            btnloginpage.FlatAppearance.MouseDownBackColor = Color.Green;
            btnloginpage.FlatAppearance.MouseOverBackColor = Color.Green;
            btnloginpage.FlatStyle = FlatStyle.Flat;
            btnloginpage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnloginpage.ForeColor = Color.White;
            btnloginpage.Location = new Point(13, 504);
            btnloginpage.Margin = new Padding(3, 4, 3, 4);
            btnloginpage.Name = "btnloginpage";
            btnloginpage.Size = new Size(236, 49);
            btnloginpage.TabIndex = 4;
            btnloginpage.Text = "SIGN IN";
            btnloginpage.UseVisualStyleBackColor = false;
            btnloginpage.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 264);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 1;
            label2.Text = "Finance Fusion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Location = new Point(617, 9);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(18, 20);
            lblClose.TabIndex = 7;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 84);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 8;
            label4.Text = "SIGN IN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 154);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "Email Addres";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(306, 182);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 24);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleRole = AccessibleRole.None;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(306, 260);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(315, 24);
            txtPassword.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(302, 231);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(20, 53, 197);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Green;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(255, 255, 255);
            btnLogin.Location = new Point(327, 404);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(277, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Microsoft PhagsPa", 9F);
            chkShowPassword.Location = new Point(488, 311);
            chkShowPassword.Margin = new Padding(3, 4, 3, 4);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(133, 24);
            chkShowPassword.TabIndex = 14;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(401, 359);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 15;
            label3.Text = "Forgot Password";
            label3.Click += label3_Click_2;
            // 
            // lblerremail
            // 
            lblerremail.AutoSize = true;
            lblerremail.ForeColor = Color.Red;
            lblerremail.Location = new Point(306, 209);
            lblerremail.Name = "lblerremail";
            lblerremail.Size = new Size(228, 20);
            lblerremail.TabIndex = 16;
            lblerremail.Text = "*!..Please enter the EmailAddres..!";
            lblerremail.Visible = false;
            // 
            // lblerrpasword
            // 
            lblerrpasword.AutoSize = true;
            lblerrpasword.ForeColor = Color.Red;
            lblerrpasword.Location = new Point(306, 288);
            lblerrpasword.Name = "lblerrpasword";
            lblerrpasword.Size = new Size(205, 20);
            lblerrpasword.TabIndex = 17;
            lblerrpasword.Text = "*!..Please enter the Password..!";
            lblerrpasword.Visible = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 562);
            Controls.Add(lblerrpasword);
            Controls.Add(lblerremail);
            Controls.Add(label3);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(lblClose);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnloginpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnregisterpage;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private Label label3;
        private Label lblerremail;
        private Label lblerrpasword;
        private Label label1;
    }
}