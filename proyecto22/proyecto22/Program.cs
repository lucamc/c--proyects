using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingresa el primer Numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa eñ segundo Numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el Tercer Numero ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.Write("Todos los Numeros son Menores a 10");
            }
            Console.ReadKey();
        }  
    }
}
