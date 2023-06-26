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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
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

        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();

                string query = "INSERT into Item_TB values('" + txtItem_id.Text + "','" + txt_name.Text + "'," + txt_qty.Text + ",'" + cmb_category.Text + "'," + txt_price.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully");

                populate();
                   con.Close();

                txtItem_id.Clear();
                txt_name.Clear();
                txt_price.Clear();
                txt_qty.Clear();
                cmb_category.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funiture_DBDataSet1.Item_TB' table. You can move, or remove it, as needed.
            this.item_TBTableAdapter.Fill(this.funiture_DBDataSet1.Item_TB);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_item.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                edititem se = new edititem();
                se.Show();

                se.txtitemID.Text = dgv_item.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                se.txtItemName.Text = dgv_item.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                se.txtPrice.Text = dgv_item.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                se.txtqty.Text = dgv_item.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                se.cmb_category.Text = dgv_item.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
              
                this.Hide();


            }
            else if (colName == "Delete")
            {

              deleteItem sd = new deleteItem();
                sd.Show();
                sd.lblitemid.Text = dgv_item.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                sd.lblIname.Text = dgv_item.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                sd.lblprice.Text = dgv_item.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                sd.lblqty.Text = dgv_item.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                sd.lblcate.Text = dgv_item.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
               
                this.Hide();



            }
        }
    }
}
