namespace FundTransfer
{
    partial class DashboardRight
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
            panelTotIncome = new Panel();
            lblincm = new Label();
            lblTotalIncome = new Label();
            panelTotExpence = new Panel();
            labelExpenses = new Label();
            lblTotalExpenses = new Label();
            panelMain = new Panel();
            panel3 = new Panel();
            labelBalance = new Label();
            label2 = new Label();
            panelTotIncome.SuspendLayout();
            panelTotExpence.SuspendLayout();
            panelMain.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotIncome
            // 
            panelTotIncome.BorderStyle = BorderStyle.FixedSingle;
            panelTotIncome.Controls.Add(lblincm);
            panelTotIncome.Controls.Add(lblTotalIncome);
            panelTotIncome.Location = new Point(47, 41);
            panelTotIncome.Name = "panelTotIncome";
            panelTotIncome.Size = new Size(503, 150);
            panelTotIncome.TabIndex = 2;
            panelTotIncome.Paint += this.panelTotIncome_Paint;
            // 
            // lblincm
            // 
            lblincm.AutoSize = true;
            lblincm.Font = new Font("Segoe UI", 25F);
            lblincm.Location = new Point(197, 65);
            lblincm.Name = "lblincm";
            lblincm.Size = new Size(197, 57);
            lblincm.TabIndex = 14;
            lblincm.Text = "$ Income";
            lblincm.Click += this.label3_Click_1;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F);
            lblTotalIncome.Location = new Point(23, 22);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(123, 28);
            lblTotalIncome.TabIndex = 13;
            lblTotalIncome.Text = "Total Income";
            lblTotalIncome.Click += this.label3_Click;
            // 
            // panelTotExpence
            // 
            panelTotExpence.BorderStyle = BorderStyle.FixedSingle;
            panelTotExpence.Controls.Add(labelExpenses);
            panelTotExpence.Controls.Add(lblTotalExpenses);
            panelTotExpence.Location = new Point(589, 41);
            panelTotExpence.Name = "panelTotExpence";
            panelTotExpence.Size = new Size(503, 150);
            panelTotExpence.TabIndex = 14;
            panelTotExpence.Paint += this.panelTotExpenses_Paint;
            // 
            // labelExpenses
            // 
            labelExpenses.AutoSize = true;
            labelExpenses.Font = new Font("Segoe UI", 25F);
            labelExpenses.Location = new Point(224, 56);
            labelExpenses.Name = "labelExpenses";
            labelExpenses.Size = new Size(229, 57);
            labelExpenses.TabIndex = 15;
            labelExpenses.Text = "$ Expenses";
            labelExpenses.Click += this.labelExpenses_Click;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Segoe UI", 12F);
            lblTotalExpenses.Location = new Point(23, 22);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(137, 28);
            lblTotalExpenses.TabIndex = 13;
            lblTotalExpenses.Text = "Total Expenses";
            lblTotalExpenses.Click += this.lblTotalExpenses_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panelTotIncome);
            panelMain.Controls.Add(panelTotExpence);
            panelMain.Location = new Point(1, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1147, 715);
            panelMain.TabIndex = 14;
            panelMain.Paint += this.panelMain_Paint;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelBalance);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(305, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 150);
            panel3.TabIndex = 14;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 25F);
            labelBalance.Location = new Point(228, 68);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(201, 57);
            labelBalance.TabIndex = 15;
            labelBalance.Text = "$ Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 13;
            label2.Text = "Balance";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 714);
            Controls.Add(panelMain);
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard - Personal Finance Tracker";
            Load += this.Form1_Load;
            panelTotIncome.ResumeLayout(false);
            panelTotIncome.PerformLayout();
            panelTotExpence.ResumeLayout(false);
            panelTotExpence.PerformLayout();
            panelMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
    }
}
