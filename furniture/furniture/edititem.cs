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
    public partial class edititem : Form
    {
        public edititem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void edititem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funiture_DBDataSet1.Item_TB' table. You can move, or remove it, as needed.
            this.item_TBTableAdapter.Fill(this.funiture_DBDataSet1.Item_TB);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                string query = "UPDATE Item_TB SET Name='" + txtItemName.Text + "' ,qty='" + txtqty.Text + "' ,category='" + cmb_category.Text + "',price='" + txtPrice.Text + "' WHERE itemid='" + txtitemID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Update Successfully");

                con.Close();
                this.Close();

                Category cs = new Category();
                cs.Show();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

            Category cs = new Category();
            cs.Show();

        }
    }
}
