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
        public string uzemanyag;
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
                string[] egysor = forras[i].Split('\t');

                auto egyadat = new auto();

                egyadat.marka = egysor[0];
                egyadat.modell = egysor[1];
                egyadat.evjarat = Convert.ToInt32(egysor[2]);
                egyadat.km = Convert.ToInt32(egysor[3]);
                egyadat.uzemanyag = egysor[4];
                egyadat.ar = Convert.ToInt32(egysor[5]);

                kocsi.Add(egyadat);
            }
        }
        static void feladat2()
        {
            int hanyauto = 0;
            for (int i = 0; i < kocsi.Count; i++)
            {
                hanyauto++;
            }
            Console.WriteLine("{0} autó található az állományban.",hanyauto);
        }
        static void feladat3()
        {
            int toyotaar = 0;
        }
        static void feladat4()
        {
            int fiatalevjarat = kocsi[1].evjarat;
            for (int i = 0; i < kocsi.Count; i++)
            {
                if (kocsi[i].evjarat < fiatalevjarat)
                {
                    fiatalevjarat = kocsi[i].evjarat;
                }
            }
            Console.WriteLine("A legfiatalabb évjáratú autó: {0}", fiatalevjarat);
        }
        static void feladat5()
        {
            int hibrid = 0;
            for (int i = 0; i < kocsi.Count; i++)
            {
                if (kocsi[i].uzemanyag == "hibrid")
                {
                    hibrid = 1;
                }
                else
                {
                    hibrid = 0;
                }
            }
            if (hibrid == 1)
            {
                Console.WriteLine("Van hibrid autó.");
            }
            else
            {
                Console.WriteLine("Nincs hibrid autó.");
            }
        }
        static void Main(string[] args)
        {
            beolvaso();
            feladat2();
            feladat3();
            feladat4();
            feladat5();

            Console.ReadKey();
        }
    }
}
