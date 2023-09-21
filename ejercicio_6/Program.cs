using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, suma;
            Console.WriteLine("Dame un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            suma = sumaResta(n1, ref n2);
            Console.WriteLine(suma + " " + n2);
            
        }
        
        static int sumaResta(int a, ref int b)
        {
            int sum;
            sum = a+b;
            b = a - b;
            return sum;
        }
    }
}

// Hacer una función que se llame “sumaResta” que reciba dos números y que
// devuelva la suma Y la resta del primer número con el segundo.
// Nota: recordemos que una función solo puede devolver UN valor por return.
// Cómo podríamos hacer para tener ambos resultados en el main?