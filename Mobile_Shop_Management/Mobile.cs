using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Shop_Management
{
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mubbashir\source\repos\Mobile_Shop_Management\Mobile_Shop_Management\Database.mdf;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void populate()
        {
            
            Con.Open();
            String query = "select * from MobileTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Mobile_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MobidTb.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || cameratb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into MobileTbl values(" + MobidTb.Text + ",'" + brandtb.Text + "','" + modeltb.Text + "','" + pricetb.Text + "', " + stocktb.Text + ", '" + ramcb.SelectedItem.ToString() + "'," + romcb.SelectedItem.ToString() + ",'" + cameratb.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Added Successfully");
                    populate();
                    if(Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                    }

                    Con.Close();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MobidTb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString();
            brandtb.Text = MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            modeltb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
            pricetb .Text = MobileDGV.SelectedRows[0].Cells[3].Value.ToString();
            stocktb.Text = MobileDGV.SelectedRows[0].Cells[4].Value.ToString();
            ramcb .Text = MobileDGV.SelectedRows[0].Cells[5].Value.ToString();
            romcb.Text = MobileDGV.SelectedRows[0].Cells[6].Value.ToString();
            cameratb .Text = MobileDGV.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MobidTb.Text = "";
            brandtb.Text = "";
            modeltb.Text = "";
            pricetb.Text = "";
            stocktb.Text = "";
            cameratb .Text ="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MobidTb.Text =="")
            {
                MessageBox.Show("Enter the mobile to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from MobileTbl where MobId=" + MobidTb.Text + "";
                    SqlCommand cmd= new SqlCommand (query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Deleted");
                    Con.Close();
                    populate();

                        
                    
                }catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MobidTb.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "" || cameratb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String sql = "update MobileTbl set Mbrand='" + brandtb.Text + "',MModel='" + modeltb.Text + "',MPrice=" + pricetb.Text + ",Mstock=" + stocktb.Text + ",MRam=" + ramcb.SelectedItem.ToString() + ",MRom=" + romcb.SelectedItem.ToString() + ",MCam=" + cameratb.Text + " where MobId =" + MobidTb.Text + "";           
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Updated Successfully");
                    populate();
                    Con.Close();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pricetb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
