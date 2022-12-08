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
    public partial class Supervise : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        SqlCommandBuilder cmd;
        public Supervise()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("\r\nselect S.D# \"Doctor Id\",D.name \"Doctor Name\",S.Pat# \"Patient Id\" ,P.name \"Patient Name\",admit_date,discharge_date\r\nfrom Doctors D , patient P , supervise S\r\nwhere D.D#=S.D# and P.Pat#=S.pat#;",con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource= DataTabledt;
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
                dataAdapter = new SqlDataAdapter("select S.D# \"Doctor Id\",D.name \"Doctor Name\",S.Pat# \"Patient Id\" ,P.name \"Patient Name\",admit_date,discharge_date\r\nfrom Doctors D , patient P , supervise S\r\nwhere D.D#=S.D# and P.Pat#=S.pat#;", con);
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
            dataAdapter = new SqlDataAdapter("\r\nselect S.D# \"Doctor Id\",D.name \"Doctor Name\",S.Pat# \"Patient Id\" ,P.name \"Patient Name\",admit_date,discharge_date\r\nfrom Doctors D " +
                ", patient P , supervise S\r\nwhere D.D#=S.D# and P.Pat#=S.pat# and P.Pat#=" + Search + ";", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
