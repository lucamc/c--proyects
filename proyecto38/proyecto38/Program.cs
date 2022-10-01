using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto38
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, cantPar, cantImpar, n, numero;

            x = 1;
            cantPar = 0;
            cantImpar = 0;

            Console.Write("Ingresa la cantidad de números a comaparar: ");
            n = int.Parse(Console.ReadLine());
            
            while(x <= n) {

                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    cantPar += 1;
                }
                else
                {
                    cantImpar += 1;
                }

                x++;
            }

            Console.WriteLine("Cantidad de numeros Pares: " + cantPar);
            Console.WriteLine("Cantidad de numeros Impares: " + cantImpar);
            Console.ReadKey();

        }
    }
}
