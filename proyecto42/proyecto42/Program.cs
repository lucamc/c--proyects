using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto42
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMult5, countMulti3, numero;
            countMult5 = 0;
            countMulti3 = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese Numero: ");
                numero = int.Parse(Console.ReadLine());

                if(numero % 5 == 0)
                {
                    countMult5++;
                }
                if(numero % 3 == 0)
                {
                    countMulti3++;
                }
            }
            Console.WriteLine("Cantidad multiplos de 5: " + countMult5);
            Console.Write("Cantidad multiplos de 3: " + countMulti3);
            Console.ReadKey();

        }
    }
}
