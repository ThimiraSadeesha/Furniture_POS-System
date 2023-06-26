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
    public partial class records : Form
    {
        public records()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void records_Load(object sender, EventArgs e)
        {
            populate();
            // TODO: This line of code loads data into the 'funiture_DBDataSet2.Transaction_TB' table. You can move, or remove it, as needed.
            this.transaction_TBTableAdapter.Fill(this.funiture_DBDataSet2.Transaction_TB);

        }
        public void populate()
        {


            con.Open();

            string selectQuery = $"SELECT * FROM Transaction_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvtrans.DataSource = dataTable;

            con.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashborad ds = new Dashborad();
            ds.Show();
        }
    }
}
