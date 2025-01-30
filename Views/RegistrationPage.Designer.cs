namespace FundTransfer
{
    partial class RegistrationPage : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public RegistrationPage()
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            btnsignup = new Button();
            txtpswd = new TextBox();
            label6 = new Label();
            txtfname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtconpswd = new TextBox();
            lblconpswd = new Label();
            txtemailadd = new TextBox();
            label7 = new Label();
            txtlname = new TextBox();
            label3 = new Label();
            lblerrpasword = new Label();
            checkBox1 = new CheckBox();
            lblerrfnlname = new Label();
            lblerremailadd = new Label();
            lblerrconpswd = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 635);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            button3.BackColor = Color.Green;
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
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 504);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(236, 49);
            button1.TabIndex = 10;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // btnsignup
            // 
            btnsignup.BackColor = Color.Green;
            btnsignup.Cursor = Cursors.Hand;
            btnsignup.FlatAppearance.MouseDownBackColor = Color.Green;
            btnsignup.FlatAppearance.MouseOverBackColor = Color.Green;
            btnsignup.FlatStyle = FlatStyle.Flat;
            btnsignup.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignup.ForeColor = Color.White;
            btnsignup.Location = new Point(331, 488);
            btnsignup.Margin = new Padding(3, 4, 3, 4);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(277, 49);
            btnsignup.TabIndex = 14;
            btnsignup.Text = "SIGNUP";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += button2_Click;
            // 
            // txtpswd
            // 
            txtpswd.BackColor = SystemColors.Window;
            txtpswd.BorderStyle = BorderStyle.FixedSingle;
            txtpswd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpswd.Location = new Point(306, 319);
            txtpswd.Margin = new Padding(3, 4, 3, 4);
            txtpswd.Name = "txtpswd";
            txtpswd.PasswordChar = '*';
            txtpswd.Size = new Size(315, 24);
            txtpswd.TabIndex = 20;
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
            // txtfname
            // 
            txtfname.BackColor = SystemColors.Window;
            txtfname.BorderStyle = BorderStyle.FixedSingle;
            txtfname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfname.Location = new Point(309, 167);
            txtfname.Margin = new Padding(3, 4, 3, 4);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(142, 24);
            txtfname.TabIndex = 18;
            txtfname.TextChanged += txtuser_TextChanged;
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
            label1.Location = new Point(645, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 15;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // txtconpswd
            // 
            txtconpswd.BackColor = SystemColors.Window;
            txtconpswd.BorderStyle = BorderStyle.FixedSingle;
            txtconpswd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconpswd.Location = new Point(309, 395);
            txtconpswd.Margin = new Padding(3, 4, 3, 4);
            txtconpswd.Name = "txtconpswd";
            txtconpswd.PasswordChar = '*';
            txtconpswd.Size = new Size(315, 24);
            txtconpswd.TabIndex = 22;
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
            // txtemailadd
            // 
            txtemailadd.BackColor = SystemColors.Window;
            txtemailadd.BorderStyle = BorderStyle.FixedSingle;
            txtemailadd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemailadd.Location = new Point(306, 243);
            txtemailadd.Margin = new Padding(3, 4, 3, 4);
            txtemailadd.Name = "txtemailadd";
            txtemailadd.Size = new Size(315, 24);
            txtemailadd.TabIndex = 24;
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
            // txtlname
            // 
            txtlname.BackColor = SystemColors.Window;
            txtlname.BorderStyle = BorderStyle.FixedSingle;
            txtlname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlname.Location = new Point(479, 167);
            txtlname.Margin = new Padding(3, 4, 3, 4);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(142, 24);
            txtlname.TabIndex = 25;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Microsoft PhagsPa", 9F);
            checkBox1.Location = new Point(491, 446);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 562);
            Controls.Add(lblerrconpswd);
            Controls.Add(lblerremailadd);
            Controls.Add(lblerrfnlname);
            Controls.Add(lblerrpasword);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(txtlname);
            Controls.Add(txtemailadd);
            Controls.Add(label7);
            Controls.Add(txtconpswd);
            Controls.Add(lblconpswd);
            Controls.Add(label6);
            Controls.Add(txtpswd);
            Controls.Add(btnsignup);
            Controls.Add(txtfname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationPage";
            Text = "RegistrationPage";
            Load += RegistrationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconpswd;
        private System.Windows.Forms.Label lblconpswd;
        private PictureBox pictureBox1;
        private TextBox txtemailadd;
        private Label label7;
        private TextBox txtlname;
        private Label label3;
        private Label lblerrpasword;
        private CheckBox checkBox1;
        private Label lblerrfnlname;
        private Label lblerremailadd;
        private Label lblerrconpswd;
    }
}