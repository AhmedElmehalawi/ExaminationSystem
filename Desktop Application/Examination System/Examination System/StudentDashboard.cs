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
    public partial class StudentDashboard : Form
    {
        public static int i;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataRow dr;

        string stdId;
        string exId;
        string res;
        int total;
        public StudentDashboard(string _stdId)
        {
            stdId = _stdId;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            /* SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True");
             con.Open();
             SqlCommand cmd = new SqlCommand("select top(6) QBody from Questions where QType = 'MC' order by NEWID()",con); //changes and you put sql code here ("Sql Code")
             cmd.ExecuteNonQuery(); //Changes according to sql command type 
             con.Close();*/
        }


        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            btu2.Visible = false;
            btu3.Visible = false;
            groupBox1.Visible = false;
            submitbtn.Visible= false;




            // var courseName = crsname.SelectedValue;
            // var mcqNumber = mcqcombo.SelectedValue;
            // var tfNumber = tfCombo.SelectedValue;
            // da = new SqlDataAdapter($"generateExam {courseName}  {mcqNumber} {tfNumber}",con);
            //da=new SqlDataAdapter("examQuestionChoice 500",con);
        }

        int mcqNumber;
        int tfNumber;

        private void btu1_Click(object sender, EventArgs e)
        {
            submitbtn.Visible = true;
            label10.Visible = false;
            crsname.Visible = false;
            btu1.Visible = false;
            btu2.Visible = true;
            mcqcombo.Visible = false;
            tfCombo.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = true;
            con.Open();
            var courseName = crsname.Text;
            mcqNumber = int.Parse(mcqcombo.Text);
            tfNumber = int.Parse(tfCombo.Text);
            SqlCommand cmd = new SqlCommand("generateExam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@courseName", courseName);
            cmd.Parameters.AddWithValue("@mcQuestionsNumber", mcqNumber);
            cmd.Parameters.AddWithValue("@tfQuestionsNumber", tfNumber);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlCommand examID = new SqlCommand("SELECT TOP(1) ExamID  FROM Exams ORDER BY ExamID DESC", con);
            SqlDataReader sqlDataReader = examID.ExecuteReader();
            sqlDataReader.Read();
            exId = sqlDataReader["ExamID"].ToString();

            da = new SqlDataAdapter($"examQuestionChoice {sqlDataReader["ExamID"]}", con);
            con.Close();
            da?.Fill(dt);




            i = 0;
            dr = dt.Rows[i];

            string[] arr;
            arr = Convert.ToString(dr[2]).Split('-');

            label1.Text = Convert.ToString(dr[1]);
            a.Text = "a. " + arr[0];
            b.Text = "b. " + arr[1];
            c.Text = "c. " + arr[2];
            d.Text = "d. " + arr[3];
        }

        private void btu2_Click(object sender, EventArgs e)
        {

            btu3.Visible = true;
            if (a.Checked)
            {
                ansChosen = 'a';
            }
            else if (b.Checked)
            {
                ansChosen = 'b';
            }
            else if (c.Checked)
            {
                ansChosen = 'c';
            }
            else if (d.Checked)
            {
                ansChosen = 'd';
            }
            studentAnswers[i] = ansChosen;


            if (i == (dt.Rows.Count - 1))
            {
                dr = dt.Rows[0];
                label1.Text = Convert.ToString(dr[1]);
            }
            else
                i++;
            if (i == dt.Rows.Count - 1)
            {
                btu2.Visible = false;
            }
            dr = dt.Rows[i];
            string[] arr;
            arr = Convert.ToString(dr[2]).Split('-');
            if (arr.Length == 3)
            {
                label1.Text = Convert.ToString(dr[1]);
                a.Text = "a. " + arr[0];
                b.Text = "b. " + arr[1];
                c.Visible = false;
                d.Visible = false;

            }
            else
            {
                label1.Text = Convert.ToString(dr[1]);
                a.Text = "a. " + arr[0];
                b.Text = "b. " + arr[1];
                c.Text = "c. " + arr[2];
                d.Text = "d. " + arr[3];
                label1.Text = Convert.ToString(dr[1]);
            }


            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ansChosen = studentAnswers[i];
            switch (ansChosen)
            {
                case 'a':
                    a.Checked = true;
                    break;
                case 'b':
                    b.Checked = true;
                    break;
                case 'c':
                    c.Checked = true;
                    break;
                case 'd':
                    d.Checked = true;
                    break;
            }

        }

        char ansChosen;
        char[] studentAnswers = new char[20];
        //-----------------------------------------------
        //int v = dt.Rows.Count

        //previous btn
        private void btu3_Click(object sender, EventArgs e)
        {
            if (a.Checked)
            {
                ansChosen = 'a';
            }
            else if (b.Checked)
            {
                ansChosen = 'b';
            }
            else if (c.Checked)
            {
                ansChosen = 'c';
            }
            else if (d.Checked)
            {
                ansChosen = 'd';
            }
            studentAnswers[i] = ansChosen;
            btu2.Visible = true;
            if (i == 0)
            {
                dr = dt.Rows[0];
                label1.Text = Convert.ToString(dr[1]);
            }
            else
                i--;

            if (i == 0)
            {
                btu3.Visible = false;
            }

            ansChosen = studentAnswers[i];
            switch (ansChosen)
            {
                case 'a':
                    a.Checked = true;
                    break;
                case 'b':
                    b.Checked = true;
                    break;
                case 'c':
                    c.Checked = true;
                    break;
                case 'd':
                    d.Checked = true;
                    break;
            }
            dr = dt.Rows[i];
            string[] arr;
            c.Visible = true;
            d.Visible = true;
            arr = Convert.ToString(dr[2]).Split('-');
            if (arr.Length == 3)
            {
                label1.Text = Convert.ToString(dr[1]);
                a.Text = "a. " + arr[0];
                b.Text = "b. " + arr[1];
                c.Visible = false;
                d.Visible = false;

            }
            else
            {
                label1.Text = Convert.ToString(dr[1]);
                a.Text = "a. " + arr[0];
                b.Text = "b. " + arr[1];
                c.Text = "c. " + arr[2];
                d.Text = "d. " + arr[3];
                label1.Text = Convert.ToString(dr[1]);
            }
            studentAnswers[i] = ansChosen;



            //studentAnswers.Append(ansChosen);
            studentAnswers[i] = ansChosen;
            //groupBox.Text = $"{studentAnswers.ToString()}";

        }

        private void StudentDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            //btnclose.Click += (o, ex) => this.Close();
        }

        private void b_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (a.Checked)
            {
                ansChosen = 'a';
            }
            else if (b.Checked)
            {
                ansChosen = 'b';
            }
            else if (c.Checked)
            {
                ansChosen = 'c';
            }
            else if (d.Checked)
            {
                ansChosen = 'd';
            }
            studentAnswers[i] = ansChosen;

            con.Open();
            SqlDataAdapter da2;
            DataTable dt2 = new DataTable();
            DataRow dr2;

            da2 = new SqlDataAdapter($"getExamQuesionsIDs {exId}", con);
            con.Close();
            da2?.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dr2 = dt2.Rows[i];
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insertStdA", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Std_id", stdId);
                cmd1.Parameters.AddWithValue("@Exam_id", exId);
                cmd1.Parameters.AddWithValue("@QID", dr2[0]);
                cmd1.Parameters.AddWithValue("@STd_Ans", studentAnswers[i]);
                cmd1.ExecuteReader();
                con.Close();
            }

            con.Open();
            SqlCommand cmd2 = new SqlCommand("correctExam", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@stID", stdId);
            cmd2.Parameters.AddWithValue("@examID", exId);
            cmd2.ExecuteReader();
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("selectStdExRes", con);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@Std_id", stdId);
            cmd3.Parameters.AddWithValue("@Exam_id", exId);
            SqlDataReader sqlDataReader = cmd3.ExecuteReader();
            sqlDataReader.Read();
            res = sqlDataReader["Result"].ToString();
            total = dt2.Rows.Count;

            con.Close();


            Result re = new Result(res, total);
            re.Show();
            this.Hide();

        }
    }
}
