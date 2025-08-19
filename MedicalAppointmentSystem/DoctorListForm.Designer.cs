namespace MedicalAppointmentSystem
{
    partial class DoctorListForm
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
            dgvDoctors = new DataGridView();
            textBox1 = new TextBox();
            btnLoadDoctors = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(39, 80);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(672, 290);
            dgvDoctors.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(313, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 33);
            textBox1.TabIndex = 1;
            textBox1.Text = "Doctor List";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLoadDoctors
            // 
            btnLoadDoctors.Location = new Point(509, 389);
            btnLoadDoctors.Name = "btnLoadDoctors";
            btnLoadDoctors.Size = new Size(91, 34);
            btnLoadDoctors.TabIndex = 2;
            btnLoadDoctors.Text = "Refresh";
            btnLoadDoctors.UseVisualStyleBackColor = true;
            btnLoadDoctors.Click += btnLoadDoctors_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(625, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnLoadDoctors);
            Controls.Add(textBox1);
            Controls.Add(dgvDoctors);
            Name = "DoctorListForm";
            Text = "DoctorListForm";
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoctors;
        private TextBox textBox1;
        private Button btnLoadDoctors;
        private Button btnClose;
    }
}