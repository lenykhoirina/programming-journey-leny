using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._7_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                // Tampilkan menu
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah Data");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda (1-3): ");

                // Baca Input pengguna 
                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid. Harap masukkan angka 1, 2, atau 3.");
                    // Tetapkan nilai selain 3 agar loop berlanjut
                    pilihan = 0;
                    continue;
                }

                // Proses pilihan
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data. ");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah Data. ");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break; // Keluar dari switch
                    default:
                        Console.WriteLine("Pilihan di luar jangkauan. Harap masukkan 1, 2, atau 3. ");
                        break;
                }

                // Kondisi loop: Lanjutkan selama pilihan BUKAN 3.
            } while (pilihan != 3);
            Console.WriteLine("Terima kasih telah menggunakan aplikasi.");
        }
    }
}
