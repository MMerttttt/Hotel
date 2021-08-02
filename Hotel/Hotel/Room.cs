using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Room
    {
        public string zimmerwahlen = "Junior Suit, Standart Room, Meeting";
        public string wcs = "JS: 1, SR: 3, M: 0";
        public string better = "JS: 1, SR: 4, M: 0";
        public string anzahlpersonenplaetze = "";
        public int anzahlschlüssel = 2;
        public string zimmerName;
        public bool ZimmerBesetzt;
        

        public Room(string zName)
        {
            zimmerName = zName;
        }

        public void Zimmerputzen()
        {
            Console.WriteLine("Sie können uns anrufen unter der Nummer 044 233 38 33 und wir werden den Ptuzdienst vorbei senden");
        }


        public void GetTime()
        {
            Console.WriteLine("Wie lange wollen sie im Zimmer bleiben?");
        }

        public void ZimmerNr()
        {
            Console.WriteLine("in was für einen Art Zimmer seid ihr?");
        }


    }
}

