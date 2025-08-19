namespace MedicalAppointmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            new DoctorListForm().ShowDialog();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            new AppointmentForm().ShowDialog();
        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            new ManageAppointmentsForm().ShowDialog();
        }
    }
}
