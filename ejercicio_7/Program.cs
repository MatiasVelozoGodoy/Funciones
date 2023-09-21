using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;


namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0, p = 0, n = 0, cero = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("dame un numero");
                n1 = int.Parse(Console.ReadLine());
                positivoNegativoCero(n1, ref n2);
                // if(n2 == 0)
                //     cero++;
                // else if(n2 > 0)
                //     p++;
                // else
                //     n++;
                switch (n2)
                {
                case 1:
                    p++;
                    break;
                case -1:
                    n++;
                    break;
                case 0:
                    cero++;
                    break;
                    
                }
            }
                Console.WriteLine("La cantidad de positivos fueron: " + p);
                Console.WriteLine("La cantidad de negativos fueron: " + n);
                Console.WriteLine("La cantidad de ceros fueron: " + cero);
            
        }
        static void positivoNegativoCero(int a, ref int b)
        {
            if (a == 0)
                b = 0;
            else if (a > 0)
                b = 1;
            else
                b = -1;
        }
    }
}

// Hacer una función de tipo void (porque no va a devolver nada) llamada
// “positivoNegativoCero” que reciba un número por valor y una variable por
// referencia. Que analice el número y escriba variable recibida por referencia
// con:
// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.
// Hacer un programa main que permita ingresar 100 números y emitir por
// pantalla cuántos son positivos, cuántos negativos y cuántos cero.
