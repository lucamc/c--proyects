using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto34
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, cobranMas, cobranMenos;
            float sueldosSuma;
            x = 1;
            cobranMas = 0;
            cobranMenos = 0;
            sueldosSuma = 0f;

            Console.Write("Ingrese cantidad de empleados: ");
            n = int.Parse(Console.ReadLine());

            while(x <= n)
            {
                
                Console.Write("Ingrese sueldo: ");
                float sueldos = float.Parse(Console.ReadLine());

                if (sueldos <= 300)
                {
                    cobranMenos += 1;
                }
                else
                {
                    cobranMas += 1;
                }
               
                sueldosSuma += sueldos;
               
                x++;
            }

            Console.WriteLine("Hay " + cobranMas + " empleados que cobran mas de $300");
            Console.WriteLine("Hay " + cobranMenos + " empleados que cobran entre $100 y $300");
            Console.Write("La empresa paga un total de $" + sueldosSuma);
            Console.ReadKey();    

        }
    }
}
