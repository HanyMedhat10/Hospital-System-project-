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
    public partial class patientAndRoom : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7PO0HDQ;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        DataTable DataTabledt = new DataTable();
        public patientAndRoom()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("select room_num \"Room ID\", COUNT(*) \"Number of patients in each room\" from patient\r\ngroup by room_num;", con);
            dataAdapter.Fill(DataTabledt);
            dataGridView1.DataSource = DataTabledt;
        }
    }
}
