using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto32
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, mayoresNotas, menoresNotas, notas;
            x = 1;
            mayoresNotas = 0;
            menoresNotas = 0;

            while(x <= 10)
            {
                Console.Write("Ingrese una Nota: ");
                notas = int.Parse(Console.ReadLine());

                if(notas >= 7)
                {
                    mayoresNotas = mayoresNotas + 1;
                }
                else
                {
                    menoresNotas = menoresNotas + 1;
                }

                x = x + 1;
            };
            Console.WriteLine("El total de Notas Mayores a 7 son de: " + mayoresNotas);
            Console.Write("El total de Notas Menores a 7 son de: " + menoresNotas);
            Console.ReadKey();

        }
    }
}
