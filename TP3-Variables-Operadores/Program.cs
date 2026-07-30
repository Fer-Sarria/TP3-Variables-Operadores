// 1. Operador de incremento de postfijo. ¿Qué sucede con i++?
// int i = 3;
// Console.WriteLine(i);
// Console.WriteLine(i++);
// Console.WriteLine(i);

using System;
namespace TP3_Variables_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("\nOperador de incremento de postfijo (i++)");

            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);
        }
    }
}