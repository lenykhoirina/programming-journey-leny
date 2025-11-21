using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_percabangan_pembayaran_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program untuk mempermudah  pembayaran di suatu bioskop
            Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP ===");
            Console.WriteLine("Pilih Jenis Film: ");
            Console.WriteLine("1. Horor");
            Console.WriteLine("2. Romantis");
            Console.Write("Masukkan pilihan (1/2): ");
            int jenis = int.Parse(Console.ReadLine());
            int harga = 0;
            string judul = "";

            // Pilihan untuk film Horor
            if (jenis == 1)
            {
                Console.WriteLine("\n--- Daftar Film Horor ---");
                Console.WriteLine("1. Kang Solah From Kang Mak x Nenek Gayung\tRp 30000");
                Console.WriteLine("2. Death Whisperer 3\tRp 35000");
                Console.WriteLine("3. Rest Area\t\tRp 40000");
                Console.Write("Pilih nomor film: ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "Kang Solah From Kang Mak x Nenek Gayung";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "Death whisperer 3";
                    harga = 35000;
                }
                else if (pilih == 3)
                {
                    judul = "Rest Area";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    return;
                }

            }
            // Pilihan untuk film Romantis 
            else if (jenis == 2)
            {
                Console.WriteLine("\n--- Daftar Film Romantis ---");
                Console.WriteLine("1. The Architecture of love\t Rp 35000");
                Console.WriteLine("2. Sampai Nanti, Hanna!\t         Rp 30000");
                Console.WriteLine("3. Love For Sale\t         Rp 40000");
                Console.Write("Pilih nomor film: ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "The Architecture of love";
                    harga = 35000;
                }
                else if (pilih == 2)
                {
                    judul = "Sampai Nanti, Hanna!";
                    harga = 30000;
                }
                else if (pilih == 3)
                {
                    judul = "Love for Sale";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Pilihan jenis film  tdak valid!");
                return;
            }

            // Menampilkan hasil
            Console.WriteLine("\n=========================================");
            Console.WriteLine("Judul Film\t: " + judul);
            Console.WriteLine("Harga Tiket\t: Rp " + harga);
            Console.WriteLine("=========================================");
            Console.WriteLine("Terima kasih telah membeli tiket!");
        }

    }
}
