using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TransitPRO;

namespace TransitPRO
{
    internal class Bus
    {
        char[] bus_seats = new char[40];
        int ticket_price;

        string arrival_city;
        string departure_city;

        DateTime departureDateTime;
        DateTime arrivalDateTime;

        TimeSpan trip_duration;

        public Bus(string departure_city, string arrival_city, DateTime departureDateTime, TimeSpan trip_duration, int ticket_price)
        {
            for (int i = 0; i < 40; i++)
            {
                bus_seats[i] = 'a';
            }
            this.arrivalDateTime = departureDateTime + trip_duration;
            this.ticket_price = ticket_price;
            this.departureDateTime = departureDateTime;
            this.arrival_city = arrival_city;
            this.departure_city = departure_city;
            this.trip_duration = trip_duration;
        }
        public DateTime ArrivalDateTime
        {
            get { return arrivalDateTime; }
        }
        public DateTime DepartureDateTime
        {
            get { return departureDateTime; }
        }

        public TimeSpan TripDuration
        {
            get { return trip_duration; }
        }
        public int TicketPrice
        {
            get { return ticket_price; }
        }

        public string ArrivalCity
        {
            get { return arrival_city; }
        }

        public string DepartureCity
        {
            get { return departure_city; }
        }

        public bool validateGender(int seat_no, char gender)
        {
            if (seat_no % 2 != 0)
            {
                if (bus_seats[seat_no - 1] == 'a' || bus_seats[seat_no - 1] == gender || bus_seats[seat_no - 1] == 'r')
                    return true;

                return false;
            }

            if (bus_seats[seat_no + 1] == 'a' || bus_seats[seat_no + 1] == gender || bus_seats[seat_no + 1] == 'r')
                return true;

            return false;
        }

        public char getSeatStatus(int seat_no)
        {
            return bus_seats[seat_no];
        }

        public void reserveSeat(int seat_no, char gender)
        {
            bus_seats[seat_no] = gender;
        }
    }
}

public class Operations
{
    static List<Bus> buses_scheduled = new List<Bus>();
    static string[] operational_cities = { "Islamabad", "Lahore", "Karachi", "Multan" };

    public static void initializeOperations()
    {
        DateTime Date1 = DateTime.Now;
        DateTime Date2 = Date1.AddDays(1);
        DateTime Date3 = Date2.AddDays(1);
        setDefaultOperations(Date1);
        setDefaultOperations(Date2);
        setDefaultOperations(Date3);
    }
    public static int GetTicketPrice(int index)
    {
        return buses_scheduled[index].TicketPrice;
    }
    public static string getArrivalCity(int index)
    {
        return buses_scheduled[index].ArrivalCity;
    }

    public static int TotalBusesScheduled()
    {
        return buses_scheduled.Count;
    }

    public static string getDepartureCity(int index)
    {
        return buses_scheduled[index].DepartureCity;
    }

    public static DateTime getArrivalDateTime(int index)
    {
        return buses_scheduled[index].ArrivalDateTime;
    }

    public static DateTime getDepartureDateTime(int index)
    {
        return buses_scheduled[index].DepartureDateTime;
    }

    public static TimeSpan trip_duration(int index)
    {
        return buses_scheduled[index].TripDuration;
    }

    public static char getSeatStatus(int index, int seat_no)
    {
        return buses_scheduled[index].getSeatStatus(seat_no);
    }
    public static void bookSeat(int index, int seat_no, char gender)
    {
        buses_scheduled[index].reserveSeat(seat_no, gender);
    }

    public static bool validateGender(int index, int seat_no, char gender)
    {
        return buses_scheduled[index].validateGender(seat_no, gender);
    }

    static void setDefaultOperations(DateTime currentDate)
    {
        /*============================================================================================================================================================*/
        /*------------------------------------------------------- Islamabad -> Lahore---------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 8, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 16, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 20, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Islamabad", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(4, 50, 0), 2350));

        /*------------------------------------------------------- Lahore -> Islamabad---------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 8, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 16, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 20, 0, 0), new TimeSpan(4, 50, 0), 2350));
        buses_scheduled.Add(new Bus("Lahore", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(4, 50, 0), 2350));
        /*=============================================================================================================================================================*/


        /*===============================================================================================================================================================*/
        /*-------------------------------------------------------- Islamabad -> Karachi----------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Islamabad", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 11, 0, 0), new TimeSpan(19, 50, 0), 8500));
        buses_scheduled.Add(new Bus("Islamabad", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 0, 0), new TimeSpan(19, 50, 0), 8500));
        buses_scheduled.Add(new Bus("Islamabad", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 0, 0), new TimeSpan(19, 50, 0), 8500));

        /*-------------------------------------------------------- Karachi -> Islamabad----------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Karachi", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 11, 0, 0), new TimeSpan(19, 50, 0), 8500));
        buses_scheduled.Add(new Bus("Karachi", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 0, 0), new TimeSpan(19, 50, 0), 8500));
        buses_scheduled.Add(new Bus("Karachi", "Islamabad", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 0, 0), new TimeSpan(19, 50, 0), 8500));
        /*==============================================================================================================================================================*/


        /*============================================================================================================================================================*/
        /*--------------------------------------------------------- Islamabad -> Multan-------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 8, 30, 0), new TimeSpan(6, 45, 0), 3200));
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 30, 0), new TimeSpan(6, 45, 0), 3200));
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 0, 0), new TimeSpan(6, 45, 0), 3200));

        /*--------------------------------------------------------- Multan -> Islamabad--------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 8, 30, 0), new TimeSpan(6, 45, 0), 3200));
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 30, 0), new TimeSpan(6, 45, 0), 3200));
        buses_scheduled.Add(new Bus("Islamabad", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 0, 0), new TimeSpan(6, 45, 0), 3200));
        /*=============================================================================================================================================================*/


        /*===========================================================================================================================================================*/
        /*--------------------------------------------------------- Lahore -> Karachi--------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Lahore", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(14, 50, 0), 7200));
        buses_scheduled.Add(new Bus("Lahore", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(14, 50, 0), 7200));
        buses_scheduled.Add(new Bus("Lahore", "Karachi", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(14, 50, 0), 7200));

        /*--------------------------------------------------------- Karachi -> Lahore -------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Karachi", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(14, 50, 0), 7200));
        buses_scheduled.Add(new Bus("Karachi", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(14, 50, 0), 7200));
        buses_scheduled.Add(new Bus("Karachi", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(14, 50, 0), 7200));
        /*===========================================================================================================================================================*/


        /*========================================================================================================================================================*/
        /*--------------------------------------------------------- Lahore -> Multan------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(4, 0, 0), 2200));
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(4, 0, 0), 2200));
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(4, 0, 0), 2200));

        /*--------------------------------------------------------- Multan -> Lahore-------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(4, 0, 0), 2200));
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(4, 0, 0), 2200));
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(4, 0, 0), 2200));
        /*=========================================================================================================================================================*/


        /*===========================================================================================================================================================*/
        /*-------------------------------------------------------- Karachi -> Multan---------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(11, 30, 0), 5500));
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(11, 30, 0), 5500));
        buses_scheduled.Add(new Bus("Lahore", "Multan", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(11, 30, 0), 5500));

        /*-------------------------------------------------------- Multan -> Karachi--------------------------------------------------------------------------------*/
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0), new TimeSpan(11, 30, 0), 5500));
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 14, 0, 0), new TimeSpan(11, 30, 0), 5500));
        buses_scheduled.Add(new Bus("Multan", "Lahore", new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 22, 0, 0), new TimeSpan(11, 30, 0), 5500));
        /*===========================================================================================================================================================*/
    }
}
