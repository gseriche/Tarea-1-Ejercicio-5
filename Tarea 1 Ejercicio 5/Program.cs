using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5) Diseñar un algoritmo y construir un programa que pida por teclado tres números;
            //    si el primero es negativo, debe imprimir el producto de los tres y si no lo es, imprimirá la suma.

            int num1, num2, num3;

            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0)
            {
                Console.WriteLine("El producto de los tres es: " + (num1 * num2 * num3));
            }
            else
            {
                Console.WriteLine("La suma de los tres es: " + (num1 + num2 + num3));
            }

            Console.WriteLine("Presione cualquier tecla para salir... :) ");
            Console.ReadKey();
        }
    }
}
