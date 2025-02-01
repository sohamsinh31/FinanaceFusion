using FinanceFusion.Feeders;

namespace FinanceFusion.Forms
{
    partial class RegistrationForm : Form
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnSignIN = new Button();
            lblTitle = new Label();
            btnSignUp = new Button();
            txtPassword = new TextBox();
            label6 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtConPassword = new TextBox();
            lblconpswd = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            lblerrpasword = new Label();
            chkShowPassword = new CheckBox();
            lblerrfnlname = new Label();
            lblerremailadd = new Label();
            lblerrconpswd = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 48, 84);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnSignIN);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(-1, -5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 635);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 53, 197);
            button3.FlatAppearance.MouseDownBackColor = Color.Green;
            button3.FlatAppearance.MouseOverBackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(13, 448);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(236, 49);
            button3.TabIndex = 11;
            button3.Text = "REGISTER HERE";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSignIN
            // 
            btnSignIN.BackColor = Color.FromArgb(20, 53, 197);
            btnSignIN.Cursor = Cursors.Hand;
            btnSignIN.FlatAppearance.BorderSize = 0;
            btnSignIN.FlatAppearance.MouseDownBackColor = Color.Green;
            btnSignIN.FlatAppearance.MouseOverBackColor = Color.Green;
            btnSignIN.FlatStyle = FlatStyle.Flat;
            btnSignIN.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIN.ForeColor = Color.FromArgb(255, 255, 255);
            btnSignIN.Location = new Point(13, 504);
            btnSignIN.Margin = new Padding(3, 4, 3, 4);
            btnSignIN.Name = "btnSignIN";
            btnSignIN.Size = new Size(236, 49);
            btnSignIN.TabIndex = 10;
            btnSignIN.Text = "SIGN IN";
            btnSignIN.UseVisualStyleBackColor = false;
            btnSignIN.Click += Login_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 264);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 22);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Finance Fusion";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(20, 53, 197);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.MouseDownBackColor = Color.Green;
            btnSignUp.FlatAppearance.MouseOverBackColor = Color.Green;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.FromArgb(255, 255, 255);
            btnSignUp.Location = new Point(331, 488);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(277, 49);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "SIGNUP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += Register_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(306, 319);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(315, 24);
            txtPassword.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 295);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 19;
            label6.Text = "Password";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Window;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(309, 167);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(142, 24);
            txtFirstName.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 143);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 17;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 84);
            label4.Name = "label4";
            label4.Size = new Size(115, 29);
            label4.TabIndex = 16;
            label4.Text = "SIGN UP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(645, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 15;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // txtConPassword
            // 
            txtConPassword.BackColor = SystemColors.Window;
            txtConPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConPassword.Location = new Point(309, 395);
            txtConPassword.Margin = new Padding(3, 4, 3, 4);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.Size = new Size(315, 24);
            txtConPassword.TabIndex = 22;
            // 
            // lblconpswd
            // 
            lblconpswd.AutoSize = true;
            lblconpswd.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblconpswd.Location = new Point(306, 371);
            lblconpswd.Name = "lblconpswd";
            lblconpswd.Size = new Size(133, 20);
            lblconpswd.TabIndex = 21;
            lblconpswd.Text = "Conform Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(306, 243);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 24);
            txtEmail.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 219);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 23;
            label7.Text = "Email Addres";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Window;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(479, 167);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(142, 24);
            txtLastName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(479, 143);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // lblerrpasword
            // 
            lblerrpasword.AutoSize = true;
            lblerrpasword.ForeColor = Color.Red;
            lblerrpasword.Location = new Point(309, 347);
            lblerrpasword.Name = "lblerrpasword";
            lblerrpasword.Size = new Size(205, 20);
            lblerrpasword.TabIndex = 28;
            lblerrpasword.Text = "*!..Please enter the Password..!";
            lblerrpasword.Visible = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Microsoft PhagsPa", 9F);
            chkShowPassword.Location = new Point(491, 446);
            chkShowPassword.Margin = new Padding(3, 4, 3, 4);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(133, 24);
            chkShowPassword.TabIndex = 27;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblerrfnlname
            // 
            lblerrfnlname.AutoSize = true;
            lblerrfnlname.ForeColor = Color.Red;
            lblerrfnlname.Location = new Point(309, 195);
            lblerrfnlname.Name = "lblerrfnlname";
            lblerrfnlname.Size = new Size(276, 20);
            lblerrfnlname.TabIndex = 29;
            lblerrfnlname.Text = "*!..Please enter the First And Last Nmae..!";
            lblerrfnlname.Visible = false;
            // 
            // lblerremailadd
            // 
            lblerremailadd.AutoSize = true;
            lblerremailadd.ForeColor = Color.Red;
            lblerremailadd.Location = new Point(306, 271);
            lblerremailadd.Name = "lblerremailadd";
            lblerremailadd.Size = new Size(238, 20);
            lblerremailadd.TabIndex = 30;
            lblerremailadd.Text = "*!..Please enter the Email Address..!";
            lblerremailadd.Visible = false;
            // 
            // lblerrconpswd
            // 
            lblerrconpswd.AutoSize = true;
            lblerrconpswd.ForeColor = Color.Red;
            lblerrconpswd.Location = new Point(309, 423);
            lblerrconpswd.Name = "lblerrconpswd";
            lblerrconpswd.Size = new Size(263, 20);
            lblerrconpswd.TabIndex = 42;
            lblerrconpswd.Text = "!..Please enter the Conform password..!";
            lblerrconpswd.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 562);
            Controls.Add(lblerrconpswd);
            Controls.Add(lblerremailadd);
            Controls.Add(lblerrfnlname);
            Controls.Add(lblerrpasword);
            Controls.Add(chkShowPassword);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtConPassword);
            Controls.Add(lblconpswd);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(btnSignUp);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSignIN;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label lblconpswd;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtLastName;
        private Label label3;
        private Label lblerrpasword;
        private CheckBox chkShowPassword;
        private Label lblerrfnlname;
        private Label lblerremailadd;
        private Label lblerrconpswd;
    }
}