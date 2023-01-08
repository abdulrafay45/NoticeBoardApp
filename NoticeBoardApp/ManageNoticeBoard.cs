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
    public partial class ManageNoticeBoard : Form
    {
        public ManageNoticeBoard()
        {
            InitializeComponent();
        }

       ManageEvents events=new ManageEvents();
       UpdateTimeTable timeTable=new UpdateTimeTable();

        private void button1_Click(object sender, EventArgs e)
        {
            //events.Show();
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            timeTable.Show();
            
        }
    }
}
