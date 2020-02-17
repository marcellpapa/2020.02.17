using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace git
{
    class auto
    {
        public string marka;
        public string modell;
        public int evjarat;
        public int km;
        public int uzemanyag;
        public int ar;
    }

    class Program
    {
        static List<auto> kocsi = new List<auto>();

        static void beolvaso()
        {
            string[] forras = File.ReadAllLines("auto.txt");
            for (int i = 0; i < forras.Length; i++)
            {
                string[] egysor = forras[i].Split(' ');

                auto egyadat = new auto();

                egyadat.marka = egysor[0];
                egyadat.modell = egysor[1];
                egyadat.evjarat = Convert.ToInt32(egysor[2]);
                egyadat.km = Convert.ToInt32(egysor[3]);
                egyadat.uzemanyag = Convert.ToInt32(egysor[4]);
                egyadat.ar = Convert.ToInt32(egysor[5]);

                kocsi.Add(egyadat);
            }
        }
        static void feladat1()
        {

        }
        static void Main(string[] args)
        {
            beolvaso();
            feladat1();
        }
    }
}
