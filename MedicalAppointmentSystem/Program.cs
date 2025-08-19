using MedicalAppointmentSystem.MedicalApp;

namespace MedicalAppointmentSystem
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
           
            Application.Run(new MainForm());
            DBHelper.GetConnection();
        }
    }
}