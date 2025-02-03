using FinanceFusion.Feeders;

namespace FinanceTracker
{
    partial class ForgotePasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotePasswordPage));
            panel1 = new Panel();
            btnloginpage = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtemail = new TextBox();
            btnsendcode = new Button();
            btnVeryfy = new Button();
            txtcode = new TextBox();
            label3 = new Label();
            lblerremailadd = new Label();
            lblerrcode = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 48, 84);
            panel1.Controls.Add(btnloginpage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 635);
            panel1.TabIndex = 17;
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
            label2.Size = new Size(126, 22);
            label2.TabIndex = 1;
            label2.Text = "Finance Fusion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            label1.TabIndex = 18;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 84);
            label4.Name = "label4";
            label4.Size = new Size(203, 29);
            label4.TabIndex = 19;
            label4.Text = "Forgot Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 154);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 20;
            label5.Text = "Email Address";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.Window;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(306, 182);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(315, 24);
            txtemail.TabIndex = 21;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // btnsendcode
            // 
            btnsendcode.BackColor = Color.FromArgb(20, 53, 197);
            btnsendcode.Cursor = Cursors.Hand;
            btnsendcode.FlatAppearance.MouseDownBackColor = Color.Green;
            btnsendcode.FlatAppearance.MouseOverBackColor = Color.Green;
            btnsendcode.FlatStyle = FlatStyle.Flat;
            btnsendcode.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsendcode.ForeColor = Color.FromArgb(255, 255, 255);
            btnsendcode.Location = new Point(306, 233);
            btnsendcode.Margin = new Padding(3, 4, 3, 4);
            btnsendcode.Name = "btnsendcode";
            btnsendcode.Size = new Size(315, 33);
            btnsendcode.TabIndex = 25;
            btnsendcode.Text = "Send Code";
            btnsendcode.UseVisualStyleBackColor = false;
            btnsendcode.Click += btnsendcode_Click;
            // 
            // btnVeryfy
            // 
            btnVeryfy.BackColor = Color.FromArgb(20, 53, 197);
            btnVeryfy.Cursor = Cursors.Hand;
            btnVeryfy.Enabled = false;
            btnVeryfy.FlatAppearance.MouseDownBackColor = Color.Green;
            btnVeryfy.FlatAppearance.MouseOverBackColor = Color.Green;
            btnVeryfy.FlatStyle = FlatStyle.Flat;
            btnVeryfy.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVeryfy.ForeColor = Color.FromArgb(255, 255, 255);
            btnVeryfy.Location = new Point(310, 375);
            btnVeryfy.Margin = new Padding(3, 4, 3, 4);
            btnVeryfy.Name = "btnVeryfy";
            btnVeryfy.Size = new Size(315, 33);
            btnVeryfy.TabIndex = 28;
            btnVeryfy.Text = "Verify";
            btnVeryfy.UseVisualStyleBackColor = false;
            btnVeryfy.Click += button1_Click;
            // 
            // txtcode
            // 
            txtcode.BackColor = SystemColors.Window;
            txtcode.BorderStyle = BorderStyle.FixedSingle;
            txtcode.Enabled = false;
            txtcode.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcode.Location = new Point(310, 323);
            txtcode.Margin = new Padding(3, 4, 3, 4);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(315, 24);
            txtcode.TabIndex = 27;
            txtcode.TextChanged += txtcode_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 295);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 26;
            label3.Text = "Enter Code";
            // 
            // lblerremailadd
            // 
            lblerremailadd.AutoSize = true;
            lblerremailadd.ForeColor = Color.Red;
            lblerremailadd.Location = new Point(306, 209);
            lblerremailadd.Name = "lblerremailadd";
            lblerremailadd.Size = new Size(238, 20);
            lblerremailadd.TabIndex = 29;
            lblerremailadd.Text = "*!..Please enter the Email Address..!";
            lblerremailadd.Visible = false;
            // 
            // lblerrcode
            // 
            lblerrcode.AutoSize = true;
            lblerrcode.ForeColor = Color.Red;
            lblerrcode.Location = new Point(310, 351);
            lblerrcode.Name = "lblerrcode";
            lblerrcode.Size = new Size(177, 20);
            lblerrcode.TabIndex = 30;
            lblerrcode.Text = "*!..Please enter the code..!";
            lblerrcode.Visible = false;
            // 
            // ForgotePasswordPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(647, 562);
            Controls.Add(lblerrcode);
            Controls.Add(lblerremailadd);
            Controls.Add(btnVeryfy);
            Controls.Add(txtcode);
            Controls.Add(label3);
            Controls.Add(btnsendcode);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotePasswordPage";
            Text = "ForgotePasswordPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnloginpage;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtemail;
        private Button btnsendcode;
        private Button btnVeryfy;
        private TextBox txtcode;
        private Label label3;
        private Label lblerremailadd;
        private Label lblerrcode;
    }
}