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
using static NoticeBoardApp.DatabaseConnection;

namespace NoticeBoardApp
{
    public partial class SignUp : Form
    {
        public SignUp()
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
        private void Sign_Up()
        {
            SqlCommand insertcommand = new SqlCommand("Insert into UserLogin (username, password, email, name) values (@username, @pass , @mail, @name)", dbConn);
            insertcommand.Parameters.AddWithValue("@username", username.Text);
            insertcommand.Parameters.AddWithValue("@pass", password.Text);
            insertcommand.Parameters.AddWithValue("@mail", email.Text);
            insertcommand.Parameters.AddWithValue("@name", name.Text);

            int rows = executeQuery(insertcommand);
            if (rows == 1)
            {
                MessageBox.Show("Account registered Sucessfully!");
            }
            else
            {
                MessageBox.Show("Connection error! Please try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_Up();
        }
    }
}
