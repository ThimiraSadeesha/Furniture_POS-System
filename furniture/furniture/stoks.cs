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

namespace furniture
{
    public partial class stoks : Form
    {
        public stoks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void stoks_Load(object sender, EventArgs e)
        {
            populate();
            // TODO: This line of code loads data into the 'funiture_DBDataSet1.Item_TB' table. You can move, or remove it, as needed.
            this.item_TBTableAdapter.Fill(this.funiture_DBDataSet1.Item_TB);

        }
        public void populate()
        {


            con.Open();

            string selectQuery = $"SELECT * FROM Item_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_item.DataSource = dataTable;

            con.Close();
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            cashier cs = new cashier();
            cs.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemTBBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
