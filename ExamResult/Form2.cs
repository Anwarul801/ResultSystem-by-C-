using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamResult
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent addstudent = new addstudent();
            addstudent.Show();
        }

        private void vIEWAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allstudent all = new allstudent();
            all.Show();
        }

        private void addResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addResult result = new addResult();
            result.Show();
        }

        private void editResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addResult result = new addResult();
            result.Show();
        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addResult result = new addResult();
            result.Show();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin admin = new AddAdmin();
            admin.Show();
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRegistration course = new CourseRegistration();
            course.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstudent add = new addstudent();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allstudent add = new allstudent();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseRegistration add = new CourseRegistration();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addResult add = new addResult();
            add.Show();
        }
    }
}
