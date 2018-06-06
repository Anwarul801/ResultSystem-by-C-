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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String valuesStatus = "1";
                SqlConnection con = new SqlConnection(@"Data Source=(local);Integrated Security=True");
                SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO login_all VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + valuesStatus + "')", con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                MessageBox.Show("Successfully New Admin Registered ");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Something wrong or you entered a admin username that is already registered !");
            }
            


        }
    }
}
