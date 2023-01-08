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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static NoticeBoardApp.DatabaseConnection;

namespace NoticeBoardApp
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        SignUp signUp=new SignUp();
        NoticeBoard noticeBoard=new NoticeBoard();
        private void login()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserLogin WHERE username='" + username.Text + "' AND password='" + password.Text + "'", dbConn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                noticeBoard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignupBTN_Click(object sender, EventArgs e)
        {
            signUp.Show();
        }
    }
}
