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
    public partial class UserControlofTICKETS : UserControl
    {
        public string arrivaldate, departuredate, arrivaltime, departuretime, departure, arrival, TotalPriceOfTicket;

        public UserControlofTICKETS()
        {
            InitializeComponent();
        }

        public void UpdateLabels()
        {
            label1.Text = arrivaldate;
            label2.Text = arrival;
            label3.Text = arrivaltime;
            label4.Text = departuredate;
            label5.Text = departure;
            //labelDepartureTime.Text = departuretime;
            //labelPrice.Text = TotalPriceOfTicket;
        }
    }

}
