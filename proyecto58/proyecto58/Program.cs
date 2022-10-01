using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto58
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido1, apellido2;

            Console.Write("Ingrese el primer apellido : ");
            apellido1 = Console.ReadLine().ToUpper();

            Console.Write("Ingrese el segundo apellido: ");
            apellido2 = Console.ReadLine().ToUpper();

            if(apellido1 == apellido2)
            {
                Console.Write("Los apellido son iguales");
            }
            else
            {
                Console.Write("Los apellidos son distintos");
            }
            Console.ReadKey();
        }
    }
}
