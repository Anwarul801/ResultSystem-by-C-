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
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String valuesStatus = "0";
                SqlConnection con = new SqlConnection(@"Data Source=(local);Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter(@"INSERT INTO [Student Info]
                         (ID, Name, Department, Semester, [Date Of Birth], Sex, Address, [Blood Group], Nationality)
VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                SqlDataAdapter sda2 = new SqlDataAdapter(@"INSERT INTO login_all VALUES('"+textBox1.Text+"','"+textBox1.Text+"','"+valuesStatus+"')",con);
                sda2.Fill(dt);

                //SqlDataAdapter ss1 = new SqlDataAdapter("SELECT COUNT(Id) FROM StudentResult", con);
               // ss1.Fill(dt);
                

                SqlDataAdapter sda3 = new SqlDataAdapter(@"INSERT INTO studentResult VALUES('"+textBox1.Text+"','','','','','','')", con);
                sda3.Fill(dt);
                SqlDataAdapter sda4 = new SqlDataAdapter(@"INSERT INTO studentResult VALUES('" + textBox1.Text + "','','','','','','')", con);
                sda4.Fill(dt);
                SqlDataAdapter sda5 = new SqlDataAdapter(@"INSERT INTO studentResult VALUES('" + textBox1.Text + "','','','','','','')", con);
                sda5.Fill(dt);
                SqlDataAdapter sda6 = new SqlDataAdapter(@"INSERT INTO studentResult VALUES('" + textBox1.Text + "','','','','','','')", con);
                sda6.Fill(dt);
                MessageBox.Show("Sucessfully Registered a new student");
            }
            catch (Exception ex)
            {
                MessageBox.Show("You enterd a id that is allready associated with a student !!");
            }
        }
    }
}
