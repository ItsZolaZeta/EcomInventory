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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            DisplayStaff();

        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tatiana Tuor\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void DisplayStaff()
        {
            Connection.Open();
            string Query = "Select * from StaffTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffListView.DataSource = ds.Tables[0];
            Connection.Close();
        }

        private void clear()
        {
            SName.Text = "";
            SPassword.Text = "";
            SDepartment.Text = "";
            Sdob.Text = "";

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || SPassword.Text == "" || SDepartment.Text == "" || Sdob.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into StaffTable (StaffName,StaffDep,StaffDOB,StaffPW) values(@SN,@SD,@SDOB,@SP)", Connection);
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SD", SDepartment.Text);
                    cmd.Parameters.AddWithValue("@SDOB", Sdob.Value.Date);
                    cmd.Parameters.AddWithValue("@SP", SPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff added.");
                    Connection.Close();
                    DisplayStaff();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void StaffListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //switch StaffListView.SelectedRows[0].Index:
            //    case
            int row = StaffListView.SelectedCells[0].RowIndex;
            string name = StaffListView.Rows[row].Cells[1].Value.ToString();
            string dep = StaffListView.Rows[row].Cells[2].Value.ToString();
            string dob = StaffListView.Rows[row].Cells[3].Value.ToString();
            string password = StaffListView.Rows[row].Cells[4].Value.ToString();

            SName.Text = name; //StaffListView.SelectedRows[0].Cells[1].Value.ToString();
            SDepartment.Text = dep; //StaffListView.SelectedRows[0].Cells[2].Value.ToString();
            Sdob.Text = dob; //StaffListView.SelectedRows[0].Cells[3].Value.ToString();
            SPassword.Text = password; // StaffListView.SelectedRows[0].Cells[4].Value.ToString();
            if (SName.Text == "")
            {
                Key = 0;
            }
            else
            {
                string num = StaffListView.Rows[row].Cells[0].Value.ToString();
                Key = Convert.ToInt32(num);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || SPassword.Text == "" || SDepartment.Text == "" || Sdob.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update StaffTable set StaffName=@SN,StaffDep=@SD,StaffDOB=@SDOB,StaffPW=@SP where StaffID=@SKey", Connection);
                    cmd.Parameters.AddWithValue("@SN", SName.Text);
                    cmd.Parameters.AddWithValue("@SD", SDepartment.Text);
                    cmd.Parameters.AddWithValue("@SDOB", Sdob.Value.Date);
                    cmd.Parameters.AddWithValue("@SP", SPassword.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff updated.");
                    Connection.Close();
                    DisplayStaff();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a staff member.");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("delete from StaffTable where StaffID=@SKey", Connection);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff deleted.");
                    Connection.Close();
                    DisplayStaff();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Client Obj = new Client();
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
    }
}
