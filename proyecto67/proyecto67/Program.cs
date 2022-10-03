using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto67
{
    class SueldoOperarios
    {
        private int[] sueldos;




        public void Cargar()
        {
            sueldos = new int[5];
            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese sueldo: ");
                sueldos[i] = int.Parse(Console.ReadLine());
            }

        }


        public void Imprimir()
        {
            Console.WriteLine("Listado de Sueldos");

            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
        }


        static void Main(string[] args)
        {
            SueldoOperarios sueldos1 = new SueldoOperarios();

            sueldos1.Cargar();
            sueldos1.Imprimir();
            Console.ReadKey();
        }
    }
}
