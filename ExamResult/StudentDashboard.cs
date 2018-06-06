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
namespace ExamResult
{
    public partial class StudentDashboard : Form
    {
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Integrated Security=True");
            sd = new SqlDataAdapter(@"SELECT ID,Semister,CourseName,CourseCode,CREDIT,Grade,GPA FROM studentResult WHERE ID = '" + textBox1.Text + "'", con);
            dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
