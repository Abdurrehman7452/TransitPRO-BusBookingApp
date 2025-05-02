using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransitPRO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //link to home page
            home_page home = new home_page();
            home.Show();
            Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
