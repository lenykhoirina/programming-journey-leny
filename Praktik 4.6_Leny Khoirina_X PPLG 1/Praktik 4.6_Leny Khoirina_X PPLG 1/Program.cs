using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._6_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai ujian: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Lulus.");
            }
            else
            {
                Console.WriteLine("Tidak Lulus.");
            }
        }
    }
}
