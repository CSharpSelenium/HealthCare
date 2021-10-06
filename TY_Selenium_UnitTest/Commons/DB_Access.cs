using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TY_Selenium_UnitTest.Commons
{
   public class DB_Access
    {
        public static void ReadDataFromDataBase(string query)
        {
            SqlConnection connection = new SqlConnection();
            string Query = query;



        }

        public static void WriteDataToDB()
        {

        }
    }
}
