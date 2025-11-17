using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._7_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("Predikat: A");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Predikat: B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Predikat: C");
            }
            else
            {
                Console.WriteLine("Predikat: d");
            }
        }
    }
}
