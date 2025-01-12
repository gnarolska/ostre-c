using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFilmy
{
       internal class Historyczny : Film
        {
            public Historyczny(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-HIS";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 21;
            }
            public override string ToString()
            {
                return $"Film historyczny {base.ToString()}";
            }
        }
        internal class ScienceFiction : Film
        {
            public ScienceFiction(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-Sci-fi";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 5;
            }
            public override string ToString()
            {
                return $"Film Science-fiction {base.ToString()}";
            }
        }
        internal class Biograficzny : Film
        {
            public Biograficzny(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-BIO";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 7;
            }
            public override string ToString()
            {
                return $"Film biograficzny {base.ToString()}";
            }
        }
        internal class DlaDzieci : Film
        {
            public DlaDzieci(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-kid";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia();
            }
            public override string ToString()
            {
                return $"Film dla dzieci {base.ToString()}";
            }
        }
        internal class Horror : Film
        {
            public Horror(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-HOR";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 7;
            }
            public override string ToString()
            {
                return $"Horror {base.ToString()}";
            }
        }
        internal class Fantasy : Film
        {
            public Fantasy(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-fan";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 10;
            }
            public override string ToString()
            {
                return $"Film fantasy {base.ToString()}";
            }
        }
        internal class Edukacyjny : Film
        {
            public Edukacyjny(string tytul, string rezyser, string datawydania) : base(tytul, rezyser, datawydania)
            {
                this.Id = $"{this.Id}-Edu";
            }
            public override double dniWypozyczenia()
            {
                return base.dniWypozyczenia() + 30;
            }
            public override string ToString()
            {
                return $"Film edukacyjny {base.ToString()}";
            }
        }
    }


