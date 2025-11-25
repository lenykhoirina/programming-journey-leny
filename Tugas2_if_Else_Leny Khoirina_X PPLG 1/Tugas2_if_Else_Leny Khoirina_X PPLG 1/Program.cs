using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_if_Else_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 60)
            {
                Console.WriteLine("Anda adalah Lansia.");
            }
            else
            {
                Console.WriteLine("Anda bukan Lansia.");
            }
        }
    }
}
