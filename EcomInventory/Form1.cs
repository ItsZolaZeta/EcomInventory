using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        int startTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime += 1;
            progressBar.Value = startTime*2;
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
