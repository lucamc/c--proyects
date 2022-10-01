using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto44
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant, count;
            float alturaTriangulo, baseTriangulo , superficie;

            count = 0;

            Console.Write("Ingrese la cantidad superfices de triangulos a calcular: ");
            cant = int.Parse(Console.ReadLine());

            for(int i = 1; i <= cant; i++)
            {
                Console.Write("Ingrese la altura: ");
                alturaTriangulo = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la base: ");
                baseTriangulo = float.Parse(Console.ReadLine());

                superficie = (alturaTriangulo * baseTriangulo) / 2;

                Console.WriteLine("-------------");
                Console.WriteLine("El triangulo " + i);
                Console.WriteLine("Altura: " + alturaTriangulo);
                Console.WriteLine("Base: " + baseTriangulo);
                Console.WriteLine("Superficie: " + superficie);
                Console.WriteLine("-------------");

                if(superficie > 12)
                {
                    count++;
                }
            }
            Console.Write("Cantidad de Triagulos con una superfice mayor a 12: " + count);
            Console.ReadKey();

        }
    }
}
