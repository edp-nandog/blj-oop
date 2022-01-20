using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {

        int baumbreite;
        int baumhoehe;
        int kronenhoehe;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baumbreite = Convert.ToInt32(textBox1);
            baumhoehe = Convert.ToInt32(textBox2);
            kronenhoehe = Convert.ToInt32(textBox3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
