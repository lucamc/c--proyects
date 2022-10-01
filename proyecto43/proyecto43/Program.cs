using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto43
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantValores, valor, count;
            count = 0;

            Console.Write("Ingrese cantidad de valroes a comparar: ");
            cantValores = int.Parse(Console.ReadLine());

            for(int i = 0; i < cantValores; i++)
            {
                Console.Write("Inngrese valor: ");
                valor = int.Parse(Console.ReadLine());

                if(valor >= 1000)
                {
                    count++;
                }
            }

            Console.Write("Cantidad de valores mayores o iguales a 1000: " + count);
            Console.ReadKey();
        }
    }
}
