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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }
        Viewtimetable view_Time_Table = new Viewtimetable();
        private void viewTimeTable_Click(object sender, EventArgs e)
        {
            view_Time_Table.Show();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            degreeCombo.Items.Add("Software Engineering(Morning)");
            semesterCombo.Items.Add("5th Semester");
        }
    }
}
