using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._12_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu Makanan ===");
            Console.WriteLine("1. Nasi Goreng");
            Console.WriteLine("2. Mie Ayam");
            Console.WriteLine("3. Soto Ayam");
            Console.WriteLine("Pilih menu (1-3): ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1: Console.WriteLine("Anda memilih Nasi Goreng. Harga: Rp 15.000"); break;
                case 2: Console.WriteLine("Anda memilih Mie Ayam. Harga: Rp 12.000"); break;
                case 3: Console.WriteLine("Anda memilih Soto Ayam. Harga: Rp 10.000"); break;
                default: Console.WriteLine("Menu tidak tersedia!"); break;
            }
        }
    }
}
