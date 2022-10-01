using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto45
{
    class Program
    {
        static void Main(string[] args)
        {
            int acc, numero;
            acc = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if( i > 5 )
                {
                    acc = acc + numero;
                }
            }

            Console.Write("La suma de los ultimos 5 números es de: " + acc);
            Console.ReadKey();
        }
    }
}
