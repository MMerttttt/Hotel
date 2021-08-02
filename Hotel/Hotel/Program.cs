using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel myHotel = new Hotel();

            Console.WriteLine("Wähle eines der Optionen aus");
            Console.WriteLine("1. Verfügbare Zimmer darstellen");
            Console.WriteLine("2. Checkin");
            string auswahl = Console.ReadLine();

            if(auswahl == "1")
            {
                myHotel.FreeRooms();
            }
            else if(auswahl == "2")
            {
                myHotel.CheckIn();
                string CheckInDaten = Console.ReadLine();
            }


        }


    }
}
