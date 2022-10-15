using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace GitHub_Login
{
    public partial class Form1 : Form
    {
     //   [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

       // private static extern IntPtr CreateRoundRectRgn
 //(
     //  int nLeftRect,
     //  int nTopRect,
     //  int nRightRect,
     //  int nBottomRect,
      // int nWidthEllipse,
       //int nHeightEllipse
//
 //);
        public Form1()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user.Text == "username" && passwd.Text =="password") 
            {

                MessageBox.Show("Login Successful!");
                Form2 Form = new Form2();
                Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Unsucessful!");
                user.Clear();
                passwd.Clear();
                user.Focus();
            }
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
