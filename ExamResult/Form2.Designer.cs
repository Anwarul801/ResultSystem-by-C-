namespace ExamResult
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWAllStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.rESULTToolStripMenuItem,
            this.courseRegistrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.addAdminToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.addToolStripMenuItem.Text = "ADD";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAdminToolStripMenuItem.Image")));
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWAllStudentToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // vIEWAllStudentToolStripMenuItem
            // 
            this.vIEWAllStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWAllStudentToolStripMenuItem.Image")));
            this.vIEWAllStudentToolStripMenuItem.Name = "vIEWAllStudentToolStripMenuItem";
            this.vIEWAllStudentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vIEWAllStudentToolStripMenuItem.Text = "VIEW All Student";
            this.vIEWAllStudentToolStripMenuItem.Click += new System.EventHandler(this.vIEWAllStudentToolStripMenuItem_Click);
            // 
            // rESULTToolStripMenuItem
            // 
            this.rESULTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResultToolStripMenuItem,
            this.editResultToolStripMenuItem,
            this.viewResultToolStripMenuItem});
            this.rESULTToolStripMenuItem.Name = "rESULTToolStripMenuItem";
            this.rESULTToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.rESULTToolStripMenuItem.Text = "RESULT";
            // 
            // addResultToolStripMenuItem
            // 
            this.addResultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addResultToolStripMenuItem.Image")));
            this.addResultToolStripMenuItem.Name = "addResultToolStripMenuItem";
            this.addResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addResultToolStripMenuItem.Text = "Add Result";
            this.addResultToolStripMenuItem.Click += new System.EventHandler(this.addResultToolStripMenuItem_Click);
            // 
            // editResultToolStripMenuItem
            // 
            this.editResultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editResultToolStripMenuItem.Image")));
            this.editResultToolStripMenuItem.Name = "editResultToolStripMenuItem";
            this.editResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editResultToolStripMenuItem.Text = "Edit Result";
            this.editResultToolStripMenuItem.Click += new System.EventHandler(this.editResultToolStripMenuItem_Click);
            // 
            // viewResultToolStripMenuItem
            // 
            this.viewResultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewResultToolStripMenuItem.Image")));
            this.viewResultToolStripMenuItem.Name = "viewResultToolStripMenuItem";
            this.viewResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewResultToolStripMenuItem.Text = "View Result";
            this.viewResultToolStripMenuItem.Click += new System.EventHandler(this.viewResultToolStripMenuItem_Click);
            // 
            // courseRegistrationToolStripMenuItem
            // 
            this.courseRegistrationToolStripMenuItem.Name = "courseRegistrationToolStripMenuItem";
            this.courseRegistrationToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.courseRegistrationToolStripMenuItem.Text = "COURSE REGISTRATION";
            this.courseRegistrationToolStripMenuItem.Click += new System.EventHandler(this.courseRegistrationToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 347);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "View All Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Course Registration";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Result";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 389);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWAllStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseRegistrationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}