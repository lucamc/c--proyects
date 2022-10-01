using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;

            Console.Write("Ingresa un numero de hasta 3 cifras");
            linea = Console.ReadLine();
            num=int.Parse(linea);

            if(num < 10)
            {
                Console.Write("Tiene un digito");
            }
            else
            {
                if(num < 100)
                {
                    Console.Write("Tiene dos digitos");
                }

                else
                {
                    if(num < 1000)
                    {
                        Console.Write("Tiene tres digitos");
                    }
                    else
                    {
                        Console.Write("El numero es mayor de 3 digitos");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
