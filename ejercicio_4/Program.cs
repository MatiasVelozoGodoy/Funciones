using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, con = 0, promedio, acu = 0;
            Console.WriteLine("dame un numero");
            n1 = int.Parse(Console.ReadLine());
            while (n1 != 0)
            {
                if(primo(n1)){
                    Console.WriteLine("Es primo");
                    con++;
                    acu+= n1;
                }
                Console.WriteLine("dame un numero");
                n1 = int.Parse(Console.ReadLine());
                
            }
            promedio = acu/con;
            Console.WriteLine("El promedio de primos es de " + promedio);
            
        }
        static bool primo(int a)
        {
            int pri = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    pri++;
            }
                if (pri == 2)
                    return true;
                else
                    return false;
            
        }
    }
}

// Hacer una función llamada “primo” que reciba un número entero y devuelva 1
// si el número es primo o cero si no lo es. Hacer un programa para ingresar
// números. El lote corta cuando se ingresa un número cero. Informar el
// promedio teniendo en cuenta sólo los números primos.