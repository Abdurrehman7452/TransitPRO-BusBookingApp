using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransitPRO
{
    public partial class home_page : Form
    {
        string departure = "";
        string arrival = "";
        string[] operational_cities = new string[4] { "Islamabad", "Lahore", "Karachi", "Multan" };

        public home_page()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 0; i < operational_cities.Length; i++)
            {
                comboBox1.Items.Add(operational_cities[i]);
            }

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hide();
            Form4 f = new Form4();
            f.Show();

        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLights f = new FLights("", "");
            f.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            departure = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < operational_cities.Length; i++)
            {
                if (departure != operational_cities[i])
                    comboBox2.Items.Add(operational_cities[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arrival == "" || departure == "")
            {
                MessageBox.Show("Please Select Arrival and Departure Cities", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FLights f = new FLights(departure, arrival);
                f.Show();
                Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrival = comboBox2.SelectedItem.ToString();
        }
    }
}
