using System;

namespace proyek_akhir_Leny_Khoirina
{
    internal class Program
    {
        // Struktur data buku
        struct Buku
        {
            public string Judul;
            public string Penulis;
            public string ISBN;
            public int NoUrut;
            public bool Dipinjam;
        }

        // Array untuk menyimpan data buku
        static Buku[] daftarBuku = new Buku[100];
        static int jumlahBuku = 0;
        static int noUrutSelanjutnya = 1;


        // ===========================
        // === FUNGSI UTAMA (MENU) ===
        // ===========================
        static void Main(string[] args)
        {
            bool jalan = true;

            while (jalan)
            {
                Console.Clear();
                Console.WriteLine("=== APLIKASI MANAJEMEN PERPUSTAKAAN ===");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Tampilkan Semua Buku");
                Console.WriteLine("3. Cari Buku");
                Console.WriteLine("4. Pinjam Buku");
                Console.WriteLine("5. Kembalikan Buku");
                Console.WriteLine("6. Hapus Buku");
                Console.WriteLine("7. Keluar");
                Console.Write("Pilih menu: ");
                string pilih = Console.ReadLine();

                switch (pilih)
                {
                    case "1": TambahBuku(); break;
                    case "2": TampilkanSemuaBuku(); break;
                    case "3": CariBuku(); break;
                    case "4": PinjamBuku(); break;
                    case "5": KembalikanBuku(); break;
                    case "6": HapusBuku(); break;
                    case "7":
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                        Console.WriteLine("Tekan ENTER untuk keluar...");
                        Console.ReadLine();
                        jalan = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }

                if (jalan)
                {
                    Console.Write("\nApakah ingin menggunakan menu lain? (y/n): ");
                    string lanjut = Console.ReadLine().ToLower();
                    if (lanjut != "y")
                    {
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                        Console.WriteLine("Tekan ENTER untuk keluar...");
                        Console.ReadLine();
                        jalan = false;
                    }
                }
            }
        }

        // =====================================
        // == FUNGSI VALIDASI ISBN (13 DIGIT) ==
        // =====================================
        static bool ValidasiISBN(string isbn)
        {
            if (isbn.Length != 13)
            {
                Console.WriteLine("Maaf, ISBN tidak valid. Harus terdiri dari 13 digit angka.");
                return false;
            }
            foreach (char c in isbn)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Maaf, ISBN hanya boleh berisi angka.");
                    return false;
                }
            }
            return true;
        }

        // ==========================
        // === FUNGSI TAMBAH BUKU ===
        // ==========================
        static void TambahBuku()
        {
            Console.WriteLine("\n=== Tambah Buku Baru ===");
            Console.Write("Masukkan Judul Buku: ");
            string judul = Console.ReadLine();
            Console.Write("Masukkan Nama Penulis: ");
            string penulis = Console.ReadLine();
            Console.Write("Masukkan ISBN (13 digit): ");
            string isbn = Console.ReadLine();

            if (!ValidasiISBN(isbn))
            {
                Console.WriteLine("Kembali ke menu utama...");
                return;
            }

            daftarBuku[jumlahBuku].Judul = judul;
            daftarBuku[jumlahBuku].Penulis = penulis;
            daftarBuku[jumlahBuku].ISBN = isbn;
            daftarBuku[jumlahBuku].NoUrut = noUrutSelanjutnya;
            daftarBuku[jumlahBuku].Dipinjam = false;

            jumlahBuku++;
            noUrutSelanjutnya++;

            Console.WriteLine("Buku berhasil ditambahkan!");
        }

        // ===================================
        // === FUNGSI TAMPILKAN SEMUA BUKU ===
        // ===================================
        static void TampilkanSemuaBuku()
        {
            Console.WriteLine("\n=== Daftar Buku ===");
            if (jumlahBuku == 0)
            {
                Console.WriteLine("Belum ada buku yang terdaftar.");
                return;
            }

            for (int i = 0; i < jumlahBuku; i++)
            {
                Buku b = daftarBuku[i];
                Console.WriteLine($"\nJudul: {b.Judul}");
                Console.WriteLine($"Penulis: {b.Penulis}");
                Console.WriteLine($"ISBN: {b.ISBN}");
                Console.WriteLine($"Nomor Urut Buku: {b.NoUrut}");
                Console.WriteLine($"Status: {(b.Dipinjam ? "Dipinjam" : "Tersedia")}");
            }
        }

        // ========================
        // === FUNGSI CARI BUKU ===
        // ========================
        static void CariBuku()
        {
            Console.WriteLine("\n=== Cari Buku ===");
            Console.WriteLine("1. Berdasarkan Nomor Urut");
            Console.WriteLine("2. Berdasarkan ISBN");
            Console.WriteLine("3. Berdasarkan Judul");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            Buku? ditemukan = CariData(pilihan);
            if (ditemukan == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            TampilkanDetailBuku((Buku)ditemukan);
        }

        // ==========================
        // === FUNGSI PINJAM BUKU ===
        // ==========================
        static void PinjamBuku()
        {
            Console.WriteLine("\n=== Pinjam Buku ===");
            Console.WriteLine("1. Berdasarkan Nomor Urut");
            Console.WriteLine("2. Berdasarkan ISBN");
            Console.WriteLine("3. Berdasarkan Judul");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            Buku? ditemukan = CariData(pilihan);
            if (ditemukan == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            for (int i = 0; i < jumlahBuku; i++)
            {
                if (daftarBuku[i].NoUrut == ((Buku)ditemukan).NoUrut)
                {
                    if (daftarBuku[i].Dipinjam)
                    {
                        Console.WriteLine("Buku sudah dipinjam!");
                    }
                    else
                    {
                        daftarBuku[i].Dipinjam = true;
                        Console.WriteLine($"Buku '{daftarBuku[i].Judul}' berhasil dipinjam!");
                    }
                    return;
                }
            }
        }

        // ==============================
        // === FUNGSI KEMBALIKAN BUKU ===
        // ==============================
        static void KembalikanBuku()
        {
            Console.WriteLine("\n=== Kembalikan Buku ===");
            Console.WriteLine("1. Berdasarkan Nomor Urut");
            Console.WriteLine("2. Berdasarkan ISBN");
            Console.WriteLine("3. Berdasarkan Judul");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            Buku? ditemukan = CariData(pilihan);
            if (ditemukan == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            for (int i = 0; i < jumlahBuku; i++)
            {
                if (daftarBuku[i].NoUrut == ((Buku)ditemukan).NoUrut)
                {
                    if (!daftarBuku[i].Dipinjam)
                    {
                        Console.WriteLine("Buku belum dipinjam!");
                    }
                    else
                    {
                        daftarBuku[i].Dipinjam = false;
                        Console.WriteLine($"Buku '{daftarBuku[i].Judul}' berhasil dikembalikan!");
                    }
                    return;
                }
            }
        }

        // =========================
        // === FUNGSI HAPUS BUKU ===
        // =========================
        static void HapusBuku()
        {
            Console.WriteLine("\n=== Hapus Buku ===");
            Console.WriteLine("1. Berdasarkan Nomor Urut");
            Console.WriteLine("2. Berdasarkan ISBN");
            Console.WriteLine("3. Berdasarkan Judul");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            Buku? ditemukan = CariData(pilihan);
            if (ditemukan == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            for (int i = 0; i < jumlahBuku; i++)
            {
                if (daftarBuku[i].NoUrut == ((Buku)ditemukan).NoUrut)
                {
                    Console.WriteLine($"Buku '{daftarBuku[i].Judul}' berhasil dihapus!");
                    for (int j = i; j < jumlahBuku - 1; j++)
                        daftarBuku[j] = daftarBuku[j + 1];
                    jumlahBuku--;
                    return;
                }
            }
        }

        // ========================
        // === FUNGSI CARI BUKU ===
        // ========================
        static Buku? CariData(string pilihan)
        {
            if (pilihan == "1")
            {
                Console.Write("Masukkan Nomor Urut Buku: ");
                int nomor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < jumlahBuku; i++)
                    if (daftarBuku[i].NoUrut == nomor) return daftarBuku[i];
            }
            else if (pilihan == "2")
            {
                Console.Write("Masukkan ISBN Buku: ");
                string isbn = Console.ReadLine();
                if (!ValidasiISBN(isbn)) return null;
                for (int i = 0; i < jumlahBuku; i++)
                    if (daftarBuku[i].ISBN == isbn) return daftarBuku[i];
            }
            else if (pilihan == "3")
            {
                Console.Write("Masukkan Judul Buku: ");
                string judul = Console.ReadLine().ToLower();
                for (int i = 0; i < jumlahBuku; i++)
                    if (daftarBuku[i].Judul.ToLower().Contains(judul)) return daftarBuku[i];
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }

            return null;
        }

        // =================================
        // === FUNGSI TAMPIL DETAIL BUKU ===
        // =================================
        static void TampilkanDetailBuku(Buku b)
        {
            Console.WriteLine($"\nJudul: {b.Judul}");
            Console.WriteLine($"Penulis: {b.Penulis}");
            Console.WriteLine($"ISBN: {b.ISBN}");
            Console.WriteLine($"Nomor Urut Buku: {b.NoUrut}");
            Console.WriteLine($"Status: {(b.Dipinjam ? "Dipinjam" : "Tersedia")}");
        }
    }
}  