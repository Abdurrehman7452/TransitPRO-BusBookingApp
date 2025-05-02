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
    public partial class Book_Seat : Form
    {
        private int[] Seat_Status;
        private int bus_index;

        public Book_Seat(int[] bus_seats, int index)
        {
            int total_amount = 0;
            int startposition = 176; int endposition = 331;
            DateTime departureDateTime = Operations.getDepartureDateTime(index);
            DateTime arrivalDateTime = Operations.getArrivalDateTime(index);
            InitializeComponent();
            Seat_Status = bus_seats;
            bus_index = index;
            label2.Text = Operations.getDepartureCity(index);
            for (int i = 0; i < 18 - Operations.getDepartureCity(index).Length; i++)
                label2.Text += "-";
            label2.Text += Operations.getArrivalCity(index);
            string departureDate = departureDateTime.Date.ToString("dd-MM-yyyy");
            string arrivalDate = arrivalDateTime.Date.ToString("dd-MM-yyyy");
            string departureTime = departureDateTime.ToString("hh:mm tt");
            string arrivalTime = arrivalDateTime.ToString("hh:mm tt");
            label3.Text = departureDate;
            for (int i = 0; i < 25 - departureDate.Length; i++)
                label3.Text += " ";
            label3.Text += arrivalDate;
            label4.Text = departureTime;
            for (int i = 0; i < 30 - departureTime.Length; i++)
                label4.Text += " ";
            label4.Text += arrivalTime;
            for (int i = 0; i < 40; i++)
            {
                if (bus_seats[i] == 1)
                {
                    Label l = attributes(i, startposition, endposition, (i + 1).ToString(), false, true);
                    startposition += 41;
                    total_amount += Operations.GetTicketPrice(index);
                    this.Controls.Add(l);
                }
                else if (bus_seats[i] == 2)
                {
                    Label l = attributes(i, startposition, endposition, (i + 1).ToString(), false, false);
                    startposition += 41;
                    total_amount += Operations.GetTicketPrice(index);
                    this.Controls.Add(l);
                }

            }
            label8.Text = total_amount.ToString();

        }

        private void Book_Seat_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Label attributes(int i, int start, int end, string _value, bool bold, bool is_blue)
        {
            Label info = new Label();
            info.Name = _value;
            info.Text = _value;
            if (is_blue == true) info.BackColor = Color.Navy;
            else info.BackColor = Color.Red;
            info.ForeColor = Color.White;

            if (bold)
                info.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            else
                info.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            info.Width = 35;
            info.Height = 29;
            info.Location = new Point(start, end);
            info.TextAlign = ContentAlignment.MiddleCenter;
            return info;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Your Credentials are Invalid", "Credentials Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool alternate = false; int sum = 0;
                if (textBox2.Text != "")
                {
                    string accountNumber = textBox2.Text;
                    for (int i = textBox2.Text.Length - 1; i >= 0; i--)
                    {
                        int dig = accountNumber[i] - '0';
                        if (alternate)
                        {
                            dig *= 2;
                            if (dig > 9)
                            {
                                dig -= 9;
                            }
                        }
                        sum += dig;
                        alternate = !alternate;
                    }

                    if ((sum % 10) != 0)
                    {
                        MessageBox.Show("Your Card Number is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dateTimePicker1.Value < DateTime.Now)
                        {
                            MessageBox.Show("Your Card is Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (confirm_payment())
                            {
                                MessageBox.Show("Payment transaction has been successfully finalized.", "Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Ticket Generated Successfully! Thanks for Choosing TransitPRO", "Seat Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                for (int i = 0; i < 40; i++)
                                {
                                    if (Seat_Status[i] == 1)
                                        Operations.bookSeat(bus_index, i, 'm');

                                    else if (Seat_Status[i] == 2)
                                        Operations.bookSeat(bus_index, i, 'f');
                                }
                            }
                            else
                                MessageBox.Show("Payment transaction canceled.", "Payment Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            home_page h = new home_page();
                            h.Show();
                            Hide();
                        }
                    }
                }
            }
        }

        bool confirm_payment()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to finalize the payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}