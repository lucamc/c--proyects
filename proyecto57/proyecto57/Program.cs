using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto57
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;
            int edad1, edad2;

            Console.Write("Ingrese nombre primera persona: ");
            nombre1 = Console.ReadLine();
            Console.Write("Ingrese la edad de " + nombre1 + " : ");
            edad1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre de la segunda persona: ");
            nombre2 = Console.ReadLine();
            Console.Write("Ingrese edad de " + nombre2 + " : ");
            edad2 = int.Parse(Console.ReadLine());

            if(edad1 > edad2)
            {
                Console.Write(nombre1 + " es la persona con mayor edad");
            }
            else
            {
                Console.Write(nombre2 + " es la persona con mayor edad");
            }
            Console.ReadKey();

        }
    }
}
