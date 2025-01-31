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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            btnregisterpage = new Button();
            btnloginpage = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            lblErrEmail = new Label();
            lblErrPassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
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
            btnregisterpage.BackColor = Color.Green;
            btnregisterpage.Cursor = Cursors.Hand;
            btnregisterpage.FlatAppearance.BorderSize = 0;
            btnregisterpage.FlatAppearance.MouseDownBackColor = Color.Green;
            btnregisterpage.FlatAppearance.MouseOverBackColor = Color.Green;
            btnregisterpage.FlatStyle = FlatStyle.Flat;
            btnregisterpage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregisterpage.ForeColor = Color.White;
            btnregisterpage.Location = new Point(13, 448);
            btnregisterpage.Margin = new Padding(3, 4, 3, 4);
            btnregisterpage.Name = "btnRegisterForm";
            btnregisterpage.Size = new Size(236, 49);
            btnregisterpage.TabIndex = 6;
            btnregisterpage.Text = "REGISTER HERE";
            btnregisterpage.UseVisualStyleBackColor = false;
            btnregisterpage.Click += button3_Click;
            // 
            // btnloginpage
            // 
            btnloginpage.BackColor = Color.Green;
            btnloginpage.FlatAppearance.MouseDownBackColor = Color.Green;
            btnloginpage.FlatAppearance.MouseOverBackColor = Color.Green;
            btnloginpage.FlatStyle = FlatStyle.Flat;
            btnloginpage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnloginpage.ForeColor = Color.White;
            btnloginpage.Location = new Point(13, 504);
            btnloginpage.Margin = new Padding(3, 4, 3, 4);
            btnloginpage.Name = "btnLoginForm";
            btnloginpage.Size = new Size(236, 49);
            btnloginpage.TabIndex = 4;
            btnloginpage.Text = "SIGN IN";
            btnloginpage.UseVisualStyleBackColor = false;
            btnloginpage.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 264);
            label2.Name = "lblTitle";
            label2.Size = new Size(236, 22);
            label2.TabIndex = 1;
            label2.Text = "Income and Expenses Traker";
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(617, 9);
            label1.Name = "lblCancel";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 84);
            label4.Name = "lblSignIn";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 8;
            label4.Text = "SIGN IN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 154);
            label5.Name = "lblEmail";
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
            // txtpswd
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
            label6.Name = "lblPassword";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // btnlogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Green;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(327, 404);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(277, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnlogin_Click;
            // 
            // checkBox1
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
            label3.Name = "lblForgotPassword";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 15;
            label3.Text = "Forgot Password";
            label3.Click += label3_Click_1;
            // 
            // lblerrusername
            // 
            lblErrEmail.AutoSize = true;
            lblErrEmail.ForeColor = Color.Red;
            lblErrEmail.Location = new Point(306, 209);
            lblErrEmail.Name = "lblErrEmail";
            lblErrEmail.Size = new Size(228, 20);
            lblErrEmail.TabIndex = 16;
            lblErrEmail.Text = "*!..Please enter the EmailAddres..!";
            lblErrEmail.Visible = false;
            // 
            // lblerrpasword
            // 
            lblErrPassword.AutoSize = true;
            lblErrPassword.ForeColor = Color.Red;
            lblErrPassword.Location = new Point(306, 288);
            lblErrPassword.Name = "lblErrPassword";
            lblErrPassword.Size = new Size(205, 20);
            lblErrPassword.TabIndex = 17;
            lblErrPassword.Text = "*!..Please enter the Password..!";
            lblErrPassword.Visible = false;
            //Static fields
            panel1.BackColor = Theme.LeftPanelColor;
            btnloginpage.BackColor = Theme.BtnColor;
            // label1.ForeColor = Theme.TxtColor;
            label2.ForeColor = Theme.TxtColor;

            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 562);
            Controls.Add(lblErrPassword);
            Controls.Add(lblErrEmail);
            Controls.Add(label3);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnregisterpage;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private Label label3;
        private Label lblErrEmail;
        private Label lblErrPassword;
    }
}