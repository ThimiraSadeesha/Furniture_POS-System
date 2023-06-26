using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            Date.Text = currentDateTime.ToString();
        }
    }
}
