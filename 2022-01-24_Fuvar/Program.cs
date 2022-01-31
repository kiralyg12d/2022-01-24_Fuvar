using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace _2022_01_24_Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();

            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));


            }

            Console.WriteLine($"3.feladat: {fuvarok.Count} fuvar$");

            double Bevétel = 0;
            int db = 0;
            foreach (var f in fuvarok)
            {
                if (f.TaxiID == 6185)
                {
                    Bevétel += f.Viteldij + f.Borravalo;
                    db++;
                }


            }
            Console.WriteLine($"4.feladat: {db} fuvar alatt: {Bevétel}$");

            // int bankkartyas = 0;
            //int keszpenz = 0;

            // foreach (var f in fuvarok)
            //{
            //if (f.FizetesMod == "bankkártya")
            //{
            //bankkartyas++;
            //}
            //if (f.FizetesMod == "keszpenz")
            //{
            //  keszpenz++;
            //  }
            //}

            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var f in fuvarok)
            {
                if (stat.ContainsKey(f.FizetesMod))
                {
                    stat[f.FizetesMod]++;

                }
                else
                {
                    stat.Add(f.FizetesMod, 1);
                }
            }

            Console.ReadKey();
        }
    }
}
