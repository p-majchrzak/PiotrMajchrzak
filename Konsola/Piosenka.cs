using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    public class Piosenka
    {
        public string Artysta { get; set; }
        public string Album { get; set; }
        public int piosenkaNumer { get; set; }
        public int Rok { get; set; }
        public int numerPobran { get; set; }
        public Piosenka(string artysta, string album, int piosenkaNumer, int rok, int numerPobran)
        {
            Artysta = artysta;
            Album = album;
            this.piosenkaNumer = piosenkaNumer;
            Rok = rok;
            this.numerPobran = numerPobran;
        }
    }
}
