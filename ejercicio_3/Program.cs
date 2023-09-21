using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, acu = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame un numero!");
                n1 = int.Parse(Console.ReadLine());
                if (par(n1))
                    acu++;
            }
            Console.WriteLine(acu + " son pares");
            }

            static bool par(int a)
            {
                if(a % 2 == 0)
                    return true;
                else 
                    return false;
        }
    }
}

// Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
// es par o cero si no lo es. Hacer un programa para ingresar 20 números y
// mostrar por pantalla cuántos son pares.