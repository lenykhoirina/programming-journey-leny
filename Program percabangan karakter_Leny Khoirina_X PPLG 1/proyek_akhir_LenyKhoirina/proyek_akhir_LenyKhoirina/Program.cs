using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyek_akhir_LenyKhoirina
{
    internal class Program
    { 
            struct Buku
            {
                public string Judul;
                public string Pengarang;
                public string ISBN;
                public bool Dipinjam;
            }

            static Buku[] daftarBuku = new Buku[100];
            static int jumlahBuku = 0;

            static void Main(string[] args)
            {
                bool keluar = false;

                while (!keluar)
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEM MANAJEMEN PERPUSTAKAAN ===");
                    Console.WriteLine("1. Tambah Buku");
                    Console.WriteLine("2. Tampilkan Semua Buku");
                    Console.WriteLine("3. Pinjam Buku");
                    Console.WriteLine("4. Kembalikan Buku");
                    Console.WriteLine("5. Cari Buku");
                    Console.WriteLine("6. Hapus Buku");
                    Console.WriteLine("7. Keluar");
                    Console.Write("Pilih menu (1-7): ");
                    string pilihan = Console.ReadLine();

                    switch (pilihan)
                    {
                        case "1": TambahBuku(); break;
                        case "2": TampilkanBuku(); break;
                        case "3": PinjamBuku(); break;
                        case "4": KembalikanBuku(); break;
                        case "5": CariBuku(); break;
                        case "6": HapusBuku(); break;
                        case "7": keluar = true; break;
                        default:
                            Console.WriteLine("\nPilihan tidak valid!");
                            Console.ReadLine();
                            break;
                    }
                }
            }

            // === Tambah Buku ===
            static void TambahBuku()
            {
                Console.Clear();
                Console.WriteLine("=== TAMBAH BUKU BARU ===");

                Console.Write("Masukkan Judul Buku: ");
                string judul = Console.ReadLine();

                Console.Write("Masukkan Nama Pengarang: ");
                string pengarang = Console.ReadLine();

                Console.Write("Masukkan ISBN (13 digit): ");
                string isbn = Console.ReadLine();

                 // Validasi ISBN
                if (isbn.Length != 13 || !long.TryParse(isbn, out _))
                {
                     Console.WriteLine("ISBN tidak valid! Harus terdiri dari 13 digit angka.");
                     return;
                }

                // Cek ISBN sudah digunakan atau belum
                for (int i = 0; i < jumlahBuku; i++)
                {
                    if (daftarBuku[i].ISBN == isbn)
                    {
                         Console.WriteLine("ISBN sudah terdaftar, gunakan ISBN lain!");
                         return;
                    }
                }

                daftarBuku[jumlahBuku].Judul = judul;
                daftarBuku[jumlahBuku].Pengarang = pengarang;
                daftarBuku[jumlahBuku].ISBN = isbn;
                daftarBuku[jumlahBuku].Dipinjam = false;

                jumlahBuku++;

                Console.WriteLine("\nBuku berhasil ditambahkan!");
                Console.WriteLine($"Nomor Buku : {jumlahBuku}");
                Console.WriteLine($"Judul      : {judul}");
                Console.WriteLine($"Pengarang  : {pengarang}");
                Console.WriteLine($"ISBN       : {isbn} (13 digit)");
                Console.WriteLine($"Status     : Tersedia");

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }

            // === Tampilkan Semua Buku ===
            static void TampilkanBuku()
            {
                Console.Clear();
                Console.WriteLine("=== DAFTAR SEMUA BUKU ===");
                Console.Write("Masukkan Nomor Buku yang ingin dipinjam: ");
                int nomor = int.Parse( Console.ReadLine() );

            if (jumlahBuku == 0)
                {
                    Console.WriteLine("Belum ada buku yang ditambahkan.");
                }
                else
                {
                    for (int i = 0; i < jumlahBuku; i++)
                    {
                        Console.WriteLine($"Nomor Buku : {i + 1}");
                        Console.WriteLine($"Judul      : {daftarBuku[i].Judul}");
                        Console.WriteLine($"Pengarang  : {daftarBuku[i].Pengarang}");
                        Console.WriteLine($"ISBN       : {daftarBuku[i].ISBN}");
                        Console.WriteLine($"Status     : {(daftarBuku[i].Dipinjam ? "Sedang Dipinjam" : "Tersedia")}");
                        Console.WriteLine("---------------------------------------");
                    }
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }

            // === Pinjam Buku ===
            static void PinjamBuku()
            {
                Console.Clear();
                Console.WriteLine("=== PINJAM BUKU ===");

                if (jumlahBuku == 0)
                {
                    Console.WriteLine("Belum ada buku yang tersedia untuk dipinjam.");
                }
                else
                {
                    TampilkanBuku();
                    Console.Write("Masukkan Nomor Buku yang ingin dipinjam: ");
                    int nomor = int.Parse(Console.ReadLine());

                    if (nomor > 0 && nomor <= jumlahBuku)
                    {
                        if (!daftarBuku[nomor - 1].Dipinjam)
                        {
                            daftarBuku[nomor - 1].Dipinjam = true;
                            Console.WriteLine($"\nBuku '{daftarBuku[nomor - 1].Judul}' (Nomor {nomor}) berhasil dipinjam!");
                        }
                        else
                        {
                            Console.WriteLine("\nBuku ini sedang dipinjam oleh orang lain!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNomor buku tidak valid!");
                    }
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }

            // === Kembalikan Buku ===
            static void KembalikanBuku()
            {
                Console.Clear();
                Console.WriteLine("=== KEMBALIKAN BUKU ===");

                if (jumlahBuku == 0)
                {
                    Console.WriteLine("Belum ada buku dalam sistem.");
                }
                else
                {
                    TampilkanBuku();
                    Console.Write("Masukkan Nomor Buku yang ingin dikembalikan: ");
                    int nomor = int.Parse(Console.ReadLine());

                    if (nomor > 0 && nomor <= jumlahBuku)
                    {
                        if (daftarBuku[nomor - 1].Dipinjam)
                        {
                            daftarBuku[nomor - 1].Dipinjam = false;
                            Console.WriteLine($"\nBuku '{daftarBuku[nomor - 1].Judul}' (Nomor {nomor}) berhasil dikembalikan!");
                        }
                        else
                        {
                            Console.WriteLine("\nBuku ini tidak sedang dipinjam.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNomor buku tidak ditemukan!");
                    }
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }

            // === Cari Buku ===
            static void CariBuku()
            {
                Console.Clear();
                Console.WriteLine("=== CARI BUKU ===");
                Console.WriteLine("1. Berdasarkan Nomor Buku");
                Console.WriteLine("2. Berdasarkan Judul Buku");
                Console.Write("Pilih opsi (1/2): ");
                string pilihan = Console.ReadLine();

                bool ditemukan = false;

                if (pilihan == "1")
                {
                    Console.Write("Masukkan Nomor Buku: ");
                    int nomor = int.Parse(Console.ReadLine());

                    if (nomor > 0 && nomor <= jumlahBuku)
                    {
                        Console.WriteLine("\n=== HASIL PENCARIAN ===");
                        Console.WriteLine($"Nomor Buku : {nomor}");
                        Console.WriteLine($"Judul      : {daftarBuku[nomor - 1].Judul}");
                        Console.WriteLine($"Pengarang  : {daftarBuku[nomor - 1].Pengarang}");
                        Console.WriteLine($"ISBN       : {daftarBuku[nomor - 1].ISBN}");
                        Console.WriteLine($"Status     : {(daftarBuku[nomor - 1].Dipinjam ? "Sedang Dipinjam" : "Tersedia")}");
                        ditemukan = true;
                    }
                }
                else if (pilihan == "2")
                {
                    Console.Write("Masukkan Judul Buku: ");
                    string keyword = Console.ReadLine().ToLower();

                    Console.WriteLine("\n=== HASIL PENCARIAN ===");
                    for (int i = 0; i < jumlahBuku; i++)
                    {
                        if (daftarBuku[i].Judul.ToLower().Contains(keyword))
                        {
                            Console.WriteLine($"Nomor Buku : {i + 1}");
                            Console.WriteLine($"Judul      : {daftarBuku[i].Judul}");
                            Console.WriteLine($"Pengarang  : {daftarBuku[i].Pengarang}");
                            Console.WriteLine($"ISBN       : {daftarBuku[i].ISBN}");
                            Console.WriteLine($"Status     : {(daftarBuku[i].Dipinjam ? "Sedang Dipinjam" : "Tersedia")}");
                            Console.WriteLine("---------------------------------------");
                            ditemukan = true;
                        }
                    }
                }

                if (!ditemukan)
                {
                    Console.WriteLine("\nBuku tidak ditemukan.");
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }

            // === Hapus Buku ===
            static void HapusBuku()
            {
                Console.Clear();
                Console.WriteLine("=== HAPUS BUKU ===");

                if (jumlahBuku == 0)
                {
                    Console.WriteLine("Belum ada buku yang bisa dihapus.");
                }
                else
                {
                    TampilkanBuku();
                    Console.Write("Masukkan Nomor Buku yang ingin dihapus: ");
                    int nomor = int.Parse(Console.ReadLine());

                    if (nomor > 0 && nomor <= jumlahBuku)
                    {
                        Console.WriteLine($"\nBuku '{daftarBuku[nomor - 1].Judul}' (Nomor {nomor}) akan dihapus.");
                        Console.Write("Apakah Anda yakin? (y/n): ");
                        string konfirmasi = Console.ReadLine();

                        if (konfirmasi.ToLower() == "y")
                        {
                            for (int i = nomor - 1; i < jumlahBuku - 1; i++)
                            {
                                daftarBuku[i] = daftarBuku[i + 1];
                            }
                            jumlahBuku--;
                            Console.WriteLine("\nBuku berhasil dihapus!");
                        }
                        else
                        {
                            Console.WriteLine("\nPenghapusan dibatalkan.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNomor buku tidak valid!");
                    }
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }
        }
    }


    

