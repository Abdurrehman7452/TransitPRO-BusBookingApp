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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private List<string> strings_name;
        private List<string> strings_password;

        //public Login(List<string> nameList, List<string> passwordList)
        //{
        //    InitializeComponent();
        //    strings_name = nameList; // save the lists as fields
        //    strings_password = passwordList;
        //}
        private void button1_Click(object sender, EventArgs e)
        {

            if (UserValidation.ValidateUser(textBox2.Text, textBox3.Text))
            {
                home_page home = new home_page();
                             home.Show();
                             Hide();
            }
            else
            {
                MessageBox.Show("Please Enter valid Username and Password", "Invalid Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if(textBox2.Text != "")
            //{
            //    for(int i = 0; i < strings_name.Capacity;i++)
            //    {
            //        if (strings_name[i] == textBox2.Text)
            //        {

            //            if (textBox3.Text == "")
            //            {
            //                MessageBox.Show("Invalid UserName");
            //            }
            //            else if (textBox3.Text == strings_password[i])
            //            {
            //              
            //            }
            //            else
            //            {
            //                MessageBox.Show("Invalid Password");
            //            }
            //        }
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}