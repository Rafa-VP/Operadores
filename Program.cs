using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int x, y = 5;
            x = ++y; // Primero incrementa y luego asigna
            Console.WriteLine("x={0}    y={1}", x, y);

            y = 10;
            x = --y; // Primero decrementa y luego asigna
            Console.WriteLine("x={0}    y={1}", x, y);

            y = 5;
            x = y++; // Primero asigna y luego incrementa
            Console.WriteLine("x={0}    y={1}", x, y);

            y = 8;
            x = y--; // Primero asigna y luego decrementa
            Console.WriteLine("x={0}    y={1}", x, y);

            bool var1;
            if (x == y)
                var1 = true;
            else
                var1 = false;
            Console.WriteLine("El valor de var1 es: {0}", var1);
            var1 = x == y;
            Console.WriteLine("El valor de var1 es: {0}", var1);

            // Ejemplo de operador ternario
            int edad = 20;
            string resultado = (edad < 18) ? "Eres menor de edad" : "Eres mayor de edad";
            Console.WriteLine("Resultado: {0}", resultado);

             Es el mismo resultado
            if (edad < 18)
                resultado = "Eres menor de edad";
            else 
                resultado = "Eres mayor de edad";
            

            // Ejemplo de bucle foreach
            String[] nombres = { "Juan", "Andrea", "María", "Carlos", "José", "Ana", "Andrés" };
            foreach (string cad in nombres)
            {
                Console.WriteLine("Nombre de la persona {0}", cad);
              //  Console.WriteLine($"Nombre de la persona {cad}");
            }

            // Ejemplo de foreach con array de números
            int[] numeros = { 10, 8, 3, 5, 6, 7 };
            foreach(int j in numeros){
                Console.WriteLine($"{j}");
            }


            // Ejemplo bucle do while: Imprimir 10 números aleatorios
            Random rnd = new Random();
            int cont = 1;
            do
            {
                int aleatorio = rnd.Next(50);
                Console.WriteLine($"{cont}: número generado");
                cont++;
            } while (cont<=10);

            */
            // Usando el bucle while: Pida al usuario que ingrese un entero por teclado
            // El entero se debe imprimir multiplicado por 10
            // El bucle termina cuando se ingrese -1

            int num = 0;

            while(num != -1)
            {
                Console.WriteLine("Ingrese un entero [-1 para terminar]: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número multiplicado por 10 es: {num * 10}");
            if (num != -1)
                    Console.WriteLine($"Número multiplicado por 10 {num * 10}");
            }

            Console.WriteLine("Fin...");


            Console.ReadKey();
        }
    }
}
