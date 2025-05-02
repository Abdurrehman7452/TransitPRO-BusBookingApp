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
    public partial class FLights : Form
    {
        private Button[] buttons;
        public string departure__city; public string arrival__city;

        public FLights(string departure_city = "", string arrival_city = "")
        {
            departure__city = departure_city; arrival__city = arrival_city;
            InitializeComponent();
        }
        private void FLights_Load(object sender, EventArgs e)
        {
            //GenerateDynamicUserControl();
            //List<Operations> _operations = new List<Operations>();
            string dep_arrival_city = departure__city + "-------" + arrival__city;



            int startposition = 200;
            int endposition = 280;
            Label Departure_arrival = new Label();
            Departure_arrival.Name = dep_arrival_city;
            Departure_arrival.Text = dep_arrival_city;
            Departure_arrival.ForeColor = Color.Black;
            Departure_arrival.BackColor = Color.White;
            Departure_arrival.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            Departure_arrival.Width = 294;
            Departure_arrival.Height = 45;
            Departure_arrival.Location = new Point(351, 170);
            Departure_arrival.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(Departure_arrival);

            string Price_of_ticket;
            int totalBuses = Operations.TotalBusesScheduled();
            buttons = new Button[totalBuses];
            if (departure__city == "" && arrival__city == "")
            {
                for (int i = 0; i < totalBuses; i++)
                {
                    Panel newPanel = new Panel();

                    //Set properties of the panel
                    newPanel.Location = new Point(130, 10 + i * 250); // set the location of the panel
                    newPanel.Size = new Size(700, 135); // set the size of the panel
                    newPanel.BackColor = Color.LightGray; // set the background color of the panel

                    //Add the panel to the form's Controls collection
                    this.Controls.Add(newPanel);
                    DateTime departureDateTime = Operations.getDepartureDateTime(i);
                    DateTime arrivalDateTime = Operations.getArrivalDateTime(i);
                    string departureDate = departureDateTime.Date.ToString("dd-MM-yyyy");
                    string departureTime = departureDateTime.ToString("hh:mm tt");
                    string arrivalDate = arrivalDateTime.Date.ToString("dd-MM-yyyy");
                    string arrivalTime = arrivalDateTime.ToString("hh:mm tt");
                    string departureCity = Operations.getDepartureCity(i);
                    string arrivalCity = Operations.getArrivalCity(i);
                    string totalPriceOfTicket = Operations.GetTicketPrice(i).ToString("N2");
                    Price_of_ticket = Operations.GetTicketPrice(i).ToString();
                    string seatPrice = "Seat Price: " + Price_of_ticket + " Rs";
                    Label l1 = attributes(i, startposition, endposition, departureCity, true); this.Controls.Add(l1);

                    Label seat = new Label();
                    seat.Name = seatPrice;
                    seat.Text = seatPrice;
                    seat.ForeColor = Color.Black;
                    seat.BackColor = Color.LightGray;
                    seat.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    seat.Width = 230;
                    seat.Height = 30;
                    seat.Location = new Point(startposition + 170, endposition);
                    seat.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(seat);


                    startposition = 630;

                    Label l2 = attributes(i, startposition, endposition, arrivalCity, true);
                    startposition = 200; endposition += 30; this.Controls.Add(l2);

                    Label l3 = attributes(i, startposition, endposition, departureDate, false);

                    startposition = 630; this.Controls.Add(l3);

                    Button button = new Button();

                    // ======================== BUTTON for Bus Selection ========================================
                    button.Name = "Select Seat";
                    button.Text = "Select Seat";
                    button.ForeColor = Color.White;
                    button.BackColor = Color.Navy;
                    button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    button.Width = 160;
                    button.Height = 45;
                    button.Location = new Point(400, endposition + 28);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Click += Button_Click; // Attach the event handler
                    buttons[i] = button;
                    this.Controls.Add(button);

                    Label l4 = attributes(i, startposition, endposition, arrivalDate, false);
                    startposition = 200; endposition += 30; this.Controls.Add(l4);
                    Label l5 = attributes(i, startposition, endposition, departureTime, false);
                    startposition = 630; this.Controls.Add(l5);
                    Label l6 = attributes(i, startposition, endposition, arrivalTime, false);
                    startposition = 200; endposition += 30; this.Controls.Add(l6);

                    endposition += 160;
                }
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < totalBuses; i++)
                {
                    if (departure__city == Operations.getDepartureCity(i) && arrival__city == Operations.getArrivalCity(i))
                    {
                        Panel newPanel = new Panel();

                        //Set properties of the panel
                        newPanel.Location = new Point(130, endposition - 20); // set the location of the panel : 10 + counter++ * 250
                        newPanel.Size = new Size(700, 135); // set the size of the panel
                        newPanel.BackColor = Color.LightGray; // set the background color of the panel

                        //Add the panel to the form's Controls collection
                        DateTime departureDateTime = Operations.getDepartureDateTime(i);
                        DateTime arrivalDateTime = Operations.getArrivalDateTime(i);
                        string departureDate = departureDateTime.Date.ToString("dd-MM-yyyy");
                        string departureTime = departureDateTime.ToString("hh:mm tt");
                        string arrivalDate = arrivalDateTime.Date.ToString("dd-MM-yyyy");
                        string arrivalTime = arrivalDateTime.ToString("hh:mm tt");
                        string departureCity = Operations.getDepartureCity(i);
                        string arrivalCity = Operations.getArrivalCity(i);
                        string totalPriceOfTicket = Operations.GetTicketPrice(i).ToString();
                        Price_of_ticket = Operations.GetTicketPrice(i).ToString();
                        string seatPrice = "Seat Price: " + Price_of_ticket + " Rs";
                        Label l1 = attributes(i, startposition, endposition, departureCity, true); this.Controls.Add(l1);

                        Label seat = new Label();
                        seat.Name = seatPrice;
                        seat.Text = seatPrice;
                        seat.ForeColor = Color.Black;
                        seat.BackColor = Color.LightGray;
                        seat.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                        seat.Width = 230;
                        seat.Height = 30;
                        seat.Location = new Point(startposition + 170, endposition);
                        seat.TextAlign = ContentAlignment.MiddleCenter;
                        this.Controls.Add(seat);


                        startposition = 630;

                        Label l2 = attributes(i, startposition, endposition, arrivalCity, true);
                        startposition = 200; endposition += 30; this.Controls.Add(l2);

                        Label l3 = attributes(i, startposition, endposition, departureDate, false);
                        startposition = 630; this.Controls.Add(l3);

                        Button button = new Button();

                        // ======================== BUTTON for Bus Selection ========================================
                        button.Name = "Select Seat";
                        button.Text = "Select Seat";
                        button.ForeColor = Color.White;
                        button.BackColor = Color.Navy;
                        button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        button.Width = 160;
                        button.Height = 45;
                        button.Location = new Point(400, endposition + 28);
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Click += Button_Click; // Attach the event handler
                        buttons[i] = button;
                        this.Controls.Add(button);

                        Label l4 = attributes(i, startposition, endposition, arrivalDate, false);
                        startposition = 200; endposition += 30; this.Controls.Add(l4);
                        Label l5 = attributes(i, startposition, endposition, departureTime, false);
                        startposition = 630; this.Controls.Add(l5);
                        Label l6 = attributes(i, startposition, endposition, arrivalTime, false);
                        startposition = 200; endposition += 30; this.Controls.Add(l6);
                        this.Controls.Add(newPanel);

                        endposition += 100;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = Array.IndexOf(buttons, clickedButton);
            seats_selection _seat_selection_form = new seats_selection(buttonIndex);
            _seat_selection_form.Show();
            Hide();
        }

        private void GenerateDynamicUserControl() { }
        Label attributes(int i, int start, int end, string _value, bool bold)
        {
            Label info = new Label();
            info.Name = _value;
            info.Text = _value;
            info.ForeColor = Color.Black;
            info.BackColor = Color.LightGray;
            if (bold)
                info.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            else
                info.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            info.Width = 120;
            info.Height = 30;
            info.Location = new Point(start, end);
            info.TextAlign = ContentAlignment.MiddleCenter;
            return info;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_page h = new home_page();
            h.Show(); Hide();
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
    }
}
