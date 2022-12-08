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
    public partial class totalAnnualBudget : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        public totalAnnualBudget()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select SUM(D.Salary*12)+SUM(R.cost) \"Total annual budget for specific surgeries\" from patient P , Rooms R , supervise S ,Doctors D \r\nwhere P.Pat#=S.pat# and S.D#=D.D# and D.departmenrt_num = 1;", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
