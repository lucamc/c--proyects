using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto59
{
    class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
        }

        public  void Imprimir()
        {
            Console.WriteLine("Datos cargados");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }

        public void EsMayorDeEdad()
        {
            if(edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("Es menor de edad");
            }
        }

        static void Main(string[] args)
        {

            Persona persona1 = new Persona();
            persona1.Inicializar();
            persona1.Imprimir();
            persona1.EsMayorDeEdad();
            Console.ReadKey();
            

        }
    }
}
