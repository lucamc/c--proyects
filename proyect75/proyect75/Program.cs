using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect75
{
    /* Desarrollar un programa que permita ingresar un vector de n elementos, 
     * ingresar n por teclado. Luego imprimir la suma de todos sus elementos*/
    class SumaValores
    {
        private float[] vectorValores;
        private int cantidadValores;


        public void CargaValores()
        {
            Console.Write("Ingrese cantidad de valores que desea sumar: ");
            cantidadValores = int.Parse(Console.ReadLine());
            vectorValores = new float[cantidadValores];

            for(int i = 0; i < vectorValores.Length; i++)
            {
                Console.Write("Ingrese valor: ");
                vectorValores[i] = float.Parse(Console.ReadLine());
            }

        }

        public void SumarListaValores()
        {
            float acc = 0;
            for(int i = 0; i < vectorValores.Length; i++)
            {
                acc += vectorValores[i];
            }

            Console.Write("La Suma de los valores es de: " + acc);
        }





        static void Main(string[] args)
        {
            SumaValores sumaValores1 = new SumaValores();
            sumaValores1.CargaValores();
            sumaValores1.SumarListaValores();
            Console.ReadKey();
        }
    }
}
