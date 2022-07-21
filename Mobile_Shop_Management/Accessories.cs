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
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mubbashir\source\repos\Mobile_Shop_Management\Mobile_Shop_Management\Database.mdf;Integrated Security=True");
        private void populate()
        {

            Con.Open();
            String query = "select * from AccessoriesTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(da);
            var ds = new DataSet();

            da.Fill(ds);
            AccessoriesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AidTb .Text == "" || AbrandTb .Text == "" || AmodelTb .Text == "" || ApriceTb .Text == "" || AStock .Text == "" )
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into AccessoriesTbl values(" + AidTb .Text + ",'" + AbrandTb .Text + "','" + AmodelTb .Text + "','" + ApriceTb .Text + "' ,'" + AStock .Text +  "')";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessories Added Successfully");
                    populate();
                    if (Con.State == ConnectionState.Closed)
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AidTb.Text = "";
            AmodelTb.Text = "";
            AbrandTb.Text = "";
            AStock.Text = "";
            ApriceTb.Text = "";
        }

        private void AccessoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AidTb .Text = AccessoriesDGV.SelectedRows[0].Cells[0].Value.ToString();
            AbrandTb .Text = AccessoriesDGV.SelectedRows[0].Cells[1].Value.ToString();
            AmodelTb .Text = AccessoriesDGV.SelectedRows[0].Cells[2].Value.ToString();
            ApriceTb .Text = AccessoriesDGV.SelectedRows[0].Cells[3].Value.ToString();
            AStock .Text = AccessoriesDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AidTb .Text == "")
            {
                MessageBox.Show("Enter the Accessories to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from Tbl where AId=" + AidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessories Deleted");
                    Con.Close();
                    populate();



                }
                catch (Exception )
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AidTb .Text == "" || AbrandTb .Text == "" || AmodelTb .Text == "" || ApriceTb .Text == "" || AStock .Text == "" )
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();
                    String sql = "update AccessoriesTbl set Abrand='" +AbrandTb .Text + "',AModel='" + AmodelTb .Text + "',APrice=" + ApriceTb .Text + ",Astock=" + AStock .Text +   " where AId =" + AidTb .Text + "";
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
    }
}
