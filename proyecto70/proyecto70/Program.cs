using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto70
{
    class Acumulado
    {
        private int[] valores;


        public void Cargar()
        {
            valores = new int[8];
            Console.WriteLine("Ingrese 8 valores");

            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write("Ingrese valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
        }

        public void AcumularTotal()
        {
            int acc = 0;
            for(int i = 0; i < valores.Length; i++)
            {
                acc += valores[i];
            }

            Console.WriteLine("El total acumulado es de: " + acc);
        }


        public void AcumularSiEsMayor()
        {
            int acc = 0;
            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] > 36)
                {
                    acc += valores[i];
                }
            }
            Console.WriteLine("Valor acumulado de los elementos mayores a 36: " + acc);
        }

        public void ContarSiEsMayor()
        {
            int count = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if(valores[i] > 50)
                {
                    count++;
                }
            }

            Console.WriteLine("Cantidad de valores mayores a 50: " + count);
        }


        static void Main(string[] args)
        {
            Acumulado valores1 = new Acumulado();
            valores1.Cargar();
            valores1.AcumularTotal();
            valores1.AcumularSiEsMayor();
            valores1.ContarSiEsMayor();
            Console.ReadKey();
        }
    }
}
