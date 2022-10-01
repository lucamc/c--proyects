using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.Write("Ingrese un lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es de ");
            Console.Write(perimetro);
            Console.ReadKey();
        }
    }
}
