using FinanceFusion.Feeders;

namespace FinanceFusion.Forms
{
    partial class IncomeForm
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            InIdBox = new TextBox();
            InDTBox = new DateTimePicker();
            InDescBox = new TextBox();
            InIncomeBox = new TextBox();
            InCateBox = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1336, 261);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1366, 328);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 2;
            label1.Text = "Income List:";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(InIdBox);
            panel3.Controls.Add(InDTBox);
            panel3.Controls.Add(InDescBox);
            panel3.Controls.Add(InIncomeBox);
            panel3.Controls.Add(InCateBox);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 346);
            panel3.Name = "panel3";
            panel3.Size = new Size(1366, 355);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 122);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 16;
            label3.Text = "ID:";
            label3.Click += label3_Click;
            // 
            // InIdBox
            // 
            InIdBox.Enabled = false;
            InIdBox.Location = new Point(380, 119);
            InIdBox.Name = "InIdBox";
            InIdBox.Size = new Size(151, 27);
            InIdBox.TabIndex = 15;
            InIdBox.TextChanged += textBox1_TextChanged;
            // 
            // InDTBox
            // 
            InDTBox.Location = new Point(664, 168);
            InDTBox.Name = "InDTBox";
            InDTBox.Size = new Size(250, 27);
            InDTBox.TabIndex = 14;
            InDTBox.ValueChanged += InDTBox_ValueChanged;
            // 
            // InDescBox
            // 
            InDescBox.Location = new Point(664, 71);
            InDescBox.Multiline = true;
            InDescBox.Name = "InDescBox";
            InDescBox.Size = new Size(250, 75);
            InDescBox.TabIndex = 13;
            InDescBox.TextChanged += InDescBox_TextChanged;
            // 
            // InIncomeBox
            // 
            InIncomeBox.Location = new Point(380, 164);
            InIncomeBox.Name = "InIncomeBox";
            InIncomeBox.Size = new Size(151, 27);
            InIncomeBox.TabIndex = 12;
            InIncomeBox.TextChanged += InIncomeBox_TextChanged;
            // 
            // InCateBox
            // 
            InCateBox.FormattingEnabled = true;
            InCateBox.Location = new Point(380, 71);
            InCateBox.Name = "InCateBox";
            InCateBox.Size = new Size(151, 28);
            InCateBox.TabIndex = 10;
            InCateBox.SelectedIndexChanged += InCateBox_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Theme.BtnColor;
            button4.ForeColor = Color.FromArgb(255, 255, 255);
            button4.Location = new Point(524, 218);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Theme.BtnColor;
            button3.ForeColor = Theme.BtnTxtColor;
            button3.Location = new Point(405, 218);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Theme.BtnColor;
            button2.ForeColor = Theme.BtnTxtColor;
            button2.Location = new Point(280, 218);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Theme.BtnColor;
            button1.ForeColor = Theme.BtnTxtColor;
            button1.Location = new Point(158, 218);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(614, 168);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(570, 71);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 3;
            label7.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 171);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 74);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1390, 950);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "IncomeForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox InCateBox;
        private DateTimePicker InDTBox;
        private TextBox InDescBox;
        private TextBox InIncomeBox;
        private Label label3;
        private TextBox InIdBox;
    }
}
