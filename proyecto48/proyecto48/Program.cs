using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto48
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantTiangulos, countIsoceles, countEscaleno, countEquilatero;
            float lado1, lado2, lado3;
            countEquilatero = 0;
            countEscaleno = 0;
            countIsoceles = 0;

            Console.Write("Ingrese cantidad de traigulos a evaluar: ");
            cantTiangulos = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= cantTiangulos; i++)
            {
                Console.Write("Ingrese el lado 1: ");
                lado1 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado 2: ");
                lado2 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado 3: ");
                lado3 = float.Parse(Console.ReadLine());

                Console.WriteLine("------------");


                if (lado1 == lado2 && lado1 == lado3)
                {
                    countEquilatero++;
                }
                else
                {
                    if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        countIsoceles++;
                    }
                    else
                    {
                        countEscaleno++;
                    }
                }
            }
            Console.WriteLine("Cantidad de Equilateros: " + countEquilatero);
            Console.WriteLine("Cantidad de Isoceles: " + countIsoceles);
            Console.WriteLine("Cantidad de Escalenos: " + countEscaleno);

            if(countEquilatero < countIsoceles && countEquilatero < countEscaleno)
            {
                Console.WriteLine("El triagulo que posee menor cantidad es el Equilatero");
            }
            else
            {
                if(countIsoceles < countEscaleno)
                {
                    Console.WriteLine("El triagulo que posee menor cantidad es el Isoceles");

                }
                else
                {
                    Console.WriteLine("El triagulo que posee menor cantidad es el Escaleno");

                }
            }
            Console.ReadKey();
        }
    }
}
