using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2982019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("      29/08/2019 - PPK v 1.0     ");
            Console.WriteLine("=================================\n");

            Console.WriteLine("======== PERSEGI PANJANG ========");
            Console.Write("Masukkan panjang : ");
            double p = Double.Parse(Console.ReadLine());
            Console.Write("Masukkan lebar   : ");
            double l = Double.Parse(Console.ReadLine());
            Console.WriteLine("Luas             : "+luasPersegiPanjang(p,l));
            Console.WriteLine("======== =-------------= ========");

            Console.WriteLine("\n======== =-- SEGITIGA -= ========");
            Console.Write("Masukkan alas    : ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi  : ");
            double t = Double.Parse(Console.ReadLine());
            Console.WriteLine("Luas             : " + luasSegitiga(a,t));
            Console.WriteLine("======== =-------------= ========");

            Console.WriteLine("\n======== =- LINGKARAN -= ========");
            Console.Write("Masukkan jari-jari : ");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Luas                 : " + luasLingkaran(r));
            Console.WriteLine("======== =-------------= ========");

            Console.WriteLine("\n======== =-- PERSEGI --= ========");
            Console.Write("Masukkan lebar           : ");
            double s = Double.Parse(Console.ReadLine());
            Console.WriteLine("Luas           : " + luasPersegi(s));
            Console.WriteLine("======== =-------------= ========");

            Console.Write("\n ...(mfahmialif)");
            Console.ReadKey(true);
        }

        static double luasPersegiPanjang(double p,double l)
        {
            return p * l;
        }

        static double luasSegitiga(double a, double t)
        {
            return a * t/2;
        }

        static double luasLingkaran(double r)
        {
            return Math.Round(Math.PI,2) * r * r;
        }

        static double luasPersegi(double s)
        {
            return s * s;
        }
    }
}
