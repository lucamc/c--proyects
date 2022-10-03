using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto71
{
    class SumaVectores
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;


        public void Cargar()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            Console.WriteLine("Ingrese valores del primer vector");
            for(int i = 0; i < vector1.Length; i++)
            {
                Console.Write("Ingrese Valor: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese valores del segundo vector");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write("Ingrese Valor: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Sumar()
        {
            vector3 = new int[4];
        
            for (int i = 0; i < 4; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Suma de vectores");
            for (int i = 0; i < 4; i++)
            { 
                Console.WriteLine(vector3[i]);
            }
        }


        static void Main(string[] args)
        {

            SumaVectores vect1 = new SumaVectores();
            vect1.Cargar();
            vect1.Sumar();
            vect1.Imprimir();
            Console.ReadKey();

        }
    }
}
