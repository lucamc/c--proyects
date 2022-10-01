using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto31
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, cantidad, n;
            float largo;

            x = 1;
            cantidad = 0;

            Console.Write("Ingrese la cantidad de piezas a procesar: ");
            n = int.Parse(Console.ReadLine());

            while(x <= n)
            {
                Console.Write("Ingrese la longitud de cada pieza: ");
                largo = float.Parse(Console.ReadLine());

                if(largo >= 1.20 && largo <= 1.30)
                {
                    cantidad = cantidad + 1;
                }

                x = x + 1;
            }

            Console.Write("La cantidad de piezas aptas son: " + cantidad);
            Console.ReadKey();
        }

    }
}
