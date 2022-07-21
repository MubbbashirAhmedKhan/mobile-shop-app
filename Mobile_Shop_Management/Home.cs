using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mobile mob = new Mobile();
            mob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accessories acc = new Accessories();
            acc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selling sell = new Selling();
            sell.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit ();    
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
