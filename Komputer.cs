using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radajewski
{
    class Komputer : Produkt
    {
        private string NazwaProduktu { get; set; }
        private float CenaNetto { get; set; }
        private float Podatek { get; set; }
        private int LiczbaDostepnych { get; set; }
        private string RodzajProcesora { get; set; }
        private string SystemOperacyjny { get; set; }
        private string PamiecRAM { get; set; }
        private string KartaGraficzna { get; set; }

        public Komputer()
        {
            this.NazwaProduktu = "KomputerINTEL";
            this.CenaNetto = 2500;
            this.Podatek = 0.23F;
            this.LiczbaDostepnych = 5;
            this.RodzajProcesora = "Intel";
            this.SystemOperacyjny = "Windows10";
            this.PamiecRAM = "16GB";
            this.KartaGraficzna = "NVIDIA GEFORCE";
        }

        public Komputer(string nazwaProduktu, float cenaNetto, float podatek, int liczbaDostepnych, string rodzajProcesora, string systemOperacyjny, string pamiecRAM, string kartaGraficzna)
        {
            this.NazwaProduktu = nazwaProduktu;
            this.CenaNetto = cenaNetto;
            this.Podatek = podatek;
            this.LiczbaDostepnych = liczbaDostepnych;
            this.RodzajProcesora = rodzajProcesora;
            this.SystemOperacyjny = systemOperacyjny;
            this.PamiecRAM = pamiecRAM;
            this.KartaGraficzna = kartaGraficzna;
        }
    
        public override string Wyswietl()
        {
            return "Nazwa: "+this.NazwaProduktu+"\nCena brutto: "+(this.CenaNetto+(this.CenaNetto*this.Podatek))+"\nRodzaj procesora: "+this.RodzajProcesora + "\nSystem: " + this.SystemOperacyjny + "\nKarta graficzna" + this.KartaGraficzna + "\nPamiec RAM: " + this.PamiecRAM+"\n";
        }
        
    }
}
