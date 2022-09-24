using System;
namespace kalkulator{
    class Program {
        private const char V = 'y';

        static void Main(){
            int a, b, pil;
            bool Ulangi = true;

            while (Ulangi)
            {
                Console.WriteLine("\npilih aksi yang ingin dilakukan: ");
                Console.WriteLine("tekan 1: panjumlahan");
                Console.WriteLine("tekan 2: pengurangan");
                Console.WriteLine("tekan 3: perkalian");
                Console.WriteLine("tekan 4: pembagian");

                Console.Write("Masukkan pilihan anda: ");
                pil = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nMasukkan nilai ke-1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan nilai ke-2: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (pil == 1){
                    Console.Write("Hasil penjulmlahan " + a + " + " + b + " = ");
                    Console.Write(tambah(a, b));

                } else if(pil == 2){
                    Console.Write("Hasil pengurangan " + a + " - " + b + " = ");
                    Console.Write(kurang(a, b));

                } else if(pil == 3){
                    Console.Write("Hasil perkalian " + a + " X " + b + " = ");
                    Console.Write(kali(a, b));

                } else if(pil == 4){
                    Console.Write("Hasil pembagian " + a + " / " + b + " = ");
                    Console.Write(bagi(a, b));
                } else{
                    Console.Write("pilihan yang anda masukkan tidak ditemukan");
                }

                Console.Write("\n\nUlangi lagi ??? (y/n) = ");
                String ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y"){
                    Ulangi = true;
                    Console.Clear();
                } else {
                    break;
                }
            }
        }

        static int tambah(int a, int b){
            return a + b;
        }

        static int kurang(int a, int b){
            return a - b;
        }

        static int bagi(int a, int b){
            return a / b;
        }

        static int kali(int a, int b){
            return a * b;
        }
    }
}