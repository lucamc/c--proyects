using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9
{
    internal class Program
    {       /*Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar 
             * un mensaje en pantalla indicando que debe abonar impuestos.*/
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            Console.Write("Ingrese su sueldo ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);

            if(sueldo > 3000)
            {
                Console.Write("Esta persona debera abonar impuestos");
            }
            Console.ReadKey();


        }
    }
}
