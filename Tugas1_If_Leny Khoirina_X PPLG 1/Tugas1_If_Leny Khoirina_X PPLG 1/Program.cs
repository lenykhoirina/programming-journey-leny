using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_If_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 100)
            {
                Console.WriteLine("Angka {0} lebih besar dari angka 100",angka);
            }
        }
    }
}
