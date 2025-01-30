namespace FinanceFusion.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            panelLeft = new Panel();
            btnloginpage = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtnewpswd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtcnfpswd = new TextBox();
            label6 = new Label();
            lblerrnewpswd = new Label();
            lblconpswd = new Label();
            checkBox1 = new CheckBox();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Green;
            panelLeft.Controls.Add(btnloginpage);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Location = new Point(-1, -5);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(282, 635);
            panelLeft.TabIndex = 29;
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
            btnloginpage.Text = "<- BACK";
            btnloginpage.UseVisualStyleBackColor = false;
            btnloginpage.Click += btnloginpage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 264);
            label2.Name = "label2";
            label2.Size = new Size(205, 22);
            label2.TabIndex = 1;
            label2.Text = "Fianace Tracker Group B";
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
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(310, 429);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(315, 33);
            button1.TabIndex = 37;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtnewpswd
            // 
            txtnewpswd.BackColor = SystemColors.Window;
            txtnewpswd.BorderStyle = BorderStyle.FixedSingle;
            txtnewpswd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnewpswd.Location = new Point(310, 258);
            txtnewpswd.Margin = new Padding(3, 4, 3, 4);
            txtnewpswd.Name = "txtnewpswd";
            txtnewpswd.PasswordChar = '*';
            txtnewpswd.Size = new Size(315, 24);
            txtnewpswd.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 230);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 35;
            label3.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(617, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 30;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.Window;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Enabled = false;
            txtemail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(306, 182);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(315, 24);
            txtemail.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 154);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 32;
            label5.Text = "Email Addres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 84);
            label4.Name = "label4";
            label4.Size = new Size(217, 29);
            label4.TabIndex = 31;
            label4.Text = "Forgote Password";
            // 
            // txtcnfpswd
            // 
            txtcnfpswd.BackColor = SystemColors.Window;
            txtcnfpswd.BorderStyle = BorderStyle.FixedSingle;
            txtcnfpswd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcnfpswd.Location = new Point(310, 330);
            txtcnfpswd.Margin = new Padding(3, 4, 3, 4);
            txtcnfpswd.Name = "txtcnfpswd";
            txtcnfpswd.PasswordChar = '*';
            txtcnfpswd.Size = new Size(315, 24);
            txtcnfpswd.TabIndex = 39;
            txtcnfpswd.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 306);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 38;
            label6.Text = "Conform Password";
            // 
            // lblerrnewpswd
            // 
            lblerrnewpswd.AutoSize = true;
            lblerrnewpswd.ForeColor = Color.Red;
            lblerrnewpswd.Location = new Point(306, 286);
            lblerrnewpswd.Name = "lblerrnewpswd";
            lblerrnewpswd.Size = new Size(201, 20);
            lblerrnewpswd.TabIndex = 40;
            lblerrnewpswd.Text = "!..Please enter the password..!";
            lblerrnewpswd.Visible = false;
            // 
            // lblconpswd
            // 
            lblconpswd.AutoSize = true;
            lblconpswd.ForeColor = Color.Red;
            lblconpswd.Location = new Point(306, 358);
            lblconpswd.Name = "lblconpswd";
            lblconpswd.Size = new Size(263, 20);
            lblconpswd.TabIndex = 41;
            lblconpswd.Text = "!..Please enter the Conform password..!";
            lblconpswd.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Microsoft PhagsPa", 9F);
            checkBox1.Location = new Point(488, 382);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 562);
            Controls.Add(checkBox1);
            Controls.Add(lblconpswd);
            Controls.Add(lblerrnewpswd);
            Controls.Add(txtcnfpswd);
            Controls.Add(label6);
            Controls.Add(panelLeft);
            Controls.Add(button1);
            Controls.Add(txtnewpswd);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            Text = "ChangePassword";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLeft;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtnewpswd;
        private Label label3;
        private Label label1;
        private TextBox txtemail;
        private Label label5;
        private Label label4;
        private TextBox txtcnfpswd;
        private Label label6;
        private Label lblerrnewpswd;
        private Label lblconpswd;
        private Button btnloginpage;
        private CheckBox checkBox1;
    }
}