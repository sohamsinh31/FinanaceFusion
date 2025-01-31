using System.Windows.Forms;

namespace FinanceFusion.Forms
{
    partial class AddCategoryForm
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
            SideBar = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmb_type = new ComboBox();
            label4 = new Label();
            txtBox_Name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            MainSection = new Panel();
            label1 = new Label();
            CategoryData = new DataGridView();
            SideBar.SuspendLayout();
            MainSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryData).BeginInit();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.White;
            SideBar.Controls.Add(dateTimePicker1);
            SideBar.Controls.Add(label5);
            SideBar.Controls.Add(btnDelete);
            SideBar.Controls.Add(btnClear);
            SideBar.Controls.Add(btnUpdate);
            SideBar.Controls.Add(btnAdd);
            SideBar.Controls.Add(cmb_type);
            SideBar.Controls.Add(label4);
            SideBar.Controls.Add(txtBox_Name);
            SideBar.Controls.Add(label3);
            SideBar.Controls.Add(label2);
            SideBar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SideBar.ForeColor = Color.White;
            SideBar.Location = new Point(3, 4);
            SideBar.Margin = new Padding(3, 4, 3, 4);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(352, 950);
            SideBar.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 11F);
            dateTimePicker1.Location = new Point(25, 386);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 28);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 334);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 9;
            label5.Text = "Date:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(20, 53, 197);
            btnDelete.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(175, 592);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 74);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(20, 53, 197);
            btnClear.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(25, 592);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 74);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(20, 53, 197);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(175, 486);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 74);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(20, 53, 197);
            btnAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(25, 486);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 74);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmb_type
            // 
            cmb_type.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_type.FormattingEnabled = true;
            cmb_type.Location = new Point(25, 268);
            cmb_type.Margin = new Padding(3, 4, 3, 4);
            cmb_type.Name = "cmb_type";
            cmb_type.Size = new Size(292, 32);
            cmb_type.TabIndex = 4;
            cmb_type.Text = "Select Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(27, 210);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 3;
            label4.Text = "Category Type:";
            // 
            // txtBox_Name
            // 
            txtBox_Name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox_Name.Location = new Point(25, 151);
            txtBox_Name.Margin = new Padding(3, 4, 3, 4);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(292, 32);
            txtBox_Name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 1;
            label3.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(19, 16);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 0;
            label2.Text = "Add Category";
            // 
            // MainSection
            // 
            MainSection.Controls.Add(label1);
            MainSection.Controls.Add(CategoryData);
            MainSection.Location = new Point(351, 4);
            MainSection.Margin = new Padding(3, 4, 3, 4);
            MainSection.Name = "MainSection";
            MainSection.Size = new Size(1039, 946);
            MainSection.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(196, 34);
            label1.TabIndex = 1;
            label1.Text = "Categories List";
            // 
            // CategoryData
            // 
            CategoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryData.Location = new Point(22, 81);
            CategoryData.Margin = new Padding(3, 4, 3, 4);
            CategoryData.Name = "CategoryData";
            CategoryData.RowHeadersWidth = 51;
            CategoryData.RowTemplate.Height = 24;
            CategoryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryData.Size = new Size(1005, 852);
            CategoryData.TabIndex = 0;
            CategoryData.CellClick += CategoryData_CellClick;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 950);
            Controls.Add(MainSection);
            Controls.Add(SideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCategoryForm";
            Text = "Add Category";
            SideBar.ResumeLayout(false);
            SideBar.PerformLayout();
            MainSection.ResumeLayout(false);
            MainSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel MainSection;
        private System.Windows.Forms.DataGridView CategoryData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

