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
using System.Configuration;

namespace Examination_System
{
    public partial class StdExamResult : Form
    {
        public StdExamResult()
        {
            InitializeComponent();
        }

        private void StdExamResult_Load(object sender, EventArgs e)
        {

            this.BindGrid();

            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from Students");
            //StdDataGrid.DataSource = cmd;
        }

        private void BindGrid()
        {
            //int Id = Convert.ToInt32(IdTxt.ToString());

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from StdExamResults"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            StdExamResGrid.DataSource = dt;

                        }
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void StdExamResGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
    
}
