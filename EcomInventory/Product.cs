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

namespace EcomInventory
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            DisplayProducts();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tatiana Tuor\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayProducts()
        {
            Connection.Open();
            string Query = "Select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductListView.DataSource = ds.Tables[0];
            Connection.Close();
        }

        private void clear()
        {
            PName.Text = "";
            PCategory.SelectedIndex = 0;
            PPrice.Text = "";
            PQty.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PCategory.SelectedIndex == -1 || PPrice.Text == ""  || PQty.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTable (ProductName,ProductCat,ProductQty,ProductPrice) values(@PN,@PC,@PQ, @PP)", Connection);
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@PC", PCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", PQty.Text);
                    cmd.Parameters.AddWithValue("@PP", PPrice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added.");
                    Connection.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void ProductListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //switch ClientListView.SelectedRows[0].Index:
            //    case
            int row = ProductListView.SelectedCells[0].RowIndex;
            string name = ProductListView.Rows[row].Cells[1].Value.ToString();
            string category = ProductListView.Rows[row].Cells[2].Value.ToString();
            string price = ProductListView.Rows[row].Cells[3].Value.ToString();
            string quantity = ProductListView.Rows[row].Cells[4].Value.ToString();

            PName.Text = name;
            PCategory.Text = category;
            PPrice.Text = price;
            PQty.Text = quantity;
            if (PName.Text == "")
            {
                Key = 0;
            }
            else
            {
                string num = ProductListView.Rows[row].Cells[0].Value.ToString();
                Key = Convert.ToInt32(num);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Client Obj = new Client();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Staff Obj = new Staff();
            Obj.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a product.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTable where ProductID=@PKey", Connection);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted.");
                    Connection.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PCategory.SelectedIndex == -1 || PPrice.Text == "" || PQty.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update ProductTable set ProductName=@PN,ProductCat=@PC,ProductQty=@PQ,ProductPrice=@PP where ProductID=@PKey", Connection);
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@PC", PCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", PQty.Text);
                    cmd.Parameters.AddWithValue("@PP", PPrice.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated.");
                    Connection.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Order Obj = new Order();
            Obj.Show();
            this.Hide();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
    }
}
