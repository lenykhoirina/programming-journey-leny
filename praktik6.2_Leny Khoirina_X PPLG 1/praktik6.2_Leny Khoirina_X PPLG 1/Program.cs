using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik6._2_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array integer dengan 5 elemen
            int[] angka = new int[5];

            // Input elemen array dari keyboard
            Console.Write("Masukkan nilai ke-1: ");
            angka[0] = Convert.ToInt32((string)Console.ReadLine());

            Console.Write("Masukkan nilai ke-2: ");
            angka[1] = Convert.ToInt32((string)Console.ReadLine());

            Console.Write("Masukkan nilai ke-3: ");
            angka[2] = Convert.ToInt32((string)Console.ReadLine());

            Console.Write("Masukkan nilai ke-4: ");
            angka[3] = Convert.ToInt32((string)Console.ReadLine());

            Console.Write("Masukkan nilai ke-5: ");
            angka[4] = Convert.ToInt32((string)Console.ReadLine());

            // Menampilkan isi array tanpa perulangan 
            Console.WriteLine("\nData yang Anda masukkan:");
            Console.WriteLine("Nilai ke-1: " + angka[0]);
            Console.WriteLine("Nilai ke-2: " + angka[1]);
            Console.WriteLine("Nilai ke-3: " + angka[2]);
            Console.WriteLine("Nilai ke-4: " + angka[3]);
            Console.WriteLine("Nilai ke-5: " + angka[4]);
        }
    }
}
