using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto73
{

    /*Cargar un vector de 10 elementos y verificar 
     * posteriormente si el mismo está ordenado de menor a mayor.*/
    class Vector
    {
        private int[] vector;

        /*Cargo elementos en el vector*/
        public void CargarElementos()
        {
            vector = new int[10];
            Console.WriteLine("Ingrese 10 valores");
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }


        /*Verificar el orden del vector*/
        public void VerificarOrden()
        {
            /*Reccorro el vector, en caso que este ordenano completamente*/
            /*a int orden le asigno 1, si no esta ordenado va valer 0*/
            
            int orden = 1;
            for(int i = 0; i < vector.Length -1; i++)
            {
                if(vector[i+1] < vector[i])
                {
                    orden = 0;
                }
               
            }
            
            
            if(orden == 1)
            {
                 Console.WriteLine("El vector esta ordenado de Menor a Mayor");
            }
            else
            {
                 Console.WriteLine("No esta ordenado de menor a mayor");
            }
     
        }



        static void Main(string[] args)
        {
            Vector vector1 = new Vector();
            vector1.CargarElementos();
            vector1.VerificarOrden();
            Console.ReadKey();

        }
    }
}
