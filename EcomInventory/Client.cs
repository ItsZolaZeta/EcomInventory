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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            DisplayClients();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tatiana Tuor\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayClients()
        {
            Connection.Open();
            string Query = "Select * from ClientTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClientListView.DataSource = ds.Tables[0];
            Connection.Close();
        }

        private void clear()
        {
            CName.Text = "";
            CAddress.Text = "";
            CPhone.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CAddress.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ClientTable (ClientName,ClientAddress,ClientPhone) values(@CN,@CA,@CP)", Connection);
                    cmd.Parameters.AddWithValue("@CN", CName.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddress.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client added.");
                    Connection.Close();
                    DisplayClients();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void ClientListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //switch ClientListView.SelectedRows[0].Index:
            //    case
            int row = ClientListView.SelectedCells[0].RowIndex;
            string name = ClientListView.Rows[row].Cells[1].Value.ToString();
            string address = ClientListView.Rows[row].Cells[2].Value.ToString();
            string phone = ClientListView.Rows[row].Cells[3].Value.ToString();

            CName.Text = name;
            CAddress.Text = address;
            CPhone.Text = phone;
            if (CName.Text == "")
            {
                Key = 0;
            }
            else
            {
                string num = ClientListView.Rows[row].Cells[0].Value.ToString();
                Key = Convert.ToInt32(num);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a client.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("delete from ClientTable where ClientID=@CKey", Connection);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client deleted.");
                    Connection.Close();
                    DisplayClients();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Staff Obj = new Staff();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Product Obj = new Product();
            Obj.Show();
            this.Hide();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CAddress.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update ClientTable set ClientName=@CN,ClientAddress=@CA,ClientPhone=@CP where ClientID=@CKey", Connection);
                    cmd.Parameters.AddWithValue("@CN", CName.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddress.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhone.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client updated.");
                    Connection.Close();
                    DisplayClients();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
