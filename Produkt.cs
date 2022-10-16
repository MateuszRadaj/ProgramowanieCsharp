using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radajewski
{
    class Produkt
    {
        private string NazwaProduktu { get; set; }
        private float CenaNetto { get; set; }
        private float Podatek { get; set; }
        private int LiczbaDostepnych { get; set; }

        public Produkt()
        {
            this.NazwaProduktu = "Monitor";
            this.CenaNetto = 950;
            this.Podatek = 0.23F;
            this.LiczbaDostepnych = 8;
        }

        public Produkt(string nazwaProduktu, float cenaNetto, float podatek, int liczbaDostepnych)
        {
            this.NazwaProduktu = nazwaProduktu;
            this.CenaNetto = cenaNetto;
            this.Podatek = podatek;
            this.LiczbaDostepnych = liczbaDostepnych;
        }

        public float PodajCene()
        {
            return this.CenaNetto + (this.CenaNetto * this.Podatek);
        }

        public float PodajCene(int liczba)
        {
            return (this.CenaNetto + (this.CenaNetto*this.Podatek)) * liczba;
        }

        public virtual string Wyswietl()
        {
            return "Nazwa: "+this.NazwaProduktu+"\nCena brutto: "+this.PodajCene()+"\nLiczba dostepnych sztuk: "+this.LiczbaDostepnych+"\n";
        }
    }
}
