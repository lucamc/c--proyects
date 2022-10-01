using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10
{
    internal class Program
    {
     /*Realizar un programa que solicite ingresar dos números distintos y 
     muestre por pantalla el mayor de ello*/
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;

            Console.Write("Ingresa el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresa el segundo numero: ");
            linea=Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                Console.Write("El mayor es el ");
                Console.Write(num1);
            
            } 
            else
            {
                Console.Write("El mayor es el ");
                Console.Write(num2);
            }
            Console.ReadKey();
        }
    }
}
