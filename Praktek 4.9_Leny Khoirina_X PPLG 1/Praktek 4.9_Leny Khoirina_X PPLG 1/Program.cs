using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._9_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("Tiket Gratis. ");
            }
            else if (umur <=12)
            {
                Console.WriteLine("Harga Tiket: Rp 20.000");
            }
            else if (umur <=60)
            {
                Console.WriteLine("Harga Tiket: Rp 50.000");
            }
            else
            {
                Console.WriteLine("Harga Tiket: Rp 30.000 (Diskon Lansia)");
            }
        }
    }
}
