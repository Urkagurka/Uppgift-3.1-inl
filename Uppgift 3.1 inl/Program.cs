using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal");
            }
            else if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får vara med");
            }
            else if (ålder < 16)
            {
                Console.WriteLine("Du är för ung");
            }
        Console.ReadKey();
        }
    }
}