using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardApp
{
    public class DatabaseConnection
    {
        public static SqlConnection dbConn = new SqlConnection(@"Data Source=abdul-pc\sqlexpress;Initial Catalog=NoticeBoard;Integrated Security=True");

        public static void createConn()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    //dbConn.ConnectionString = strConnstring;
                    dbConn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
