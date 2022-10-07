using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect74
{
    class SueldosOperarios
    {
        private float[] sueldos;


        public void SolicitarSueldos()
        {
            int cantSueldos;
            Console.Write("Cuantos sueldos va cargar: ");
            cantSueldos = int.Parse(Console.ReadLine());
            sueldos = new float[cantSueldos];
        }



        public void CargarSueldos()
        {
            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese sueldo: ");
                sueldos[i] = float.Parse(Console.ReadLine());

            }
        }



        public void Imprimir()
        {
            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Sueldos: " + sueldos[i]);
            }
        }


        static void Main(string[] args)
        {
            SueldosOperarios sueldos1 = new SueldosOperarios();
            sueldos1.SolicitarSueldos();
            sueldos1.CargarSueldos();
            sueldos1.Imprimir();
            Console.ReadKey();

            

        }
    }
}
