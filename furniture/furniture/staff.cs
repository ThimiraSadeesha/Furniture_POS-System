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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");


        public void populate()
        {


            con.Open();

            string selectQuery = $"SELECT * FROM User_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_users.DataSource = dataTable;

            con.Close();
        }
        private void btn_Addstaff_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = "INSERT into User_TB values('" + txtUsername.Text + "','" + txt_password.Text + "','" + cmb_role.Text + "','" + txt_fullname.Text + "','" + cmb_gender.Text + "','" + txt_Address.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                con.Close();

                populate();
                txtUsername.Clear();
                txt_password.Clear();
                txt_fullname.Clear();

                txt_Address.Clear();
                cmb_role.SelectedItem = null;
                cmb_gender.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtUsername.Clear();
            txt_password.Clear();
            txt_fullname.Clear();

            txt_Address.Clear();
            cmb_role.SelectedItem = null;
            cmb_gender.SelectedItem = null;

        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_users.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Editstaff se = new Editstaff();
                se.Show();
                
                  se.txtUsername1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                  se.txt_password1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                  se.cmb_gender1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                  se.txt_fullname1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                  se.cmb_role1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                  se.txt_Address1.Text = dgv_users.Rows[(int)e.RowIndex].Cells[7].Value.ToString();
                this.Hide();


            }
              else if (colName == "Delete")
              {

                Deleteuser sd = new Deleteuser();
                sd.Show();
                  sd.lbl_username.Text = dgv_users.Rows[(int)e.RowIndex].Cells[2].Value.ToString();
                  sd.lbl_password.Text = dgv_users.Rows[(int)e.RowIndex].Cells[3].Value.ToString();
                  sd.lbl_role.Text = dgv_users.Rows[(int)e.RowIndex].Cells[4].Value.ToString();
                  sd.lbl_fullname.Text = dgv_users.Rows[(int)e.RowIndex].Cells[5].Value.ToString();
                  sd.lbl_gender.Text = dgv_users.Rows[(int)e.RowIndex].Cells[6].Value.ToString();
                  sd.lbl_address.Text = dgv_users.Rows[(int)e.RowIndex].Cells[7].Value.ToString();
                this.Hide();



              }

            
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void staff_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}

