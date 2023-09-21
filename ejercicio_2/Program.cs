using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            pedirNumeros(ref n1, ref n2);
            Console.WriteLine("El mayor es: " + mayor(n1,n2));
        }
        static int mayor(int a, int b)
        {
            if(a > b)
                return a;
            else if(b > a)
                return b;
            else
                return 0;
        }
        static void pedirNumeros(ref int a, ref int b)
        {
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
        }
    }
}

// Hacer una función llamada “mayor” que reciba dos números enteros y
// devuelva el mayor de ellos o cero si son iguales.