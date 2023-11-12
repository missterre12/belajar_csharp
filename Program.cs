using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

// Perintah untuk mencetak karakter
namespace perintah_percetakan_karakter {
    class Program {
        static void Main(string[] args) {
            Console.Write("cetak karakter tanpa pindah baris");
            Console.WriteLine("cetak karakter dengan pindah baris");
            Console.WriteLine("Saya sudah dipindahkan barisnya");
            Console.Read();
        }
    }
}

// Perintah masukan 
namespace perintah_masukan {
    class Program {
        static void Main(string[] args) {
            Console.Write("Masukkan nama Anda =\t");
            String nama = Console.ReadLine();
            Console.WriteLine("Nama Anda adalah {0}", nama);
            Console.Read();
        }
    }
}

// Perulangan dengan For
namespace perulangan_dengan_for {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Seluruh poin yang Anda kumpulkan ");
            for(int Point = 1; Point <= 10; Point++) {
                Console.WriteLine("Poin ke: "+ Point.ToString());
            }
            Console.Read();
        }
    }
}

// Perulangan dengan While 
namespace perulangan_dengan_while {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("==========Belajar Perulangan dengan While==========");
            int ngulang = 1;
            while (ngulang <= 4) {
                Console.WriteLine("\n ngulang lagi sampai lulus" + ngulang);
                ngulang++;
            } 
            Console.Read(); 
        }
    }
}