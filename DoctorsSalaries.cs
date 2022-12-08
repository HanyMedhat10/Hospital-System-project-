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
    public partial class DoctorsSalaries : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        
        public DoctorsSalaries()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select SUM(Salary) \"Total payments for doctors’ salaries\" from  Doctors;", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
