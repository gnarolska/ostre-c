using ProjektFilmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektFilmy
{
    internal class Wypozyczalnia
    {
        string nazwa;
        List<Film> WszystkieFilmy;
        public Wypozyczalnia(string nazwa)
        {
            this.nazwa = nazwa;
            WszystkieFilmy = new();
        }

        public void DodajFilm(Film film)
        {
            WszystkieFilmy.Add(film);
        }
        public void UsunFilm(Film film)
        {
            WszystkieFilmy.Remove(film);
        }

       public void Sortuj()
        {
            WszystkieFilmy.Sort();
        }
        public Film? WyszukajFilm(string tytul)
        {
            return WszystkieFilmy.FirstOrDefault(f => f.Tytul == tytul);
        }

        public void WyswietlWszystkieFilmy()
        {
            Console.WriteLine($"Filmy dostępne w wypożyczalni \"{nazwa}\":");
            foreach (var film in WszystkieFilmy)
            {
                Console.WriteLine(film);
            }
        }

        public void ZapiszXml(string nazwaPliku)
        {
            using StreamWriter sw = new(nazwaPliku);
            XmlSerializer xs = new(typeof(Wypozyczalnia));
            xs.Serialize(sw, this);
        }

        public static Wypozyczalnia? OdczytXml(string nazwaPliku)
        {
            if (!File.Exists(nazwaPliku)) { return null; }
            using StreamReader sr = new(nazwaPliku);
            XmlSerializer xs = new(typeof(Wypozyczalnia));
            return xs.Deserialize(sr) as Wypozyczalnia;
        }
    }

    interface IZapisywalna
    {
        void ZapiszXml(string nazwaPliku);
    }
}
