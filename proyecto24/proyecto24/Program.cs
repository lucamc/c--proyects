using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingresa el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2= int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno de los numeros es menor a diez");
            }
            Console.ReadKey();
        }
    }
}
