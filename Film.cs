using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFilmy

{
    abstract class Film : IComparable<Film>
    {
        string tytul;
        string rezyser;
        DateTime datawydania;
        protected static int nrseryjny;
        private string id;
        double dniDoOddania;
       
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        static Film()
        {
            nrseryjny = 1;
        }
        public Film(string tytul, string rezyser, string datawydania)
        {
            this.Tytul = tytul;
            this.rezyser = rezyser;
            this.datawydania = DateTime.Parse(datawydania);
            Id = $"ID-{this.datawydania.Year}-{nrseryjny++}";
            dniDoOddania = 14;
        }

        public string Id { get => id; set => id = value; }
        public string Tytul { get => tytul; set => tytul = value; }

        public virtual double dniWypozyczenia()
        {
            return dniDoOddania;
        }
        public override string ToString()
        {
            return $"\"{Tytul}\", {rezyser}, {datawydania.ToShortDateString()}, {Id}";
        }

        public int CompareTo(Film? other)
        {
            if (other is null)
            {
                return 1; // Bieżący obiekt jest większy, jeśli `other` jest null
            }
            return Tytul.CompareTo(other.Tytul);
        }

    }
}
