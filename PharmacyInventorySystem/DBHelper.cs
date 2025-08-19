using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventorySystem
{
    public static class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["PharmacyDBConn"].ConnectionString;
            return new SqlConnection(connString);
        }
    }
}
