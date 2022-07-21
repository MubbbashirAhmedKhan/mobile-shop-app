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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mubbashir\source\repos\Mobile_Shop_Management\Mobile_Shop_Management\Database.mdf;Integrated Security=True");
        private void populate()
        {

            Con.Open();
            String query = "select Mbrand,MModel,Mprice from MobileTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(da);
            var ds = new DataSet();

            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateAccess()
        {

            Con.Open();
            String query = "select Abrand,AModel,Aprice from AccessoriesTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(da);
            var ds = new DataSet();

            da.Fill(ds);
            AccessoriesDGV .DataSource = ds.Tables[0];
            Con.Close();
        }
        private void insertbill()
        {
            if (Billdtb.Text == "" || ClientNametb .Text == "" )
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                int amount = Convert.ToInt32(Amtlbl.Text);
                try
                {
                    Con.Open();
                    String sql = "insert into BillTbl values(" + Billdtb.Text + ",'" + ClientNametb .Text + "','" + amount+ ")";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    populate();
                    Con.Close();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populateAccess();
            Sum();
        }
        private void Sum()
        {
            string query = "select sum(Amt)from BillTbl ";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Sellamtlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb .Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString() + MobileDGV .SelectedRows[0].Cells[1].Value.ToString() ;
            PricTb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void AccessoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb.Text = AccessoriesDGV.SelectedRows[0].Cells[0].Value.ToString() +  AccessoriesDGV.SelectedRows[0].Cells[1].Value.ToString();
            PricTb.Text = AccessoriesDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
        int n = 0, Grdtotal = 0;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        int prodid, prodqty, prodprice, total, pos = 60;

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sellamtlbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mobile_Shop_Management", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BILLDGV.Rows )
            {
                prodid = Convert .ToInt32(row.Cells["Column1"].Value  );
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                total =  Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(170, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: Rs" + Grdtotal , new Font("Century Gothic", 12, FontStyle .Bold), Brushes.Crimson , new Point(50, pos+50));
            e.Graphics.DrawString("*****Mobile Shop*****", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BILLDGV.Rows.Clear();
            BILLDGV.Refresh();
            pos = 100;
            Grdtotal = 0;
            n = 0;
            insertbill();
            Sum();
                }
        


        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);    
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK  )
            {
                printDocument1.Print(); 
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(QtyTb.Text =="" || PricTb.Text == ""  )
            {
                MessageBox.Show("enter the quantity");
            }else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PricTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BILLDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProductTb .Text ;
                newRow.Cells[2].Value = PricTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                BILLDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "" + Grdtotal;
            }
        }
    }
}
