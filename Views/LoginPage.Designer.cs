namespace FundTransfer
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            btnregisterpage = new Button();
            btnloginpage = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtusername = new TextBox();
            txtpswd = new TextBox();
            label6 = new Label();
            btnlogin = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            lblerrusername = new Label();
            lblerrpasword = new Label();
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
            btnregisterpage.Name = "btnregisterpage";
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
            btnloginpage.Name = "btnloginpage";
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
            label2.Name = "label2";
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
            label1.Name = "label1";
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
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Window;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(306, 182);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(315, 24);
            txtusername.TabIndex = 11;
            // 
            // txtpswd
            // 
            txtpswd.AccessibleRole = AccessibleRole.None;
            txtpswd.BackColor = SystemColors.Window;
            txtpswd.BorderStyle = BorderStyle.FixedSingle;
            txtpswd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpswd.Location = new Point(306, 260);
            txtpswd.Margin = new Padding(3, 4, 3, 4);
            txtpswd.Name = "txtpswd";
            txtpswd.PasswordChar = '*';
            txtpswd.Size = new Size(315, 24);
            txtpswd.TabIndex = 13;
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
            // btnlogin
            // 
            btnlogin.BackColor = Color.Green;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.Green;
            btnlogin.FlatAppearance.MouseOverBackColor = Color.Green;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(327, 404);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(277, 49);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Microsoft PhagsPa", 9F);
            checkBox1.Location = new Point(488, 311);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            label3.Click += label3_Click_1;
            // 
            // lblerrusername
            // 
            lblerrusername.AutoSize = true;
            lblerrusername.ForeColor = Color.Red;
            lblerrusername.Location = new Point(306, 209);
            lblerrusername.Name = "lblerrusername";
            lblerrusername.Size = new Size(228, 20);
            lblerrusername.TabIndex = 16;
            lblerrusername.Text = "*!..Please enter the EmailAddres..!";
            lblerrusername.Visible = false;
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
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 562);
            Controls.Add(lblerrpasword);
            Controls.Add(lblerrusername);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(btnlogin);
            Controls.Add(txtpswd);
            Controls.Add(label6);
            Controls.Add(txtusername);
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
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregisterpage;
        private System.Windows.Forms.CheckBox checkBox1;
        private Label label3;
        private Label lblerrusername;
        private Label lblerrpasword;
    }
}