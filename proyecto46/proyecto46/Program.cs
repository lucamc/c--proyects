using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto46
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            numero = 5;
        
            for(int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
            Console.ReadKey();
        }
    }
}
