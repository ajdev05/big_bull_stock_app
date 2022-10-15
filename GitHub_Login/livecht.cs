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
    public partial class livecht : UserControl
    {
        public livecht()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = msg.Text;
            textBox1.Text = txt;
            msg.Clear()
;        }
    }
}
