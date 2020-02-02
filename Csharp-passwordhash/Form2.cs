using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_passwordhash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string user = "admin";
        string pass = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == user && textBox2.Text == pass)
                Process.Start(@"C:\Users\Bruno\Desktop\passwordStorage\password.txt");
            else
                label4.Visible = true;
        }
    }
}
