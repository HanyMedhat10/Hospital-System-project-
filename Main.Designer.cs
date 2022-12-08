namespace Hospital_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exmineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.docToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Hospital_System.Properties.Resources.st_christophers_hospital_loop_16x9;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.medicineToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.labToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.doctorsToolStripMenuItem1,
            this.patientToolStripMenuItem1,
            this.roomToolStripMenuItem1});
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.doctorsToolStripMenuItem.Text = "Main";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.medicineToolStripMenuItem.Text = "Medicine";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // labToolStripMenuItem
            // 
            this.labToolStripMenuItem.Name = "labToolStripMenuItem";
            this.labToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.labToolStripMenuItem.Text = "Lab";
            this.labToolStripMenuItem.Click += new System.EventHandler(this.labToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem1
            // 
            this.doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            this.doctorsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.doctorsToolStripMenuItem1.Text = "Doctors";
            this.doctorsToolStripMenuItem1.Click += new System.EventHandler(this.doctorsToolStripMenuItem1_Click);
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.patientToolStripMenuItem1.Text = "Patient";
            this.patientToolStripMenuItem1.Click += new System.EventHandler(this.patientToolStripMenuItem1_Click);
            // 
            // roomToolStripMenuItem1
            // 
            this.roomToolStripMenuItem1.Name = "roomToolStripMenuItem1";
            this.roomToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.roomToolStripMenuItem1.Text = "Room";
            this.roomToolStripMenuItem1.Click += new System.EventHandler(this.roomToolStripMenuItem1_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takesToolStripMenuItem,
            this.exmineToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.patientToolStripMenuItem.Text = "Query";
            // 
            // takesToolStripMenuItem
            // 
            this.takesToolStripMenuItem.Name = "takesToolStripMenuItem";
            this.takesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takesToolStripMenuItem.Text = "Takes";
            this.takesToolStripMenuItem.Click += new System.EventHandler(this.takesToolStripMenuItem_Click);
            // 
            // exmineToolStripMenuItem
            // 
            this.exmineToolStripMenuItem.Name = "exmineToolStripMenuItem";
            this.exmineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exmineToolStripMenuItem.Text = "Exmine";
            this.exmineToolStripMenuItem.Click += new System.EventHandler(this.exmineToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roomsToolStripMenuItem.Text = "Supervise";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem1
            // 
            this.medicineToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docToolStripMenuItem,
            this.panToolStripMenuItem,
            this.doctorsSalaryToolStripMenuItem,
            this.totalToolStripMenuItem});
            this.medicineToolStripMenuItem1.Name = "medicineToolStripMenuItem1";
            this.medicineToolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.medicineToolStripMenuItem1.Text = "Report";
            this.medicineToolStripMenuItem1.Click += new System.EventHandler(this.medicineToolStripMenuItem1_Click);
            // 
            // docToolStripMenuItem
            // 
            this.docToolStripMenuItem.Name = "docToolStripMenuItem";
            this.docToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.docToolStripMenuItem.Text = "Doctors and  Department";
            this.docToolStripMenuItem.Click += new System.EventHandler(this.docToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.panToolStripMenuItem.Text = "Patent and Rooms";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // doctorsSalaryToolStripMenuItem
            // 
            this.doctorsSalaryToolStripMenuItem.Name = "doctorsSalaryToolStripMenuItem";
            this.doctorsSalaryToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.doctorsSalaryToolStripMenuItem.Text = "Doctors\' Salary";
            this.doctorsSalaryToolStripMenuItem.Click += new System.EventHandler(this.doctorsSalaryToolStripMenuItem_Click);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.totalToolStripMenuItem.Text = " Total annual budget";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem doctorsToolStripMenuItem;
        private ToolStripMenuItem medicineToolStripMenuItem;
        private ToolStripMenuItem labToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem takesToolStripMenuItem;
        private ToolStripMenuItem exmineToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem medicineToolStripMenuItem1;
        private ToolStripMenuItem doctorsToolStripMenuItem1;
        private ToolStripMenuItem patientToolStripMenuItem1;
        private ToolStripMenuItem roomToolStripMenuItem1;
        private ToolStripMenuItem docToolStripMenuItem;
        private ToolStripMenuItem panToolStripMenuItem;
        private ToolStripMenuItem doctorsSalaryToolStripMenuItem;
        private ToolStripMenuItem totalToolStripMenuItem;
    }
}