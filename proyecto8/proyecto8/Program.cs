using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto8
{
    internal class Program
    { /*Se debe desarrollar un programa que pida el 
       * ingreso del precio de un artículo y la 
       * cantidad que lleva el cliente. Mostrar lo que 
       * debe abonar el comprador.*/
        static void Main(string[] args)
        {
            int cantidadArticulo;
            float precioArticulo, totalPagar;
            string linea;

            Console.Write("Ingrese precio del Articulo ");
            linea = Console.ReadLine();
            precioArticulo = float.Parse(linea);

            Console.Write("Ingrese cantidad a llevar del articulo ");
            linea = Console.ReadLine();
            cantidadArticulo = int.Parse(linea);

            totalPagar = precioArticulo * cantidadArticulo;

            Console.Write("El total a pagar es de ");
            Console.Write(totalPagar);
            Console.ReadKey();
        }
    }
}
