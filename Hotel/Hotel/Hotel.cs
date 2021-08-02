using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Hotel
    {
        public string hotelname = "Antalya Side";
        public string telefonnummer = "+41 76 489 77 23";
        public string lage = "Alara Türkei";
        public string adresse = "07415 Alanya/Antalya";
        public int anzahlmitarbeiter = 200;
        private int umsatz = 22234000;
        public List<Room> rooms = new List<Room>();

        public Hotel()
        {
            Console.WriteLine("Herzlich wilkommen im Hotel " + hotelname);
            Console.ReadLine();
            Room zimmer = new Room("Alpenblick");
            zimmer.ZimmerBesetzt = false;
            rooms.Add(zimmer);
            Room zimmerzwei = new Room("Zuerichsee");
            zimmer.ZimmerBesetzt = false;
            rooms.Add(zimmerzwei);
        }

        public void FreeRooms()
        {
            int anzahlFreieZimmer = 0;
            foreach(Room zimmer in rooms)
            {
                if (zimmer.ZimmerBesetzt == false)
                {
                    anzahlFreieZimmer++;
                }
            }
            Console.WriteLine(anzahlFreieZimmer);

        }

        public void LunchTime()
        {
            Console.WriteLine("Morgen: 07:00-09:00, Mittag: 11:30-13:00, SnackTime: 15:00-17:00, Abend: 19:00-21:00");
        }

        public void TheaterThema()
        {
            Console.WriteLine("MO: HipHop Dancing, DI: Comedy-Show, MI: National-Day, DO: Quiz-Event, FR: Disco-Time, SA: - SO: -");
        }

        public void CheckIn()
        {
            Console.WriteLine("Geben sie ihren Namen, Nachnamen & ihr Alter ein");
        }

        public void KundenAnzahl()
        {
            int KundenAnzahl = 1300;
            Console.WriteLine(KundenAnzahl);
        }

        public void PoolreinigungsZeit()
        {
            Console.WriteLine("");
        }
    }
}
