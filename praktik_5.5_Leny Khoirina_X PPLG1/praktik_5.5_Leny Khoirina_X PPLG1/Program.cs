using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._5_Leny_Khoirina_X_PPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Inisialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            // 2. Blok 'do-while'
            do
            {
                // Tampilkan nilai variabel 'angka' saat ini
                Console.WriteLine(angka);

                // Tambahkan nilai 'angka' sebanyak 1 (increment)
                angka++;

                // Uji kondisi: Loop berlanjut selama 'angka' kurang dari atau sama dengan
            } while (angka <= 20);

            Console.WriteLine("Selesai.");
        }
    }
}
