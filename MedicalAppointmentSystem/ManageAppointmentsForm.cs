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
    public partial class ManageAppointmentsForm : Form
    {
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void btnLoadAppointments_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Appointments", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Appointments");
                dgvAppointments.DataSource = ds.Tables["Appointments"];
            }
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int id = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value;
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Appointments SET AppointmentDate=@Date WHERE AppointmentID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Date", dtpNewDate.Value);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment updated!");
                }
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int id = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value;
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Appointments WHERE AppointmentID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment deleted!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
