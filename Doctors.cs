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
    public partial class Doctors : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        SqlCommandBuilder cmd;
        public Doctors()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("Select * from Doctors", con);
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
                dataAdapter = new SqlDataAdapter("Select * from Doctors", con);
                dataAdapter.Fill(DataTabledt);
                dataGridView1.DataSource = DataTabledt;


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Serach = textBox1.Text;
            DataTabledt.Rows.Clear();
            dataAdapter = new SqlDataAdapter("Select * from Doctors where D#="+Serach+";", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;


        }


    
    }
}
