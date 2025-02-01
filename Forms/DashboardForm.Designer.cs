namespace FinanceFusion.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelTotIncome = new Panel();
            pictureBox3 = new PictureBox();
            lblincm = new Label();
            lblTotalIncome = new Label();
            panelTotExpence = new Panel();
            pictureBox6 = new PictureBox();
            labelExpenses = new Label();
            lblTotalExpenses = new Label();
            panelMain = new Panel();
            lblCopyRights = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            lblTodayExpenses = new Label();
            lblTodayEx = new Label();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            lblMonthExpenses = new Label();
            lblMonthEx = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTodayIncome = new Label();
            lblTodayIn = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblMonthIncome = new Label();
            lblMonthIn = new Label();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            labelBalance = new Label();
            lblBalance = new Label();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            signUpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelTotIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTotExpence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelMain.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotIncome
            // 
            panelTotIncome.BackColor = Color.FromArgb(44, 48, 84);
            panelTotIncome.BorderStyle = BorderStyle.FixedSingle;
            panelTotIncome.Controls.Add(pictureBox3);
            panelTotIncome.Controls.Add(lblincm);
            panelTotIncome.Controls.Add(lblTotalIncome);
            panelTotIncome.Cursor = Cursors.Hand;
            panelTotIncome.Location = new Point(824, 74);
            panelTotIncome.Name = "panelTotIncome";
            panelTotIncome.Size = new Size(274, 150);
            panelTotIncome.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(23, 59);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 62);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // lblincm
            // 
            lblincm.AutoSize = true;
            lblincm.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblincm.ForeColor = Color.White;
            lblincm.Location = new Point(114, 80);
            lblincm.Name = "lblincm";
            lblincm.Size = new Size(146, 41);
            lblincm.TabIndex = 14;
            lblincm.Text = "₹ Income";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalIncome.ForeColor = Color.White;
            lblTotalIncome.Location = new Point(52, 22);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(172, 28);
            lblTotalIncome.TabIndex = 13;
            lblTotalIncome.Text = "This Year Income";
            // 
            // panelTotExpence
            // 
            panelTotExpence.BackColor = Color.FromArgb(44, 48, 84);
            panelTotExpence.BorderStyle = BorderStyle.FixedSingle;
            panelTotExpence.Controls.Add(pictureBox6);
            panelTotExpence.Controls.Add(labelExpenses);
            panelTotExpence.Controls.Add(lblTotalExpenses);
            panelTotExpence.Cursor = Cursors.Hand;
            panelTotExpence.Location = new Point(824, 280);
            panelTotExpence.Name = "panelTotExpence";
            panelTotExpence.Size = new Size(274, 150);
            panelTotExpence.TabIndex = 14;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(29, 65);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 63);
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // labelExpenses
            // 
            labelExpenses.AutoSize = true;
            labelExpenses.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelExpenses.ForeColor = Color.White;
            labelExpenses.Location = new Point(91, 87);
            labelExpenses.Name = "labelExpenses";
            labelExpenses.Size = new Size(171, 41);
            labelExpenses.TabIndex = 15;
            labelExpenses.Text = "₹ Expenses";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalExpenses.ForeColor = Color.White;
            lblTotalExpenses.Location = new Point(43, 12);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(212, 28);
            lblTotalExpenses.TabIndex = 13;
            lblTotalExpenses.Text = "This Month Expenses";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(lblCopyRights);
            panelMain.Controls.Add(panel5);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panelTotIncome);
            panelMain.Controls.Add(panelTotExpence);
            panelMain.Controls.Add(menuStrip1);
            panelMain.Location = new Point(1, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1147, 715);
            panelMain.TabIndex = 14;
            panelMain.Paint += panelMain_Paint;
            // 
            // lblCopyRights
            // 
            lblCopyRights.AutoSize = true;
            lblCopyRights.Location = new Point(3, 685);
            lblCopyRights.Name = "lblCopyRights";
            lblCopyRights.Size = new Size(402, 20);
            lblCopyRights.TabIndex = 16;
            lblCopyRights.Text = "Copyright © 2025 | All Right Reserved | Created by Group B";
            lblCopyRights.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(44, 48, 84);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(lblTodayExpenses);
            panel5.Controls.Add(lblTodayEx);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(52, 280);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 150);
            panel5.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(23, 65);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 63);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // lblTodayExpenses
            // 
            lblTodayExpenses.AutoSize = true;
            lblTodayExpenses.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTodayExpenses.ForeColor = Color.White;
            lblTodayExpenses.Location = new Point(85, 87);
            lblTodayExpenses.Name = "lblTodayExpenses";
            lblTodayExpenses.Size = new Size(171, 41);
            lblTodayExpenses.TabIndex = 15;
            lblTodayExpenses.Text = "₹ Expenses";
            // 
            // lblTodayEx
            // 
            lblTodayEx.AutoSize = true;
            lblTodayEx.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayEx.ForeColor = Color.White;
            lblTodayEx.Location = new Point(50, 12);
            lblTodayEx.Name = "lblTodayEx";
            lblTodayEx.Size = new Size(160, 28);
            lblTodayEx.TabIndex = 13;
            lblTodayEx.Text = "Today Expenses";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 48, 84);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(lblMonthExpenses);
            panel4.Controls.Add(lblMonthEx);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(443, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 150);
            panel4.TabIndex = 16;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(23, 65);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 63);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // lblMonthExpenses
            // 
            lblMonthExpenses.AutoSize = true;
            lblMonthExpenses.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMonthExpenses.ForeColor = Color.White;
            lblMonthExpenses.Location = new Point(85, 87);
            lblMonthExpenses.Name = "lblMonthExpenses";
            lblMonthExpenses.Size = new Size(171, 41);
            lblMonthExpenses.TabIndex = 15;
            lblMonthExpenses.Text = "₹ Expenses";
            // 
            // lblMonthEx
            // 
            lblMonthEx.AutoSize = true;
            lblMonthEx.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonthEx.ForeColor = Color.White;
            lblMonthEx.Location = new Point(38, 12);
            lblMonthEx.Name = "lblMonthEx";
            lblMonthEx.Size = new Size(212, 28);
            lblMonthEx.TabIndex = 13;
            lblMonthEx.Text = "This Month Expenses";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 48, 84);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTodayIncome);
            panel2.Controls.Add(lblTodayIn);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(52, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 150);
            panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 62);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblTodayIncome
            // 
            lblTodayIncome.AutoSize = true;
            lblTodayIncome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTodayIncome.ForeColor = Color.White;
            lblTodayIncome.Location = new Point(108, 80);
            lblTodayIncome.Name = "lblTodayIncome";
            lblTodayIncome.Size = new Size(146, 41);
            lblTodayIncome.TabIndex = 14;
            lblTodayIncome.Text = "₹ Income";
            // 
            // lblTodayIn
            // 
            lblTodayIn.AutoSize = true;
            lblTodayIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayIn.ForeColor = Color.White;
            lblTodayIn.Location = new Point(67, 22);
            lblTodayIn.Name = "lblTodayIn";
            lblTodayIn.Size = new Size(143, 28);
            lblTodayIn.TabIndex = 13;
            lblTodayIn.Text = "Today Income";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 48, 84);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblMonthIncome);
            panel1.Controls.Add(lblMonthIn);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(443, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 150);
            panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(23, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 62);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // lblMonthIncome
            // 
            lblMonthIncome.AutoSize = true;
            lblMonthIncome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMonthIncome.ForeColor = Color.White;
            lblMonthIncome.Location = new Point(108, 80);
            lblMonthIncome.Name = "lblMonthIncome";
            lblMonthIncome.Size = new Size(146, 41);
            lblMonthIncome.TabIndex = 14;
            lblMonthIncome.Text = "₹ Income";
            // 
            // lblMonthIn
            // 
            lblMonthIn.AutoSize = true;
            lblMonthIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonthIn.ForeColor = Color.White;
            lblMonthIn.Location = new Point(38, 22);
            lblMonthIn.Name = "lblMonthIn";
            lblMonthIn.Size = new Size(195, 28);
            lblMonthIn.TabIndex = 13;
            lblMonthIn.Text = "This Month Income";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 48, 84);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(labelBalance);
            panel3.Controls.Add(lblBalance);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(368, 490);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 156);
            panel3.TabIndex = 14;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(33, 45);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(90, 71);
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelBalance.ForeColor = Color.White;
            labelBalance.Location = new Point(140, 59);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(214, 57);
            labelBalance.TabIndex = 15;
            labelBalance.Text = "₹ Balance";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(187, 14);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(105, 35);
            lblBalance.TabIndex = 13;
            lblBalance.Text = "Balance";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 48, 84);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, signUpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 36);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            loginToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            loginToolStripMenuItem.ForeColor = Color.White;
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(75, 32);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // signUpToolStripMenuItem
            // 
            signUpToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            signUpToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            signUpToolStripMenuItem.ForeColor = Color.White;
            signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            signUpToolStripMenuItem.Size = new Size(96, 32);
            signUpToolStripMenuItem.Text = "Sign Up";
            signUpToolStripMenuItem.Click += signUpToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1151, 24);
            menuStrip2.TabIndex = 15;
            menuStrip2.Text = "menuStrip2";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 714);
            Controls.Add(panelMain);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard - Personal Finance Tracker";
            Load += Form1_Load;
            panelTotIncome.ResumeLayout(false);
            panelTotIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTotExpence.ResumeLayout(false);
            panelTotExpence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExpence;
        private Panel panelTotIncome;
        private Label lblExpenceDetails;
        private Label lblTotalIncome;
        private Panel panelTotExpence;
        private Label lblTotalExpence;
        private Label lblTotalExpenses;
        private PictureBox pictureBox2;
        private Panel panelMain;
        private Panel panel3;
        private Label label2;
        private Label lblincm;
        private Label labelExpenses;
        private Label labelBalance;
        private TabPage tabPage1;
        private Panel panel2;
        private Label lblTodayIncome;
        private Label label5;
        private Panel panel1;
        private Label lblMonthIncome;
        private Label label3;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private Label lblTodayExpenses;
        private Label lblMonthExpenses;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem signUpToolStripMenuItem;
        private MenuStrip menuStrip2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCopyRights;
        private Label lbl;
        private Label lblTodayEx;
        private Label lblMonthEx;
        private Label lblTodayIn;
        private Label lblMonthIn;
        private Label lblBalance;
    }
}
