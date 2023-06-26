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
    public partial class EditSup : Form
    {
        public EditSup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supID1.Clear();
            txt_SupCompny1.Clear();
            txt_SUPMobile1.Clear();
            txt_SUPemail1.Clear();
            txtUsername1.Clear();
            txt_Address1.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "UPDATE Supplier_TB SET supname='" + txtUsername1.Text + "' ,email='" + txt_SUPemail1.Text + "' ,mobile='" + txt_SUPMobile1.Text + "',company='" + txt_SupCompny1.Text + "',address='" + txt_Address1.Text + "' WHERE Supid='" + txt_supID1.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Update Successfully");

                con.Close();
                this.Close();

                suppliers sp = new suppliers();
                sp.Show();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            suppliers st = new suppliers();
            st.Show();
        }
    }
}
