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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "INSERT into Supplier_TB values('" + txt_supID.Text + "','" + txtUsername.Text + "','" + txt_SUPemail.Text + "','" + txt_SUPMobile.Text + "','" + txt_SupCompny.Text + "','" + txt_Address.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Saved Successfully");
                con.Close();

                populate();
                txt_supID.Clear();
                txtUsername.Clear();
                txt_SUPMobile.Clear();
                txt_SupCompny.Clear();
                txt_Address.Clear();
                txt_SUPemail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void populate()
        {


            con.Open();

            string selectQuery = $"SELECT * FROM Supplier_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_sup.DataSource = dataTable;

            con.Close();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funiture_DBDataSet.Supplier_TB' table. You can move, or remove it, as needed.
            this.supplier_TBTableAdapter.Fill(this.funiture_DBDataSet.Supplier_TB);
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_supID.Clear();
            txtUsername.Clear();
            txt_SUPMobile.Clear();
            txt_SupCompny.Clear();
            txt_Address.Clear();
            txt_SUPemail.Clear();
        }

        private void dgv_sup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_sup.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                
                EditSup es = new EditSup();
                es.Show();

                es.txt_supID1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                es.txtUsername1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                es.txt_SupCompny1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                es.txt_SUPMobile1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                es.txt_SUPemail1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                es.txt_Address1.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[7].Value.ToString();
                this.Hide();


            }
            else if (colName == "Delete")
            {

                DeleteSup ds = new DeleteSup();
                ds.Show();
                ds.lbl_supid.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                ds.lbl_name.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                ds.lbl_cmpny.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                ds.lbl_email.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                ds.lbl_mobile.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                ds.lbl_address.Text = dgv_sup.Rows[(int)e.RowIndex].Cells[7].Value.ToString();
                this.Hide();



            }
        }
    }
}
