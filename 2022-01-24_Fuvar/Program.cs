﻿using System;
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

            Console.ReadKey();
        }
    }
}
