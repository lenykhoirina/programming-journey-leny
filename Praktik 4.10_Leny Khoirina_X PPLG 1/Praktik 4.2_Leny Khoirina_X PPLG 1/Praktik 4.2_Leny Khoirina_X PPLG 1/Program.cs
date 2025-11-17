using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._2_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan umur Anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 18)
            {
                Console.WriteLine("Anda sudah cukup umur untuk membuat KTP. ");
            }
        }
    }
}
