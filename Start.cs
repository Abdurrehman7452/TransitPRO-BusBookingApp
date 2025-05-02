using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransitPRO;

namespace TransitPRO
{
    public partial class starting_button : Form
    {
        public starting_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations.initializeOperations();
            Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void starting_button_Load(object sender, EventArgs e)
        {

        }
    }
}
