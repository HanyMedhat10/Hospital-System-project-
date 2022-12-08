namespace Hospital_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            if (username == "admin" && pass == "admin")
            {
                Main main= new Main();
                main.Show();
            }
            else if (username==""||pass=="")
            {
                MessageBox.Show("Please Enter User Name and Password ");
            }
            else { MessageBox.Show("Invalid Login"); }
        }
    }
}