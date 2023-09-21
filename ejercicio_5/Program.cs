using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, resultado;
            int n2;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dime cuanto salio");
                n1 = float.Parse(Console.ReadLine());                
                Console.WriteLine("Dime en cuantas cuotas compraste");
                n2 = int.Parse(Console.ReadLine());
                resultado = pagos(n1, n2);
                Console.WriteLine("El resultado es de: " + resultado.ToString(".00") + "$");
            }
        }
        static float pagos(float a, int b)
        {
            return a/b;
        }
    }
}

// Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
// de pagos (entero) y devuelva el monto de cada pago. Hacer un programa para
// ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
// El programa deberá mostrar la cantidad de pagos y el monto del pago para
// cada una de las ventas.