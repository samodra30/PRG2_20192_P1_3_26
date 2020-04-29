using System;

namespace PRG2_20192_P1_3_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM ANAK AYAM");
            Console.WriteLine("-----------------");
            Console.Write("Masukkan nilai N : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ANAK AYAM TURUN {0}\n", n);

            for(int i = n; i >= 1; i--)
            {
                Console.Write("Anak ayam turun {0}", i);
                if((i - 1) == 0)
                {
                    Console.WriteLine(", mati satu tinggal induknya");
                } else
                {
                    Console.WriteLine(", mati satu tinggal {0}", (i - 1));
                }
            }
        }
    }
}
