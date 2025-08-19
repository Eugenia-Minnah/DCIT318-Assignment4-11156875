namespace MedicalAppointmentSystem
{
    partial class AppointmentForm
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
            comboDoctors = new ComboBox();
            comboPatients = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnBookAppointment = new Button();
            btnClear = new Button();
            dtpAppointmentDate = new DateTimePicker();
            txtNotes = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(265, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Book An Appointment";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // comboDoctors
            // 
            comboDoctors.FormattingEnabled = true;
            comboDoctors.Location = new Point(196, 115);
            comboDoctors.Name = "comboDoctors";
            comboDoctors.Size = new Size(362, 23);
            comboDoctors.TabIndex = 1;
            // 
            // comboPatients
            // 
            comboPatients.FormattingEnabled = true;
            comboPatients.Location = new Point(196, 170);
            comboPatients.Name = "comboPatients";
            comboPatients.Size = new Size(362, 23);
            comboPatients.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(53, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            textBox2.Text = "Doctor:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(53, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 4;
            textBox3.Text = "Patient:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(53, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 5;
            textBox4.Text = "Date:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(53, 271);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 40);
            textBox5.TabIndex = 6;
            textBox5.Text = "Notes:";
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookAppointment.Location = new Point(303, 341);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(75, 32);
            btnBookAppointment.TabIndex = 7;
            btnBookAppointment.Text = "Book";
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(397, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(196, 214);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(362, 23);
            dtpAppointmentDate.TabIndex = 9;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(196, 271);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(362, 40);
            txtNotes.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(483, 341);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 11;
            btnBack.Text = "Close";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(btnBack);
            Controls.Add(txtNotes);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(btnClear);
            Controls.Add(btnBookAppointment);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboPatients);
            Controls.Add(comboDoctors);
            Controls.Add(textBox1);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboDoctors;
        private ComboBox comboPatients;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnBookAppointment;
        private Button btnClear;
        private DateTimePicker dtpAppointmentDate;
        private TextBox txtNotes;
        private Button btnBack;
    }
}