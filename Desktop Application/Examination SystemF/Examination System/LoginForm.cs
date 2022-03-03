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
    public partial class LoginForm : Form
    {
        SqlConnection con= new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;

        string stdId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
 
           
            wrongLabel.Visible = false;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtpass.PasswordChar = '\0';
                checkBox2.Text = "Hide Password";

            }
            else
            {
                txtpass.PasswordChar = '*';
                checkBox2.Text = "Show Password";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            wrongLabel.Visible = false;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Admin"  && txtpass.Text == "Admin" )
            {
                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Hide();
            }

            else
            {
                string query = "select StudentID,NationalID from Students where NationalID ='" + txtpass.Text.Trim() + "'and StudentID ='" + txtUserName.Text.Trim() + "'";
                sda = new SqlDataAdapter(query, con);
                Console.WriteLine(sda.ToString());
                dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1)
                {

                    stdId = txtUserName.Text.Trim();
                    StudentDashboard sd = new StudentDashboard(stdId);
               

                    this.Hide();
                sd.Show();
                }
                else
                {
                    MessageBox.Show("UserName Or Password is Invalid!");
                }

            }


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
