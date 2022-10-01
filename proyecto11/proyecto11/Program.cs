using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11
{
    internal class Program
    {
        /* Realizar un programa que lea por teclado dos números, 
         * si el primero es mayor al segundo informar su suma y diferencia, 
         * en caso contrario informar el producto y 
         * la división del primero respecto al segundo.*/
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine(); 
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2=int.Parse(linea);

            if (num1 > num2)
            {
                int suma, diferencia;
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.Write("El resultado de la suma es de: ");
                Console.WriteLine(suma);
                Console.Write("La diferencia es de: ");
                Console.Write(diferencia);
            }
            else
            {
                int producto, division;
                producto = num1 * num2;
                division = num1 / num2;
                Console.Write("El producto de los numeros es de: ");
                Console.WriteLine(producto);
                Console.Write("La division entre ambos numeros es de: ");
                Console.Write(division);
            }
            Console.ReadKey();

        }
    }
}
