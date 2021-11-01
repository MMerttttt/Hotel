using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Visitor
    {
        public string Vorname;
        public string Nachname;
        
        public Visitor()
        {

        }

        public void EinChecken()
        {
            Console.WriteLine("Gib deinen Vor- & Nachnamen ein");
            string Daten = Console.ReadLine();
            Console.WriteLine("Wähle eines der Zimmer aus:");

        }


        public void ZimmerWahl()
        {
            string ZimmerWahl = Console.ReadLine();

            if (ZimmerWahl == "Alpenblick")
            {
                
            }

        }

        public void Leange()
        {
            Console.WriteLine("Wie lange möchtest du drin bleiben");
            string BleibLaenge = Console.ReadLine();
        }


    }
}
