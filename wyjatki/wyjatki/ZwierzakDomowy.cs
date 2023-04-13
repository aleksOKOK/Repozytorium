using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    internal class ZwierzakDomowy
    {
        private string nazwa;
        private string gatunek;
        private DateTime dataUrodzenia;

        public ZwierzakDomowy(string nazwa, string gatunek, DateTime dataUrodzenia)
        {
            this.nazwa = nazwa;
            this.gatunek = gatunek;
            this.dataUrodzenia = dataUrodzenia;
        }
        public int ObliczWiek()
        {
            int wiek = DateTime.Now.Year - dataUrodzenia.Year;
            if (dataUrodzenia.Year > DateTime.Now.Year)
            {
                throw new Exception("data urodzenia wychodzi w przyszlosc");
            }
            else if (wiek > 25)
            {
                throw new Exception("tfuj sfieszak to stary ciat");
            }
            return wiek;
        }
        public override string ToString()
        {
            return "nazwa: " + nazwa + "\ngatunek: " + gatunek +"\ndata urodzenia: " + dataUrodzenia + "\nwiek: " + ObliczWiek() + "\n\n";
        }
    }
}
