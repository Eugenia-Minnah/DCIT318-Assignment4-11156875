namespace MedicalAppointmentSystem
{
    partial class ManageAppointmentsForm
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
            textBox1 = new TextBox();
            dgvAppointments = new DataGridView();
            textBox2 = new TextBox();
            dtpNewDate = new DateTimePicker();
            btnLoadAppointments = new Button();
            btnBack = new Button();
            btnDeleteAppointment = new Button();
            btnUpdateAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(215, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Manage Appointments";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(12, 88);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(531, 220);
            dgvAppointments.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 326);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 2;
            textBox2.Text = "New Date:";
            // 
            // dtpNewDate
            // 
            dtpNewDate.Location = new Point(127, 332);
            dtpNewDate.Name = "dtpNewDate";
            dtpNewDate.Size = new Size(368, 23);
            dtpNewDate.TabIndex = 3;
            // 
            // btnLoadAppointments
            // 
            btnLoadAppointments.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadAppointments.Location = new Point(568, 88);
            btnLoadAppointments.Name = "btnLoadAppointments";
            btnLoadAppointments.Size = new Size(110, 30);
            btnLoadAppointments.TabIndex = 4;
            btnLoadAppointments.Text = "Load";
            btnLoadAppointments.UseVisualStyleBackColor = true;
            btnLoadAppointments.Click += btnLoadAppointments_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(568, 276);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 32);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAppointment.Location = new Point(568, 215);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(110, 30);
            btnDeleteAppointment.TabIndex = 6;
            btnDeleteAppointment.Text = "Delete";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAppointment.Location = new Point(568, 152);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new Size(110, 30);
            btnUpdateAppointment.TabIndex = 7;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = true;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // ManageAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 462);
            Controls.Add(btnUpdateAppointment);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnBack);
            Controls.Add(btnLoadAppointments);
            Controls.Add(dtpNewDate);
            Controls.Add(textBox2);
            Controls.Add(dgvAppointments);
            Controls.Add(textBox1);
            Name = "ManageAppointmentsForm";
            Text = "ManageAppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dgvAppointments;
        private TextBox textBox2;
        private DateTimePicker dtpNewDate;
        private Button btnLoadAppointments;
        private Button btnBack;
        private Button btnDeleteAppointment;
        private Button btnUpdateAppointment;
    }
}