using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Hallar la superficie de un 
 * cuadrado conociendo el valor de un lado.*/

namespace proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado;
            float superficie;
            string linea;

            Console.Write("Cuanto mide un lado del cuadrado ");
            linea = Console.ReadLine();
            lado = float.Parse(linea);
            superficie = lado * lado;
            Console.Write("El Cuadrado tiene una superfice de ");
            Console.Write(superficie);
            Console.ReadKey();
        }
    }
}
