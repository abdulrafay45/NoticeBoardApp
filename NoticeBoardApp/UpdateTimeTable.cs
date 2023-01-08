using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static NoticeBoardApp.DatabaseConnection;

namespace NoticeBoardApp
{
    public partial class ManageTimeTable : Form
    {
        public ManageTimeTable()
        {
            InitializeComponent();
        }

        private int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (dbConn.State == 0)
                {
                    createConn();
                }
                dbCommand.Connection = dbConn;
                dbCommand.CommandType = CommandType.Text;
                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void time_Table()
        {
            SqlCommand insertcommand = new SqlCommand("Insert into TimeTable (Degree, Semester, Monday, Tuesday,Wednesday, Thursday, Friday) values (@Degree, @Semester, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday)", dbConn);
            insertcommand.Parameters.AddWithValue("@Degree", degree.Text);
            insertcommand.Parameters.AddWithValue("@Semester", semester.Text);
            insertcommand.Parameters.AddWithValue("@Monday", monday.Text);
            insertcommand.Parameters.AddWithValue("@Tuesday", tuesday.Text);
            insertcommand.Parameters.AddWithValue("@Wednesday", wednesday.Text);
            insertcommand.Parameters.AddWithValue("@Thursday", thursday.Text);
            insertcommand.Parameters.AddWithValue("@Friday", friday.Text);

            int rows = executeQuery(insertcommand);
            if (rows == 1)
            {
                MessageBox.Show("Added Sucessfully!");
            }
            else
            {
                MessageBox.Show("Connection error! Please try again");
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            time_Table();
        }
    }
}
