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
    public partial class CourseRegistration : Form
    {
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;
        public CourseRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Integrated Security=True");
            sd = new SqlDataAdapter(@"SELECT ID,Semister,CourseName,CourseCode,CREDIT,TOKEN FROM studentResult WHERE ID = '" + textBox1.Text + "'", con);
            dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sc = new SqlCommandBuilder(sd);
                sd.Update(dt);
                MessageBox.Show("Updated");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CourseRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
