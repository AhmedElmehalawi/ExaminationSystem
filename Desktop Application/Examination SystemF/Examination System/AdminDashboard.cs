using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examination_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstructorsData InsD = new InstructorsData();
            InsD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsDataReport sda = new StudentsDataReport();
            sda.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StdExamResult ser = new StdExamResult();
            ser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseTopics Ct =  new CourseTopics();
            Ct.Show();
            this.Hide();
        }
    }
}
