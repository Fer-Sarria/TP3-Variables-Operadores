// 1. Operador de incremento de postfijo. ¿Qué sucede con i++?
// int i = 3;
// Console.WriteLine(i);
// Console.WriteLine(i++);
// Console.WriteLine(i);

using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
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
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            //Ejercicio13();
            //Ejercicio14();
            //Ejercicio15();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
            //Ejercicio20();
            //Ejercicio21();
            //Ejercicio22();
            //Ejercicio23();
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

        // 8. Operador de división de puntos flotantes. ¿Cuál es el resultado obtenido en cada caso?
        static void Ejercicio8()
        {
            Console.WriteLine("\nDivisión de punto flotante");
            Console.WriteLine(16.8f / 4.1f);
            Console.WriteLine(16.8d / 4.1d);
            Console.WriteLine(16.8m / 4.1m);
        }

        // 9. Operador de resto entero. ¿Cuál es el resultado obtenido en cada caso?
        static void Ejercicio9()
        {
            Console.WriteLine("\nResto entero");
            Console.WriteLine(5 % 4);
            Console.WriteLine(5 % -4);
            Console.WriteLine(-5 % 4);
            Console.WriteLine(-5 % -4);
        }

        // 10. Operador de Suma
        static void Ejercicio10()
        {
            Console.WriteLine("\nSuma");
            Console.WriteLine(5 + 4);
            Console.WriteLine(5 + 4.3);
            Console.WriteLine(5.1m + 4.2m);
        }

        // 11. Operador de Resta
        static void Ejercicio11()
        {
            Console.WriteLine("\nResta");
            Console.WriteLine(47 - 3);
            Console.WriteLine(5 - 4.3);
            Console.WriteLine(7.5m - 2.3m);
        }

        // 12. Operador de resto con punto flotante. ¿Cuál es el resultado obtenido en cada caso?
        static void Ejercicio12()
        {
            Console.WriteLine("\nResto punto flotante");
            Console.WriteLine(-5.2f % 2.0f);
            Console.WriteLine(5.9 % 3.1);
            Console.WriteLine(5.9m % 3.1m);
        }

        // 13. Operadores de asignación compuesta. ¿Qué hace cada operador de asignación compuesta?
        static void Ejercicio13()
        {
            Console.WriteLine("\nAsignación compuesta");
            int a = 5;
            a += 9;
            Console.WriteLine(a);
            a -= 4;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 4;
            Console.WriteLine(a);
            a %= 3;
            Console.WriteLine(a);
        }

        // 14. Operador menor que. ¿Cuáles son los valores de las siguientes operaciones?
        static void Ejercicio14()
        {
            Console.WriteLine("\nMenor que");
            Console.WriteLine(7.0 < 5.1);
            Console.WriteLine(5.1 < 5.1);
            Console.WriteLine(0.0 < 5.1);
        }

        // 15. Operador mayor que. ¿Cuáles son los valores de las siguientes operaciones?
        static void Ejercicio15()
        {
            Console.WriteLine("\nMayor que");
            Console.WriteLine(7.0 > 5.1);
            Console.WriteLine(5.1 > 5.1);
            Console.WriteLine(0.0 > 5.1);
        }

        // 16. Operador menor o igual que. ¿Cuáles son los valores de las siguientes operaciones?
        static void Ejercicio16()
        {
            Console.WriteLine("\nMenor o igual que");
            Console.WriteLine(7.0 <= 5.1);
            Console.WriteLine(5.1 <= 5.1);
            Console.WriteLine(0.0 <= 5.1);
        }

        // 17. Operador mayor o igual que. ¿Cuáles son los valores de las siguientes operaciones?
        static void Ejercicio17()
        {
            Console.WriteLine("\nMayor o igual que");
            Console.WriteLine(7.0 >= 5.1);
            Console.WriteLine(5.1 >= 5.1);
            Console.WriteLine(0.0 >= 5.1);
        }

        // 18. Operador de igualdad. ¿Cuáles son los resultados de estas operaciones?
        static void Ejercicio18()
        {
            Console.WriteLine("\nIgualdad");
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b);
            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == char.ToLower(c2));
        }

        // 19. Operador de desigualdad. ¿Cuáles son los resultados de estas operaciones?
        static void Ejercicio19()
        {
            Console.WriteLine("\nDesigualdad");
            int a = 1 + 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a != b);
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);
            object o1 = 1;
            object o2 = 1;
            Console.WriteLine(o1 != o2);
        }

        // 20. Operador de negación lógica. ¿Cuáles son los resultados de las siguientes operaciones?
        static void Ejercicio20()
        {
            Console.WriteLine("\nNegación lógica");
            bool passed = false;
            Console.WriteLine(!passed);
            Console.WriteLine(!true);
        }

        // 21. Operador de producto lógico. ¿Cuáles son los resultados de las siguientes operaciones?
        static void Ejercicio21()
        {
            Console.WriteLine("\nProducto lógico (AND)");
            bool a = false && SecondOperand();
            Console.WriteLine(a);
            bool b = true && SecondOperand();
            Console.WriteLine(b);
        }

        static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        // 22. Operador de suma lógica. ¿Cuáles son los resultados de las siguientes operaciones?
        static void Ejercicio22()
        {
            Console.WriteLine("\nOperador de suma lógica (OR)");

            bool a = true || SecondOperand();
            Console.WriteLine(a);

            bool b = false || SecondOperand();
            Console.WriteLine(b);
        }

        // 23. Para cada uno de los ejercicios idee un algoritmo en C# que implemente el uso del
        //operador estudiado.Este algoritmo debe ser una implementación sencilla y solo
        //contener lógica basada en lo que hemos aprendido.
        static void Ejercicio23()
        {
            Console.WriteLine("\nAlgoritmo Interactivo de Operadores");

            // 1. Entrada de datos: Le pedimos dos números al usuario
            Console.Write("Ingrese el primer número entero (A): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero (B): ");
            int b = int.Parse(Console.ReadLine());

            // 2. Aplicamos Operadores Matemáticos
            Console.WriteLine("\n--- Operaciones Matemáticas ---");
            Console.WriteLine($"Suma (A + B): {a + b}");
            Console.WriteLine($"Resta (A - B): {a - b}");
            Console.WriteLine($"Multiplicación (A * B): {a * b}");

            // Validamos que no divida por cero para evitar que se rompa
            if (b != 0)
            {
                Console.WriteLine($"División Entera (A / B): {a / b}");
                Console.WriteLine($"Operador de Resto (A % B): {a % b}");
            }

            // 3. Aplicamos Operadores Relacionales (Devuelven True o False)
            Console.WriteLine("\n--- Operaciones Relacionales ---");
            Console.WriteLine($"¿A es Mayor que B? (A > B): {a > b}");
            Console.WriteLine($"¿A es Exactamente Igual a B? (A == B): {a == b}");

            // 4. Aplicamos Operadores Lógicos (&&)
            Console.WriteLine("\n--- Validación Lógica ---");
            Console.Write("¿Tenés más de 18 años? (true/false): ");
            bool esMayor = bool.Parse(Console.ReadLine());

            // Combinamos una condición relacional y una lógica
            bool puedeIngresar = (a > b) && esMayor;
            Console.WriteLine($"¿Puede ingresar? (¿A > B? Y además ¿Es Mayor?): {puedeIngresar}");
        }

    }
}