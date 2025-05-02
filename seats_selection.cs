using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransitPRO;

namespace TransitPRO
{
    public partial class seats_selection : Form
    {
        private Button[] buttons = new Button[40];
        private int[] Seat_Status = new int[40];
        private int bus_index;
        public int total_price_ofAll_tickets = 0;
        int total_price_of_seats = 0;
        string departureCity, arrivalCity;
        public seats_selection(int index)
        {
            InitializeComponent();

            for (int i = 0; i < 40; i++)
            {
                if (Operations.getSeatStatus(index, i) == 'a' || Operations.getSeatStatus(index, i) == 'r')
                {
                    Seat_Status[i] = 0;     // Available Seat
                }
                else
                {
                    Seat_Status[i] = 3;     // Already Booked Seat
                }
            }
            bus_index = index;
            DateTime departureDateTime = Operations.getDepartureDateTime(index);
            string departureDate = departureDateTime.Date.ToString("dd-MM-yyyy");
            DateTime arrivalDateTime = Operations.getArrivalDateTime(index);
            string arrivalDate = arrivalDateTime.Date.ToString("dd-MM-yyyy");
            label5.Text = total_price_of_seats.ToString();
            label5.Text = "Seat(s) Price: " + "0 Rs";
            label2.Text = Operations.getDepartureCity(index);
            for (int i = 0; i < 18 - Operations.getDepartureCity(index).Length; i++)
                label2.Text += "-";
            label2.Text += Operations.getArrivalCity(index);

            label1.Text = departureDate;
            for (int i = 0; i < 25 - departureDate.Length; i++)
                label1.Text += " ";

            label1.Text += arrivalDate;

            string departureTime = departureDateTime.ToString("hh:mm tt");
            string arrivalTime = arrivalDateTime.ToString("hh:mm tt");

            label3.Text = departureTime;
            for (int i = 0; i < 30 - departureTime.Length; i++)
                label3.Text += " ";

            label3.Text += arrivalTime;

            label4.Text = Operations.trip_duration(index).Hours.ToString() + " Hrs " + Operations.trip_duration(index).Minutes.ToString() + " Min";

        }

        private void seats_selection_Load(object sender, EventArgs e)
        {
            int start = 482, end = 182;
            for (int i = 0; i < 40; i++)
            {

                Button button = new Button();
                button.Name = (i + 1).ToString();
                button.Text = (i + 1).ToString();
                button.ForeColor = Color.White;
                if (Operations.getSeatStatus(bus_index, i) == 'f' || (Seat_Status[i] == 2))
                {
                    button.BackColor = Color.Red;
                }
                else if (Operations.getSeatStatus(bus_index, i) == 'm' || (Seat_Status[i] == 1))
                {
                    button.BackColor = Color.Navy;
                }
                else
                    button.BackColor = Color.Blue;

                button.Font = new Font("Serif", 10, FontStyle.Bold);
                button.Width = 38;
                button.Height = 34;
                button.Location = new Point(start, end);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Click += Button_Click; // Attach the event handler
                buttons[i] = button;
                this.Controls.Add(button);
                if (i + 1 == 4 || i + 1 == 8 || i + 1 == 12 || i + 1 == 16 || i + 1 == 20 || i + 1 == 24 || i + 1 == 28 || i + 1 == 32 || i + 1 == 36 || i + 1 == 40)
                {
                    start = 482; end += 40;
                }
                else if ((i + 1) % 2 != 0)
                {

                    start += 44;
                }
                else
                {
                    start += 79;
                }
            }
        }

        public int getPrice(int price)
        {
            int amount_payable = 0;
            for (int i = 0; i < 40; i++)
            {
                if (Seat_Status[i] == 1 || Seat_Status[i] == 2)
                {
                    amount_payable += price;
                }
            }
            return amount_payable;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = Array.IndexOf(buttons, clickedButton);

            if (((getPrice(Operations.GetTicketPrice(bus_index))) / 5) >= (Operations.GetTicketPrice(bus_index)))
            {
                MessageBox.Show("You cannot reserve more than 5 seats", "Seat Reservation Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Seat_Status[buttonIndex] == 0)
            {
                Seat_Status[buttonIndex]++;
                clickedButton.BackColor = Color.Navy;
                label5.Text = "Seat(s) Price: " + getPrice(Operations.GetTicketPrice(bus_index)).ToString() + " Rs";
            }

            else if (Seat_Status[buttonIndex] == 1)
            {
                Seat_Status[buttonIndex] = 2;
                clickedButton.BackColor = Color.Red;
                label5.Text = "Seat(s) Price: " + getPrice(Operations.GetTicketPrice(bus_index)).ToString() + " Rs";
            }
            else if (Seat_Status[buttonIndex] == 2)
            {
                Seat_Status[buttonIndex] = 0;
                clickedButton.BackColor = Color.Blue;
                label5.Text = "Seat(s) Price: " + getPrice(Operations.GetTicketPrice(bus_index)).ToString() + " Rs";
            }
            else
                MessageBox.Show("You cannot reserve an already booked seat", "Invalid Seat Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool seat = true;
            for (int i = 0; i < 40; i++)
            {
                if (Seat_Status[i] == 1)
                {
                    if (!Operations.validateGender(bus_index, i, 'm'))
                    {
                        MessageBox.Show("A male cannot sit with a female", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seat = false;
                    }
                }

                else if (Seat_Status[i] == 2)
                {
                    if (!(Operations.validateGender(bus_index, i, 'f')))
                    {
                        MessageBox.Show("A female cannot sit with a male", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seat = false;
                    }
                }

            }
            if (getPrice(Operations.GetTicketPrice(bus_index)) != 0)
            {

                if (seat == true)
                {
                    Book_Seat s = new Book_Seat(Seat_Status, bus_index);
                    s.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select your seat");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_page h = new home_page();
            h.Show();Hide();
        }
    }
}
