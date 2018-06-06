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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login_all WHERE USERNAME ='"+textBox1.Text+"' and PASSWORD= '"+textBox2.Text+"' and STATUS = '0' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("successfully login");
                this.Hide();
                StudentDashboard ss = new StudentDashboard();
                ss.Show();
                

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password !!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
        }
    }
}
