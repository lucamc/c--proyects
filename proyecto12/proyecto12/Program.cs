using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto12
{
    internal class Program
    {
        /*- Se ingresan tres notas de un alumno, si el 
         * promedio es mayor o igual a siete mostrar un mensaje "Promocionado"*/
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;
            string linea;

            Console.Write("Ingrese la primera Nota ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);

            Console.Write("Ingresa la segunda Nota ");
            linea= Console.ReadLine();
            nota2= int.Parse(linea);

            Console.Write("Ingresa la tercera Nota ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            promedio = (nota1 + nota2 + nota3) / 3;

            if(promedio >= 7)
            {
                Console.Write("Promocionado");
            }
            Console.ReadKey();
            


        }
    }
}
