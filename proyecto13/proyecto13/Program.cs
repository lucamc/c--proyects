using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;
            Console.Write("Ingresa un numero de hasta 2 digitos ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if(numero < 100 && numero > 9)
            {
                Console.Write("El numero es de 2 digitos ");
            }
            else if (numero < 10)
            {
                Console.Write("El numero es de 1 digito ");
            }
            else
            {
                Console.Write("El numero es mayor de 2 digitos ");
            }
            Console.ReadKey();
        }
    }
}
