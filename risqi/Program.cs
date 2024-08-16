using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiListBilanganPrima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi List Bilangan Prima");
            Console.WriteLine("============================");
            Console.WriteLine("Nama : Rizqi Fakhrianto");
            Console.WriteLine("Kelas : X PPLG");
            Console.WriteLine("Absen : 30");

            for (int num = 2; num <= 1000; num++)
            {
                bool isPrima = true;
                for (int pembagi = 2; pembagi <= Math.Sqrt(num); pembagi++)
                {
                    if (num % pembagi == 0)
                    {
                        isPrima = false;
                        break;
                    }
                }
                if (isPrima)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
