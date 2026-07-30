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
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            Ejercicio7();
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

        // 5. Operador unario + y -. ¿Qué hacen los operadores - y +?¿Cual es el tipo de dato de b?

        static void Ejercicio5()
        {
            Console.WriteLine("\nOperador unario + y -");
            int numero = 4;
            Console.WriteLine(+numero);
            Console.WriteLine(-numero);
            Console.WriteLine(-(-numero));
            uint a = 5;
            var b = -a;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
        }

        // 6. Operador de multiplicación
        static void Ejercicio6()
        {
            Console.WriteLine("\nMultiplicación");
            Console.WriteLine(5 * 2);
            Console.WriteLine(0.5 * 2.5);
            Console.WriteLine(0.1m * 23.4m);
        }

        // 7. Operador de división de enteros.¿Cuál es el resultado obtenido en cada caso?
        static void Ejercicio7()
        {
            Console.WriteLine("\nDivisión de enteros");
            Console.WriteLine(13 / 5);
            Console.WriteLine(-13 / 5);
            Console.WriteLine(13 / -5);
            Console.WriteLine(-13 / -5);
        }

    }
}