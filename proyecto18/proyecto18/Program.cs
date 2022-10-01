using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPreguntas, cantPreguntasCorrectas;
            
            Console.Write("Ingrese el total de preguntas");
            totalPreguntas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el total de preguntas contestadas correctamente");
            cantPreguntasCorrectas = int.Parse(Console.ReadLine()); 

            int porcentaje = (cantPreguntasCorrectas * 100) / totalPreguntas;

            if (porcentaje >= 90)
            {
                Console.Write("Nivel Máximo");
            }
            else
            {
                if(porcentaje >= 75)
                {
                    Console.Write("Nivel Medio");
                }
                else
                {
                    if(porcentaje >= 50)
                    {
                        Console.Write("Nivel regular");
                    }
                    else
                    {
                        Console.Write("Fuera de Nivel");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
