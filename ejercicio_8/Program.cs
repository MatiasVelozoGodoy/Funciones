using System;
using System.Security.Cryptography.X509Certificates;

namespace ejercicio_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                x = 0;
                while (x <= 10)
                {
                    x--;
                    Console.WriteLine(".");
                }
            }
        }
    }
}

