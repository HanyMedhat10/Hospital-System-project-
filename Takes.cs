using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Takes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        SqlCommandBuilder cmd;
        public Takes()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select t.Patient_num, p.name ,t.Med_code,m.name \"Medicine Name \",t.quantity,m.price from takes t, patient p, medicine m\r\nwhere p.Pat#=t.Patient_num and t.Med_code=m.code;", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(DataTabledt);
                MessageBox.Show("Passed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTabledt.Rows.Clear();
                dataAdapter = new SqlDataAdapter("select t.Patient_num, p.name ,t.Med_code,m.name \"Medicine Name \",t.quantity,m.price from takes t, patient p, medicine m\r\nwhere p.Pat#=t.Patient_num and t.Med_code=m.code;", con);
                dataAdapter.Fill(DataTabledt);
                dataGridView1.DataSource = DataTabledt;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Search = textBox1.Text;
            if (string.IsNullOrEmpty(Search))
            {
                MessageBox.Show("Fail", "Operation Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTabledt.Rows.Clear();
            dataAdapter = new SqlDataAdapter("select t.Patient_num, p.name ,t.Med_code,m.name \"Medicine Name \",t.quantity,m.price from takes t, patient p, medicine m\r\nwhere p.Pat#=t.Patient_num and t.Med_code=m.code and p.Pat#=" + Search + ";", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
