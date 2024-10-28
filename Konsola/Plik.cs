using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    public static class Plik
    {
        public static List<Piosenka> PobierzPlik(string sciezka)
        {
            List <Piosenka> listaPiosenek = new List<Piosenka>();
            StreamReader czytaj = new StreamReader(sciezka);
            while(!czytaj.EndOfStream)
            {
                string artysta = czytaj.ReadLine();
                string album = czytaj.ReadLine();
                int piosenkaNumer = int.Parse(czytaj.ReadLine());
                int rok = int.Parse(czytaj.ReadLine());
                int numerPobran = int.Parse(czytaj.ReadLine());
                string pominLinie = czytaj.ReadLine();
                Piosenka piosenka = new Piosenka(artysta,album,piosenkaNumer,rok,numerPobran);
                listaPiosenek.Add(piosenka);
            }
            czytaj.Close();
            return listaPiosenek;
        }
        public static void Wypisz(List<Piosenka> listaPiosenek)
        {
            foreach(Piosenka piosenka in listaPiosenek)
            {
                Console.WriteLine($"{piosenka.Artysta}\n{piosenka.Album}\n{piosenka.piosenkaNumer}\n{piosenka.Rok}\n{piosenka.numerPobran}");
            }
        }
    }
}
