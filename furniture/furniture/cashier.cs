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
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-491D699;Initial Catalog=Funiture_DB;Integrated Security=True");
        private void btn_product_Click(object sender, EventArgs e)
        {
           this.Hide();
            calculate cl = new calculate();
            cl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out of this system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                log lg = new log();
                lg.Show();
            }
            
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit this system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Pannelamin_Paint(object sender, PaintEventArgs e)
        {
            //Greeting message
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

            lbltransnum.Text = supplierCount.ToString();

            con.Close();


        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            stoks st = new stoks();
            st.Show();
        }
    }

  
}
