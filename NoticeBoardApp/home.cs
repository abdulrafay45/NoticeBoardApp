using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeBoardApp
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private AdminLogin adminLoginPage=new AdminLogin();
        private UserLogin userLoginPage=new UserLogin();

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            adminLoginPage.Show();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            userLoginPage.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
