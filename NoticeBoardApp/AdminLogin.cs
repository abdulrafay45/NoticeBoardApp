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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        ManageNoticeBoard manageNoticeBoard=new ManageNoticeBoard();
        private void adminLogin()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AdminLogin WHERE Username='" + username.Text + "' AND Password='" + password.Text + "'", dbConn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                manageNoticeBoard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            adminLogin();
        }
    }
}
