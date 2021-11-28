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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            //dashboard name label = Login.Staff;
            GetClients();
            DisplayProducts();
            DisplayOrders();

        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tatiana Tuor\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        int n = 0, orderPrice = 0;
        int PKey = 0, Stock = 0;
        int OKey = 0;

        private void GetClients()
        {
            // populate selector with clientID list from db
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select ClientID from ClientTable", Connection);
            SqlDataReader Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientID", typeof(int));
            dt.Load(Rdr);
            ClientID.ValueMember = "ClientID";
            ClientID.DataSource = dt;
            Connection.Close();
        }
        private void DisplayProducts()
        {
            Connection.Open();
            string Query = "Select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsListView.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void DisplayOrders()
        {
            Connection.Open();
            string Query = "Select * from OrderTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersListView.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void GetClientName()
        {
            // get name of client corresponding to the selected client ID
            Connection.Open();
            string Query = "Select * from ClientTable where ClientID=" + ClientID.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ClientID.Text = dr["ClientName"].ToString();
            }
            Connection.Close();
        }
        private void UpdateInventory()
        {
            try
            {
                int newQuantity = Stock - Convert.ToInt32(ProductQty.Text);
                Connection.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTable set ProductQty=@PQ where ProductID=@PKey", Connection);
                cmd.Parameters.AddWithValue("@PQ", newQuantity);
                cmd.Parameters.AddWithValue("@PKey", PKey);
                cmd.ExecuteNonQuery();
                Connection.Close();
                DisplayProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ResetProduct()
        {
            ProductName.Text = "";
            ProductQty.Text = "";
            Stock = 0;
            PKey = 0;
        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            if (ProductQty.Text == "" || Convert.ToInt32(ProductQty.Text) > Stock)
            {
                MessageBox.Show("Not enough inventory.");
            }
            else if (ProductQty.Text == "" || PKey == 0)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                int productTotal = Convert.ToInt32(ProductQty.Text) * Convert.ToInt32(ProductPrice.Text);
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(OrderProductsView);
                dr.Cells[0].Value = (n+1).ToString();
                dr.Cells[1].Value = ProductName.Text;
                dr.Cells[2].Value = ProductQty.Text;
                dr.Cells[3].Value = ProductPrice.Text;
                dr.Cells[4].Value = productTotal;
                orderPrice = orderPrice + productTotal;
                OrderProductsView.Rows.Add(dr);
                n++;
                TotalPrice.Text = orderPrice + "CHF";
                UpdateInventory();
                ResetProduct();
            }
        }

        private void ProductsListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ProductsListView.SelectedCells[0].RowIndex;
            string name = ProductsListView.Rows[row].Cells[1].Value.ToString();
            string price = ProductsListView.Rows[row].Cells[4].Value.ToString();
            string quantity = ProductsListView.Rows[row].Cells[3].Value.ToString();

            ProductName.Text = name;
            ProductPrice.Text = price;
            ProductQty.Text = "1";
            Stock = Convert.ToInt32(quantity);
            if (ProductName.Text == "")
            {
                PKey = 0;
            }
            else
            {
                string num = ProductsListView.Rows[row].Cells[0].Value.ToString();
                PKey = Convert.ToInt32(num);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Product Obj = new Product();
            Obj.Show();
            this.Hide();
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

        private void ClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetClientName();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("Update OrderTable set OrderDate=@OD,OrderClientID=@OCID,OrderClientName=@OCN,OrderStaffName=@OSN,TotalPrice=@OTP where OrderID=@OKey", Connection);
                cmd.Parameters.AddWithValue("@OD", ODate.Value.Date);
                cmd.Parameters.AddWithValue("@OCID", ClientID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@OCN", ClientName.Text);
                cmd.Parameters.AddWithValue("@OSN", StaffName.Text);
                cmd.Parameters.AddWithValue("@OTP", TotalPrice.Text);
                cmd.Parameters.AddWithValue("@OKey", OKey);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order updated.");
                Connection.Close();
                DisplayOrders();
                //clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void OrdersListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = OrdersListView.SelectedCells[0].RowIndex;
            string orderDate = OrdersListView.Rows[row].Cells[1].Value.ToString();
            string clientID = OrdersListView.Rows[row].Cells[2].Value.ToString();
            string clientName = OrdersListView.Rows[row].Cells[3].Value.ToString();
            string staffName = OrdersListView.Rows[row].Cells[4].Value.ToString();
            string totalPrice = OrdersListView.Rows[row].Cells[5].Value.ToString();

            ClientName.Text = clientName;
            ClientID.Text = clientID;
            ODate.Text = orderDate;
            StaffName.Text = staffName;
            TotalPrice.Text = totalPrice;
            if (ClientName.Text == "")
            {
                OKey = 0;
            }
            else
            {
                string num = OrdersListView.Rows[row].Cells[0].Value.ToString();
                OKey = Convert.ToInt32(num);
            }
        }

        private void resetProd_Click(object sender, EventArgs e)
        {
            ResetProduct();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTable (OrderDate,OrderClientID,OrderClientName,OrderStaffName,TotalPrice) values(@OD,@OCID,@OCN,@OSN,@OTP)", Connection);
                cmd.Parameters.AddWithValue("@OD", ODate.Value.Date);
                cmd.Parameters.AddWithValue("@OCID", ClientID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@OCN", ClientName.Text);
                cmd.Parameters.AddWithValue("@OSN", StaffName.Text);
                cmd.Parameters.AddWithValue("@OTP", TotalPrice.Text);
                cmd.Parameters.AddWithValue("@OKey", OKey);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order updated.");
                Connection.Close();
                DisplayOrders();
                //clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
