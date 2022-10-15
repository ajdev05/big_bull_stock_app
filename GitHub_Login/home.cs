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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock1.Text = DateTime.Now.ToString("T");
        }

        private void home_Load(object sender, EventArgs e)
        {
            date1.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }
    }
}
