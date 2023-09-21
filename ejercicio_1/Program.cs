using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Precio del producto");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos compraste?");
            n2 = int.Parse(Console.ReadLine());
            resultado = producto(n1, n2);
            Console.WriteLine("El resutado es: " + resultado);
        }



        static int producto(int n1, int n2)
        {
            return n1*n2;
        }
    }
}

// Hacer una función llamada “producto” que reciba dos números enteros y que
// devuelva el producto de ambos. Luego hacer un programa que pida el precio
// de un artículo y la cantidad vendida y muestre por pantalla el monto total a
// pagar. Usar la función.