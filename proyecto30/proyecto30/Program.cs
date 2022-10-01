using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto30
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, suma, valor, promedio;

            x = 1;
            suma = 0;

            while(x <= 10)
            {
                Console.Write("Ingrese un valor: ");
                valor = int.Parse(Console.ReadLine());

                suma = suma + valor;

                x = x + 1;
            }

            promedio = suma / 10;
            Console.WriteLine("La suma de los numeros es de: " + suma);
            Console.Write("El promedio de los numeros es de: " + promedio);
            Console.ReadKey();

        }
    }
}
