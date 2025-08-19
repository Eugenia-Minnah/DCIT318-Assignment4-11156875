namespace PharmacyInventorySystem
{
    partial class MainForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnAddMedicine = new Button();
            btnUpdateStock = new Button();
            btnClear = new Button();
            btnSearchMedicine = new Button();
            dgvMedicines = new DataGridView();
            btnRecordSale = new Button();
            btnViewAll = new Button();
            btnExit = new Button();
            txtMedicineName = new TextBox();
            txtSearch = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(154, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Pharmacy Inventory System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Medicine Name:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Search:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 155);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Quantity:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Price:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(12, 97);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(113, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "Category:";
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMedicine.Location = new Point(88, 199);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(126, 23);
            btnAddMedicine.TabIndex = 6;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.Location = new Point(253, 199);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(107, 23);
            btnUpdateStock.TabIndex = 7;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(409, 199);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearchMedicine
            // 
            btnSearchMedicine.Location = new Point(409, 237);
            btnSearchMedicine.Name = "btnSearchMedicine";
            btnSearchMedicine.Size = new Size(105, 23);
            btnSearchMedicine.TabIndex = 9;
            btnSearchMedicine.Text = "Search Medicine";
            btnSearchMedicine.UseVisualStyleBackColor = true;
            btnSearchMedicine.Click += btnSearchMedicine_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Location = new Point(25, 288);
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.Size = new Size(578, 188);
            dgvMedicines.TabIndex = 10;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordSale.Location = new Point(88, 498);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(108, 23);
            btnRecordSale.TabIndex = 11;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAll.Location = new Point(253, 498);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(107, 23);
            btnViewAll.TabIndex = 12;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(409, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new Point(154, 68);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(368, 23);
            txtMedicineName.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 238);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 23);
            txtSearch.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(154, 155);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(368, 23);
            txtQuantity.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(154, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(368, 23);
            txtPrice.TabIndex = 17;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(154, 97);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(368, 23);
            txtCategory.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 567);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtSearch);
            Controls.Add(txtMedicineName);
            Controls.Add(btnExit);
            Controls.Add(btnViewAll);
            Controls.Add(btnRecordSale);
            Controls.Add(dgvMedicines);
            Controls.Add(btnSearchMedicine);
            Controls.Add(btnClear);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnAddMedicine);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnAddMedicine;
        private Button btnUpdateStock;
        private Button btnClear;
        private Button btnSearchMedicine;
        private DataGridView dgvMedicines;
        private Button btnRecordSale;
        private Button btnViewAll;
        private Button btnExit;
        private TextBox txtMedicineName;
        private TextBox txtSearch;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtCategory;
    }
}
