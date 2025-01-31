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
            panel1 = new Panel();
            label1 = new Label();
            pictureBoxReport = new PictureBox();
            lblLogout = new Label();
            pictureBoxLogout = new PictureBox();
            lblExpenses = new Label();
            pictureBoxExpence = new PictureBox();
            lblIncome = new Label();
            pictureBoxIncome = new PictureBox();
            lblCategory = new Label();
            pictureBoxCategory = new PictureBox();
            lblDashboard = new Label();
            pictureBoxDashboard = new PictureBox();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(44, 48, 84);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBoxReport);
            panel1.Controls.Add(lblLogout);
            panel1.Controls.Add(pictureBoxLogout);
            panel1.Controls.Add(lblExpenses);
            panel1.Controls.Add(pictureBoxExpence);
            panel1.Controls.Add(lblIncome);
            panel1.Controls.Add(pictureBoxIncome);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(pictureBoxCategory);
            panel1.Controls.Add(lblDashboard);
            panel1.Controls.Add(pictureBoxDashboard);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 802);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 468);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 12;
            label1.Text = "Report";
            label1.Click += label1_Click;
            // 
            // pictureBoxReport
            // 
            pictureBoxReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxReport.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxReport.Location = new Point(12, 463);
            pictureBoxReport.Name = "pictureBoxReport";
            pictureBoxReport.Size = new Size(37, 33);
            pictureBoxReport.TabIndex = 11;
            pictureBoxReport.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F);
            lblLogout.ForeColor = Color.White;
            lblLogout.Location = new Point(80, 733);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(83, 28);
            lblLogout.TabIndex = 10;
            lblLogout.Text = "Log Out";
            lblLogout.Click += lblLogout_Click;
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxLogout.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogout.Location = new Point(27, 728);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(37, 33);
            pictureBoxLogout.TabIndex = 9;
            pictureBoxLogout.TabStop = false;
            // 
            // lblExpenses
            // 
            lblExpenses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExpenses.AutoSize = true;
            lblExpenses.Font = new Font("Segoe UI", 12F);
            lblExpenses.ForeColor = Color.White;
            lblExpenses.Location = new Point(65, 420);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(90, 28);
            lblExpenses.TabIndex = 8;
            lblExpenses.Text = "Expenses";
            lblExpenses.Click += lblExpenses_Click;
            // 
            // pictureBoxExpence
            // 
            pictureBoxExpence.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxExpence.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxExpence.Location = new Point(12, 415);
            pictureBoxExpence.Name = "pictureBoxExpence";
            pictureBoxExpence.Size = new Size(37, 33);
            pictureBoxExpence.TabIndex = 7;
            pictureBoxExpence.TabStop = false;
            // 
            // lblIncome
            // 
            lblIncome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 12F);
            lblIncome.ForeColor = Color.White;
            lblIncome.Location = new Point(65, 365);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(76, 28);
            lblIncome.TabIndex = 6;
            lblIncome.Text = "Income";
            lblIncome.Click += lblIncome_Click;
            // 
            // pictureBoxIncome
            // 
            pictureBoxIncome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxIncome.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxIncome.Location = new Point(12, 360);
            pictureBoxIncome.Name = "pictureBoxIncome";
            pictureBoxIncome.Size = new Size(37, 33);
            pictureBoxIncome.TabIndex = 5;
            pictureBoxIncome.TabStop = false;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(65, 312);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 28);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            lblCategory.Click += lblCategory_Click;
            // 
            // pictureBoxCategory
            // 
            pictureBoxCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxCategory.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCategory.Location = new Point(12, 307);
            pictureBoxCategory.Name = "pictureBoxCategory";
            pictureBoxCategory.Size = new Size(37, 33);
            pictureBoxCategory.TabIndex = 3;
            pictureBoxCategory.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(65, 254);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(108, 28);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // pictureBoxDashboard
            // 
            pictureBoxDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxDashboard.Location = new Point(12, 249);
            pictureBoxDashboard.Name = "pictureBoxDashboard";
            pictureBoxDashboard.Size = new Size(37, 33);
            pictureBoxDashboard.TabIndex = 1;
            pictureBoxDashboard.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(65, 208);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(80, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 125);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(244, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1402, 802);
            panel2.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 801);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "Dashboard - Personal Finance Tracker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private PictureBox pictureBoxCategory;
        private Label lblDashboard;
        private PictureBox pictureBoxDashboard;
        private Label lblExpence;
        private PictureBox pictureBoxExpence;
        private Label lblIncome;
        private PictureBox pictureBoxIncome;
        private Label lblCategory;
        private Label lblLogout;
        private PictureBox pictureBoxLogout;
        private Label lblExpenceDetails;
        private Label lblTotalExpence;
        private Label lblExpenses;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxReport;
        private TabPage tabPage1;
        private Panel panel2;
    }
}
