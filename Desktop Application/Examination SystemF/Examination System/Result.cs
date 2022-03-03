using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Result : Form
    {
        int res;
        int total;
        public Result(string _res, int _total)

        {
            InitializeComponent();
            res = int.Parse(_res);
            total = _total;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resLabel_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (res > total / 2)
            {
                label1.Text = "Conguratulations You have passed the Exam";
            }
            else
            {
                label1.Text = "Sorry, You have not passed the Exam";
            }
            resLabel.Text = $"{res}";
            totalbtn.Text = $"{total}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
