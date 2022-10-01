using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto47
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.Write("Ingrese un número para saber su tabla: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero >= 1 && numero <= 10)
            {
                for( int i = 1; i <= 13; i++ )
                {
                    resultado = numero * i;

                    Console.WriteLine(numero + " x " + i + " = " + resultado);
                }
            }
            else
            {
                Console.Write("Numeros habilitados del 1 al 10;");
            }
            Console.ReadKey();
        }
    }
}
