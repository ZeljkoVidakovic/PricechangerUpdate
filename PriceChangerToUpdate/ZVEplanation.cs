using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PriceChanger
{
    public partial class ZVEplanation : Form
    {
        private DataGridView dataGridViewClear1;

        public ZVEplanation()
        {
            InitializeComponent();

            dataGridViewClear1 = new DataGridView();
            dataGridViewClear1.Dock = DockStyle.Fill;
            dataGridViewClear1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(dataGridViewClear1);

            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection cn = new SqlConnection(modMain.gsAppConnection))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM NewProducts", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewClear1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}