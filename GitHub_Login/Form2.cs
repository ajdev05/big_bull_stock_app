using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            home1.Show();
            home1.BringToFront();
            livechrt1.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home1.Show();
            home1.BringToFront();
            livechrt1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            livechrt1.Show();
            livechrt1.BringToFront();
            home1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            livechrt1.Hide();
            home1.Hide();
            livecht1.Show();
            livecht1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully!");
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
 
        }
    }
}
