using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.Write("Ingresa un numero ");
            linea = Console.ReadLine();
            numero= int.Parse(linea);   

            if(numero == 0)
            {
                Console.Write("El numero es Nulo");

            }
            else
            {
                if(numero > 0)
                {
                    Console.Write("El numero es un entero");
                }
                else
                {
                    Console.Write("El numero es Negativo");
                }
            }
            Console.ReadKey();
        }
    }
}
