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
    public partial class calculate : Form
    {
        public calculate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void calculate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funiture_DBDataSet1.Item_TB' table. You can move, or remove it, as needed.
            this.item_TBTableAdapter.Fill(this.funiture_DBDataSet1.Item_TB);
            DateTime currentDateTime = DateTime.Now;
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            cal();

            try
             {
                con.Open();

                string selectQuery = $"SELECT qty FROM Item_TB WHERE Name = '{cmbItems.Text}'";
                SqlCommand command = new SqlCommand(selectQuery, con);

                int currentQty = 0;

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int qty))
                {
                    currentQty = qty;
                }


                string query = "INSERT into Transaction_TB values('" + txtcusname.Text + "','" + txtmobile.Text + "','" + cmbItems.Text + "'," + txtqty.Text + "," + txtprice.Text + ",'" + txtwrnty.Text + "'," + lbltotal.Text + ")";
                 SqlCommand cmd = new SqlCommand(query, con);
                 cmd.ExecuteNonQuery();
                int reqQty = int.Parse(txtqty.Text);


                int remQty = currentQty - reqQty;
                string updquery = "UPDATE Item_TB SET qty=" + remQty + " WHERE Name='" + cmbItems.Text + "'";
                SqlCommand cmdt = new SqlCommand(updquery, con);
                cmdt.ExecuteNonQuery();
                MessageBox.Show("Purchsed Successfully");
                con.Close();


               /*  txtwrnty.Clear();
                 txtqty.Clear();
                 txtprice.Clear();
                 txtmobile.Clear();
                 txtcusname.Clear();
                 cmbItems.SelectedItem = null;*/
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }


        }
        public void getitems()
        {

            con.Open();
            string selectQuery = $"SELECT price FROM Item_TB WHERE Name = '{cmbItems.Text}'";
            SqlCommand command = new SqlCommand(selectQuery, con);

            object result = command.ExecuteScalar();
            double price = 0.0;

            if (result != null && double.TryParse(result.ToString(), out double parsedPrice))
            {
                price = parsedPrice;
            }

            string formattedPrice = price.ToString();
            txtprice.Text = formattedPrice;
            con.Close();


        }
        public void cal()
        {
            string priceText = txtprice.Text;
            string qtyText = txtqty.Text;

            double price;
            int qty;
            double total;
            
            if (double.TryParse(priceText, out price) && int.TryParse(qtyText, out qty))
            {
                total = qty * price;
                string formattedTotal = total.ToString();
                lbltotal.Text = formattedTotal;
            }

        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            getitems();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

            getitems();
            cal();
            bill bl = new bill();
            bl.Show();
            bl.lblcusname.Text = txtcusname.Text;
            bl.lblprice.Text = txtprice.Text;
            bl.lblproduct.Text = cmbItems.Text;
            bl.lblqty.Text = txtqty.Text;
            bl.lblwrnty.Text = txtwrnty.Text;
            bl.lbltotall.Text = lbltotal.Text;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            cashier cs = new cashier();
            cs.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            txtwrnty.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtmobile.Clear();
            txtcusname.Clear();
            cmbItems.SelectedItem = null;
        }
    }
}
