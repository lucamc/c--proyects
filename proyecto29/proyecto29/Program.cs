using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            Console.Write("Ingrese un valor positivo: ");
            n = int.Parse(Console.ReadLine());

            x = 1;


            while (x <= n)
            {
                Console.WriteLine(x);

                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
