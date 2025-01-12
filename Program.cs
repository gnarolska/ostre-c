namespace ProjektFilmy
{
    class Program
    {
        static void Main()
        {
            Proba();
        }
        public static void Proba()
        {
           
            Historyczny h1 = new("Lista Schindlera", "Steven Spielberg", "15-12-1993");
            Historyczny h2 = new("Gladiator", "Ridley Scott", "01-05-2000");

            
            ScienceFiction sf1 = new("Blade Runner", "Ridley Scott", "25-06-1982");
            ScienceFiction sf2 = new("Matrix", "Lana Wachowski, Lilly Wachowski", "31-03-1999");

            
            Biograficzny b1 = new("Teoria wszystkiego", "James Marsh", "07-11-2014");
            Biograficzny b2 = new("Bohemian Rhapsody", "Bryan Singer", "24-10-2018");

           
            DlaDzieci d1 = new("Król Lew", "Roger Allers, Rob Minkoff", "15-06-1994");
            DlaDzieci d2 = new("Shrek", "Andrew Adamson, Vicky Jenson", "18-05-2001");

            
            Horror hr1 = new("Egzorcysta", "William Friedkin", "26-12-1973");
            Horror hr2 = new("Lśnienie", "Stanley Kubrick", "23-05-1980");

            
            Fantasy f1 = new("Władca Pierścieni: Drużyna Pierścienia", "Peter Jackson", "19-12-2001");
            Fantasy f2 = new("Harry Potter i Kamień Filozoficzny", "Chris Columbus", "16-11-2001");

            
            Edukacyjny ed1 = new("Niewygodna prawda", "Davis Guggenheim", "24-05-2006");
            Edukacyjny ed2 = new("Nasza planeta", "Alastair Fothergill", "05-04-2019");

           
            Wypozyczalnia wypozyczalnia = new("Wypożyczalnia");
            wypozyczalnia.DodajFilm(h1); wypozyczalnia.DodajFilm(h2);
            wypozyczalnia.DodajFilm(sf1); wypozyczalnia.DodajFilm(sf2);
            wypozyczalnia.DodajFilm(b1); wypozyczalnia.DodajFilm(b2);
            wypozyczalnia.DodajFilm(d1); wypozyczalnia.DodajFilm(d2);
            wypozyczalnia.DodajFilm(hr1); wypozyczalnia.DodajFilm(hr2);
            wypozyczalnia.DodajFilm(f1); wypozyczalnia.DodajFilm(f2);
            wypozyczalnia.DodajFilm(ed1); wypozyczalnia.DodajFilm(ed2);
            wypozyczalnia.Sortuj();
            wypozyczalnia.WyswietlWszystkieFilmy();
            Profil p1 = new("555");
            p1.Wypozycz(wypozyczalnia, "Lista Schindlera");
            p1.Wypozycz(wypozyczalnia, "Matrix");
            p1.Wypozycz(wypozyczalnia, "Król Lew");

    
            p1.WyswietlWypozyczone();

            p1.PrzedluzWaznosc("Matrix", 10);

            p1.Oddaj(wypozyczalnia, "Król Lew");

          
            p1.WyswietlWypozyczone();
        }

    }
}