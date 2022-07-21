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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 15;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint  += 1;
            progressBar1.Value = startpoint;
            progressBar2.Value = startpoint;
            if(progressBar2.Value ==100)
            {
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                timer1.Stop ();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
