using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }



        private void takesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Takes takes = new Takes();
            takes.ShowDialog();
        }

        private void labToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lab lab = new Lab();
            lab.ShowDialog();   
        }

        private void exmineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exmine exmine = new Exmine();
            exmine.ShowDialog();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Supervise supervise = new Supervise();
            supervise.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.ShowDialog();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.ShowDialog();
        }

        private void takesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Takes takes = new Takes();
            takes.ShowDialog();
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Department department =new Department();
            department.ShowDialog();
        }

        private void exmineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exmine exmine = new Exmine();
            exmine.ShowDialog();
        }

        private void superviseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supervise supervise = new Supervise();
            supervise.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorsAndDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            TbyDepNo tbyDepNo = new TbyDepNo();
            tbyDepNo.ShowDialog();
        }

        private void patientAndRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientAndRoom patientAndRoom = new patientAndRoom();
            patientAndRoom.ShowDialog();
        }

        private void doctorsSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsSalaries doctorsSalaries = new DoctorsSalaries();
                doctorsSalaries.ShowDialog();

        }

        private void totalAnnualBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalAnnualBudget totalAnnualBudget = new totalAnnualBudget();
                totalAnnualBudget.ShowDialog();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ShowDialog();
        }

        private void labToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab lab = new Lab();
            lab.ShowDialog();
        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
                doctors.ShowDialog();
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(); 
            patient.ShowDialog();
        }

        private void roomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalAnnualBudget totalAnnualBudget = new totalAnnualBudget();
            totalAnnualBudget.ShowDialog();
        }

        private void docToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TbyDepNo tbyDepNo = new TbyDepNo();
            tbyDepNo.ShowDialog();
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientAndRoom patientAndRoom = new patientAndRoom();
            patientAndRoom.ShowDialog();
        }

        private void doctorsSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsSalaries doctorsSalaries = new DoctorsSalaries();
            doctorsSalaries.ShowDialog();
        }

   
    }
}
