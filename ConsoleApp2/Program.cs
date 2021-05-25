using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, t;
            Console.WriteLine("************* FARUK SECURİTY *************");
            Console.Write("1. Sayıyı Giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("************* FARUK SECURİTY *************");
            t = s1 * s2;
            Console.WriteLine(s1 + " * " + s2 + " = " + t);
            Console.WriteLine("************* FARUK SECURİTY *************");
            Console.ReadKey();


        }
    }
}
