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
    public partial class Dashborad : Form
    {
        public Dashborad()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");

        private void Dashborad_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit this system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
           

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            staff staf = new staff();
            staf.Show();
            this.Hide();
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            suppliers sp = new suppliers();
            sp.Show();
            this.Hide();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Category cg = new Category();
            cg.Show();
            this.Hide();
        }

        private void Pannelamin_Paint(object sender, PaintEventArgs e)
        {
            DateTime timeOfDayGreeting = DateTime.Now;
            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                lblgreeting.Text = "Good Morning!";
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                lblgreeting.Text = "Good Afternoon!";
            }
            else
            {
                lblgreeting.Text = "Good Evening!";
            }

            populate();
            getitems();
            getTrans();
            getincome();
            con.Close();


        }
        public void populate()
        {


            con.Open();
            string selectQuery = $"SELECT COUNT(*) FROM Supplier_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);

            int supplierCount = Convert.ToInt32(command.ExecuteScalar());

            lblsupp.Text = supplierCount.ToString();

            con.Close();

           
        }
        public void getitems()
        {


            con.Open();
            string selectQuery = $"SELECT COUNT(*) FROM Item_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);

            int supplierCount = Convert.ToInt32(command.ExecuteScalar());

            lblstocks.Text = supplierCount.ToString();

            con.Close();


        }
        public void getTrans()
        {


            con.Open();
            string selectQuery = $"SELECT COUNT(*) FROM Transaction_TB";
            SqlCommand command = new SqlCommand(selectQuery, con);

            int supplierCount = Convert.ToInt32(command.ExecuteScalar());

            lbltrans.Text = supplierCount.ToString();

            con.Close();


        }
        public void getincome()
        {

            try
            {
                con.Open();
                string selectQuery = $"SELECT SUM(total) AS totalsum FROM Transaction_TB";
                SqlCommand command = new SqlCommand(selectQuery, con);

                decimal totalSum = Convert.ToDecimal(command.ExecuteScalar());

                lbltotalincome.Text = totalSum.ToString();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to log out of this system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                log lg = new log();
                this.Close();
                lg.Show();
            }
           
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.Close();
            records rc = new records();
            rc.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

           
            


        }
    }
}
