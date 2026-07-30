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
            //Ejercicio1();
            Ejercicio2();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("\nOperador de incremento de postfijo (i++)");

            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);
        }

        // 2. Operador de incremento de prefijo. ¿Qué sucede con ++a?
        static void Ejercicio2()
        {
            Console.WriteLine("\nOperador de incremento de prefijo (++a)");

            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
        }


        // 3. Operador de decremento de postfijo. ¿Qué sucede con i--?

        static void Ejercicio3()
        {
            Console.WriteLine("\nOperador de decremento de postfijo. ¿Qué sucede con i--?");

            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i--);
            Console.WriteLine(i);
        }

        // 4. Operador de decremento de prefijo.
        static void Ejercicio4()
        {
            Console.WriteLine("\nOperador de decremento de prefijo (--a)");
            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(--a);
            Console.WriteLine(a);
        }
    }
}