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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login_all WHERE USERNAME ='" + textBox1.Text + "' and PASSWORD= '" + textBox2.Text + "' and STATUS = '1' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("successfully login");
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();


            }
            else
            {
                MessageBox.Show("Incorrect Username or Password !!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
