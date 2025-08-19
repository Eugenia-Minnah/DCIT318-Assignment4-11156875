namespace MedicalAppointmentSystem
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
            btnDoctorList = new Button();
            btnBookAppointment = new Button();
            btnManageAppointments = new Button();
            SuspendLayout();
            // 
            // btnDoctorList
            // 
            btnDoctorList.Location = new Point(154, 99);
            btnDoctorList.Name = "btnDoctorList";
            btnDoctorList.Size = new Size(171, 43);
            btnDoctorList.TabIndex = 0;
            btnDoctorList.Text = "View Doctors";
            btnDoctorList.UseVisualStyleBackColor = true;
            btnDoctorList.Click += btnDoctorList_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Location = new Point(154, 163);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(171, 43);
            btnBookAppointment.TabIndex = 1;
            btnBookAppointment.Text = "Book Appointment";
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnManageAppointments
            // 
            btnManageAppointments.Location = new Point(156, 235);
            btnManageAppointments.Name = "btnManageAppointments";
            btnManageAppointments.Size = new Size(169, 43);
            btnManageAppointments.TabIndex = 2;
            btnManageAppointments.Text = "Manage Appointment";
            btnManageAppointments.UseVisualStyleBackColor = true;
            btnManageAppointments.Click += btnManageAppointments_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 497);
            Controls.Add(btnManageAppointments);
            Controls.Add(btnBookAppointment);
            Controls.Add(btnDoctorList);
            Name = "MainForm";
            Text = "Main Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoctorList;
        private Button btnBookAppointment;
        private Button btnManageAppointments;
    }
}
