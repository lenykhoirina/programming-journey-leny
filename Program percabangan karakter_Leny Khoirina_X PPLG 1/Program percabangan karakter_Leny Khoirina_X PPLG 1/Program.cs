using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_percabangan_karakter_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program untuk mengetahui karakter yang diinputkan, 
            // apakah huruf Besar, huruf kecil, spasi, digit, atau yang lainnya
            Console.Write("Masukkan karakter : ");
            char karakter = Console.ReadKey().KeyChar; // Membaca 1 karakter
            Console.WriteLine(); // Pindah baris

            if (char.IsUpper(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah huruf besar.");
            }
            else if (char.IsLower(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah huruf kecil.");
            }
            else if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah spasi.");
            }
            else if (char.IsDigit(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah digit (angka).");
            }
            else
            {
                Console.WriteLine("Karakter yang diinputkan adalah karakter lainnya (simbol).");
            }
        }
    }
}
