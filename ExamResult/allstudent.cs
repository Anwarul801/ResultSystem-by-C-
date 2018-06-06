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
    public partial class allstudent : Form
    {
        SqlDataAdapter sd;
        SqlCommandBuilder sc;
        DataTable dt;
        public allstudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Integrated Security=True");
            sd = new SqlDataAdapter(@"SELECT [Student Info]. * FROM [Student Info]",con);
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
                MessageBox.Show("updated !!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("error!");
            }
        }
    }
}
