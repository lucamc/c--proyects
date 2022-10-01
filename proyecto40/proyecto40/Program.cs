using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto40
{
    class Program
    {
        static void Main(string[] args)
        {
          
            float suma, valor, promedio;
            suma = 0;


            for(int i = 1; i <= 10; i++ )
            {
                Console.Write("Ingrese valor: ");
                valor = int.Parse(Console.ReadLine());

                suma = suma + valor;
            }

            promedio = suma / 10;

            Console.WriteLine("La suma de todos los valores es de: " + suma);
            Console.WriteLine("El Promedio de los valores es de: " + promedio);
            Console.ReadKey();

        }
    }
}
