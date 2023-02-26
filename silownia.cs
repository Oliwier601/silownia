using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Klub
    {
        private Pracownik pracownik;
        private Klient klient;
        public string godzina_otwarcia;
        public string godzina_zamkniecia;

        public void set_otwarcie(string godzina_otwarcia)
        {
            this.godzina_otwarcia = godzina_otwarcia;
        }
        public void set_zamkniecie(string godzina_zamkniecia)
        {
            this.godzina_zamkniecia = godzina_zamkniecia;
        }
    }
    class Klient
    {
        private Klub klub;
        public int Id_klienta;
        private string imie;
        private string nazwisko;
        private string pesel;
        public Klient(Klub klub, int Id_klienta, string imie, string nazwisko, string pesel)
        {
            this.klub = klub;
            this.Id_klienta = Id_klienta;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }
    }
    class Pracownik
    {
        private Klub klub;
        public int Id_pracownika;
        private string imie;
        private string nazwisko;
        public Pracownik(Klub klub, int Id_pracownika, string imie, string nazwisko)
        {
            this.klub = klub;
            this.Id_pracownika = Id_pracownika;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    class Karnet
    {
        private Klub klub;
        private Klient klient;
        public string data_rozpoczecia;
        public string data_zakonczenia;

        public void set_data_rozpoczecia()
        {
            Console.WriteLine("Podaj datę rozpoczęcia");
            data_rozpoczecia = Console.ReadLine();
        }
        public void set_data_zakonczenia()
        {
            Console.WriteLine("Podaj datę zakończenia");
            data_zakonczenia = Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
