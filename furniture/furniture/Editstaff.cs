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
    public partial class Editstaff : Form
    {
        public Editstaff()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();


                string query = "UPDATE User_TB SET Password='" + txt_password1.Text + "' ,Role='" + cmb_role1.Text + "' ,Fullname='" + txt_fullname1.Text + "',Gender='" + cmb_gender1.Text + "',Address='" + txt_Address1.Text + "' WHERE Username='" + txtUsername1.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully");

                con.Close();
                this.Close();
                staff sd = new staff();
                sd.Show();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            staff st = new staff();
            st.Show();

        }
    }
}
