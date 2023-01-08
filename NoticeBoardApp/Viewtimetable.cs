using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NoticeBoardApp.DatabaseConnection;


namespace NoticeBoardApp
{
    public partial class Viewtimetable : Form
    {
        public Viewtimetable()
        {
            InitializeComponent();

        }




        private void Viewtimetable_Load(object sender, EventArgs e)
        {

            SqlCommand DbCommand = new SqlCommand("SELECT Monday,Tuesday,Wednesday,Thursday,Friday FROM TimeTable where Semester=4", dbConn);

            SqlDataAdapter ds = new SqlDataAdapter(DbCommand);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            dataGridView1.DataSource = dt;

        }
       


        }


        /* string connectionString = @"Data Source=abdul-pc\\sqlexpress;Initial Catalog=NoticeBoard;Integrated Security=True";
         SqlConnection connection = new SqlConnection(connectionString);
         SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT Monday,Tuesday,Wednesday,Thursday,Friday FROM TimeTable where Semester=4", connection);
         void createConn()
         {
             try
             {
                 if (connection.State != ConnectionState.Open)
                 {
                     //dbConn.ConnectionString = strConnstring;
                     connection.Open();
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             DataSet ds = new DataSet();
             dataadapter.Fill(ds, "TimeTable");
             connection.Close();
             dataGridView1.DataSource = ds;
             dataGridView1.DataMember = "TimeTable"; */


    }
    


