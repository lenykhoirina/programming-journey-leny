using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_KonversiMataUang_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT KURS
            double kursUSD = 16574; // 1 USD = 16.574 IDR
            double kursGBP = 22293; // 1 GBP = 22.293 IDR
            double kursJPY = 11250; // 1 JPY = 112,50 IDR
            double kursSAR = 4419;  // 1 SAR = 4.419  IDR

            Console.WriteLine("- - - KONVERSI MATA UANG - - -");
            Console.Write("Masukkan jumlah uang dalam Rupiah (IDR): ");
            double rupiah = Convert.ToDouble(Console.ReadLine());

            // Hitung hasil konversi
            double usd = rupiah / kursUSD;
            double gbp = rupiah / kursGBP;
            double jpy = rupiah / kursJPY;
            double sar = rupiah / kursSAR;

            // Tampilkan hasil 
            Console.WriteLine("\n - - - HASIL KONVERSI - - -");
            Console.WriteLine(" Jumlah Rupiah           : Rp " + rupiah.ToString("N0"));
            Console.WriteLine("Ke Dolar AS              : $ " + usd.ToString("N2"));
            Console.WriteLine("Ke Poundsterling Inggris : £ " + gbp.ToString("N2"));
            Console.WriteLine("Ke Yen Jepang            : ¥ " + jpy.ToString("N2"));
            Console.WriteLine(" Ke Riyal Saudi          : ﷼ " + sar.ToString("N2"));
        }
    }
}
