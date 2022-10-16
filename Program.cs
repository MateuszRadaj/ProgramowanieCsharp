using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radajewski
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produkt> listaProduktów = new List<Produkt>();

            Produkt p1 = new Produkt();
            Produkt p2 = new Produkt("Rower", 390, 0.23F, 4);
            listaProduktów.Add(p1);
            listaProduktów.Add(p2);

            Komputer k1 = new Komputer(); 
            Komputer k2 = new Komputer("KomputerAMD",3400,0.23F,2,"AMD","Windows8","32GB","AMD RADEON");
            listaProduktów.Add(k1);
            listaProduktów.Add(k2);

            foreach (Produkt prod in listaProduktów)
            {
                Console.WriteLine(prod.Wyswietl());
            }

        }
    }
}
