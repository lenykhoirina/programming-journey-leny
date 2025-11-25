using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_Switch_Case_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka (1-5): ");
            int warna = int.Parse(Console.ReadLine());

            switch (warna)
            {
                case 1: Console.WriteLine("Biru"); break;
                case 2: Console.WriteLine("Hitam"); break;
                case 3: Console.WriteLine("Putih"); break;
                case 4: Console.WriteLine("Hijau"); break;
                case 5: Console.WriteLine("Merah"); break;
                default: Console.WriteLine("Input tidak valid!"); break;
            }
        }
    }
}
