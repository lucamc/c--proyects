using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar la carga de dos números enteros por 
 * teclado e imprimir su suma y su producto.*/

namespace proyecto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            string linea;

            Console.Write("Ingresa un primer numero entero ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresa un segundo numero entero ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1 + num2;
            producto = num1 * num2;

            Console.Write("La suma de los dos numeros ingresados es: ");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos valores ingresados es: ");
            Console.Write(producto);
            Console.ReadKey();
              
        }
    }
}
