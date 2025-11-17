using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._5_Leny_Khoirina_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur Anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 17)
            {
                Console.WriteLine("Anda sudah dewasa. ");
            }
            else
            {
                Console.WriteLine("Anda masih anak-anak. ");
            }
        }
    }
}
