using Microsoft.VisualBasic.ApplicationServices;
using TransitPRO;
namespace TransitPRO
{
    public partial class Form1 : Form
    {
        public List<string> strings_name;
        public List<string> strings_password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBUTTON_Click(object sender, EventArgs e)
        {
            bool name_valid = true; bool pas_valid = true; bool cnic_valid = true; bool email_valid = true; bool register_valid = true;
            int passwordverification = 0; bool specialcharinPassword = true, uppercharinPassword = true, lowercharinPassword = true;
            bool numericcharinPassword = true;
            if (nameBUTTON.Text == "")
            {
                MessageBox.Show("Please Enter UserName", "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name_valid = false;
            }
            else
            {
                for (int i = 0; i < nameBUTTON.Text.Length; i++)
                {
                    if (nameBUTTON.Text[i] < 65 || nameBUTTON.Text[i] > 122)
                    {
                        MessageBox.Show("Please Enter valid UserName", "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        name_valid = false;
                    }
                }
            }
            if (passwordBUTTON.Text == "" && name_valid == true)
            {
               
                MessageBox.Show("Please Enter Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pas_valid = false;
            }
            else if (passwordBUTTON.Text != "" && name_valid == true)
            {

                if (passwordBUTTON.Text.Length >= 8)
                {
                    for (int i = 0; i < passwordBUTTON.Text.Length; i++)
                    {
                        if ((passwordBUTTON.Text[i] >= 40 && passwordBUTTON.Text[i] <= 47) || (passwordBUTTON.Text[i] >= 58 && passwordBUTTON.Text[i] <= 64) && specialcharinPassword == true)
                        {
                            passwordverification++; specialcharinPassword = false;
                        }
                        else if (passwordBUTTON.Text[i] >= 65 && passwordBUTTON.Text[i] <= 90 && uppercharinPassword == true)
                        {
                            uppercharinPassword = false; passwordverification++;
                        }
                        else if (passwordBUTTON.Text[i] >= 97 && passwordBUTTON.Text[i] <= 122 && lowercharinPassword == true)
                        {
                            lowercharinPassword = false; passwordverification++;
                        }
                        else if (passwordBUTTON.Text[i] >= 48 && passwordBUTTON.Text[i] <= 57 && numericcharinPassword == true)
                        {
                            numericcharinPassword = false; passwordverification++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password must be greater than 8 digits", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    pas_valid = false;
                }

            }
            if (passwordverification == 4 && pas_valid == true && name_valid == true)
            {
                if (emailBUTTON.Text == "")
                {
                    MessageBox.Show("Please enter Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email_valid = false;
                }
                else
                {
                    if (cnicBUTTON.Text == "")
                    {
                        MessageBox.Show("Please enter Contact Number", "Invalid Contact No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnic_valid = false;
                    }
                    else
                    {
                        if (cnicBUTTON.Text.Length == 11)
                        {
                            for (int i = 0; i < cnicBUTTON.Text.Length; i++)
                            {
                                if (cnicBUTTON.Text[i] < 48 || cnicBUTTON.Text[i] > 57)
                                {
                                    register_valid = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contact No must be of 11 digits", "Invalid Contact No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            register_valid = false;
                        }
                        if(register_valid == false)
                        {
                            MessageBox.Show("Contact No must include only numbers", "Invalid Contact No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Use of minimum one special character, uppercase, lowercase, and \n numeric digit is must in Password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (register_valid == true)
            {
                if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Please Agree to Terms and Conditions to Proceed", "X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    cnic_valid = false;
                }
                else
                {
                    //strings_name.Add(nameBUTTON.Text);
                    //strings_password.Add(passwordBUTTON.Text);
                    UserValidation.RegisterUser(nameBUTTON.Text, passwordBUTTON.Text);


                        Hide();
                        Login login = new Login();
                        login.Show();
                    
                    
                }
            }







        }
    }
}