using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._1_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Angka positif.");
            }
        }
    }
}
