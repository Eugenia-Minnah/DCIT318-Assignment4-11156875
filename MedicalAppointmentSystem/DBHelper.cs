using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace MedicalAppointmentSystem
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

    namespace MedicalApp
    {
        public static class DBHelper
        {
            public static SqlConnection GetConnection()
            {
                string connString = ConfigurationManager.ConnectionStrings["MedicalDBConn"].ConnectionString;
                return new SqlConnection(connString);
            }
        }
    }

}
