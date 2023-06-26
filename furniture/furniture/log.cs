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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Dashborad db = new Dashborad();
            db.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtusername.Text;
            password = txtpassword.Text;

            try
            {
                con.Open();
                String querry = "SELECT Role FROM User_TB WHERE Username ='" + txtusername.Text + "'AND Password ='" + txtpassword.Text + "'";
                SqlCommand cm = new SqlCommand(querry, con);
                SqlDataReader DR = cm.ExecuteReader();
                DR.Read();

                if (DR.HasRows)
                {
                    string role = DR["Role"].ToString();
                    if (role == "Admin")
                    {
                        this.Hide();
                        Dashborad db = new Dashborad();
                       // MessageBox.Show("Hello Welcome to Dhammika Furniture");
                        db.Show();

                    }
                    else if (role == "Cashier")
                    {
                        this.Hide();
                        cashier cs = new cashier();
                        cs.Show();

                    }

                        con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
