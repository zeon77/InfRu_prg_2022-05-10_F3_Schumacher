using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    internal class Nagydíj
    {
        public DateTime Dátum { get; set; }
        public string Név { get; set; }
        public int Pozíció { get; set; }
        public int KörökSzáma { get; set; }
        public int SzerzettPont { get; set; }
        public string Csapat { get; set; }
        public string Státusz { get; set; }

        public Nagydíj(string sor)
        {
            string[] t = sor.Split(';');
            Dátum = DateTime.Parse(t[0]);
            Név = t[1];
            Pozíció = int.Parse(t[2]);
            KörökSzáma = int.Parse(t[3]);
            SzerzettPont = int.Parse(t[4]);
            Csapat = t[5];
            Státusz = t[6];
        }
    }
}
