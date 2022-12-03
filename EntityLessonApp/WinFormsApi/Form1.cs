namespace WinFormsApi
{
    public partial class Form1 : Form
    {
        MySqlTesting sqlTesting = new MySqlTesting();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlTesting.DataTable();
        }
    }
}