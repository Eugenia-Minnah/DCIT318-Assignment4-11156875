using MedicalAppointmentSystem.MedicalApp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentSystem
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            LoadDoctors();
            LoadPatients();
        }
        private void LoadDoctors()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorID, FullName FROM Doctors WHERE Availability=1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboDoctors.DataSource = dt;
                comboDoctors.DisplayMember = "FullName";
                comboDoctors.ValueMember = "DoctorID";
            }
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName FROM Patients", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboPatients.DataSource = dt;
                comboPatients.DisplayMember = "FullName";
                comboPatients.ValueMember = "PatientID";
            }
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes)
                                     VALUES (@DoctorID, @PatientID, @AppointmentDate, @Notes)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", comboDoctors.SelectedValue);
                    cmd.Parameters.AddWithValue("@PatientID", comboPatients.SelectedValue);
                    cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment booked successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNotes.Clear();
            dtpAppointmentDate.Value = DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
