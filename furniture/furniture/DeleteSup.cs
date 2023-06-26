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
    public partial class DeleteSup : Form
    {
        public DeleteSup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            suppliers sp = new suppliers();
            sp.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();

                string query = "DELETE FROM Supplier_TB WHERE Supid='" + lbl_supid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Suplier Succesfully deleted");
                // Debug.WriteLine(query);
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

        private void DeleteSup_Load(object sender, EventArgs e)
        {

        }
    }
}
