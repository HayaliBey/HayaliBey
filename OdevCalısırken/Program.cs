using System;

namespace OdevCalısırken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi <= 1000)
            {
                Console.WriteLine(sayi);
                System.Threading.Thread.Sleep(1000);
                sayi++;
            }
            Console.ReadKey();
        }
    }
}
