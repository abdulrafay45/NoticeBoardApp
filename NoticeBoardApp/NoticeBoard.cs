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
    public partial class NoticeBoard : Form
    {
        public NoticeBoard()
        {
            InitializeComponent();
        }

        Viewtimetable tm=new Viewtimetable();
        private void TimeTable_Click(object sender, EventArgs e)
        {
            tm.Show();
        }
    }
}
