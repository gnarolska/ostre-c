using ProjektFilmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFilmy
{
    internal class Profil
    {
        string IdUzytkownika;
        DateTime kiedyOddac;
        Dictionary<string, (Film film, DateTime dataWypozyczenia)> wypozyczone;

        public Profil(string IdUzytkownika)
        {
            this.IdUzytkownika = IdUzytkownika;
            wypozyczone = new();
        }

        public void Wypozycz(Wypozyczalnia wypozyczalnia, string tytul)
        {
            var f = wypozyczalnia.WyszukajFilm(tytul);
            if (f != null)
            {
                if (!wypozyczone.ContainsKey(tytul))
                {
                    wypozyczone.Add(tytul, (f, DateTime.Now));
                    wypozyczalnia.UsunFilm(f);
                    kiedyOddac = DateTime.Now.AddDays(f.dniWypozyczenia());
                    f.DataOddania = kiedyOddac;
                    Console.WriteLine($"Film \"{f.Tytul}\" został wypożyczony. Termin zwrotu: {kiedyOddac.ToString()}.");
                }
            }
        }

        public void Oddaj(Wypozyczalnia wypozyczalnia, string tytul)
        {
            if (wypozyczone.TryGetValue(tytul, out var film))
            {
                wypozyczone.Remove(film.film.Tytul);
                wypozyczalnia.DodajFilm(film.film);
                Console.WriteLine($"Film \"{film.film.Tytul}\" został oddany.");
            }
        }

        public void PrzedluzWaznosc(string tytul, int dni)
        {
            if (wypozyczone.ContainsKey(tytul))
            {
                var (film, dataWypozyczenia) = wypozyczone[tytul];

                if ((DateTime.Now - dataWypozyczenia).TotalDays > 90)
                {
                    throw new ZbytDlugoException("Brak dalszej możliwości przedłużania");
                }
                else
                {
                    kiedyOddac = kiedyOddac.AddDays(dni);
                    film.DataOddania = kiedyOddac;
                    Console.WriteLine($"Wypożyczenie filmu \"{film.Tytul}\" zostało przedłużone do: {kiedyOddac.ToString()}.");
                }
            }
        }

        public void WyswietlWypozyczone()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"Wypożyczone filmy użytkownika \"{IdUzytkownika}\":");
            foreach (var f in wypozyczone.Values)
            {
                sb.AppendLine($"Tytuł: {f.film.Tytul}, data oddania: {f.film.DataOddania}");
            }
            Console.WriteLine(sb.ToString());
        }
    }

    internal class ZbytDlugoException : Exception
    {
        public ZbytDlugoException() { }
        public ZbytDlugoException(string message) : base(message) { }
        public ZbytDlugoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
