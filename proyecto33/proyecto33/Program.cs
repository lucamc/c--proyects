using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto33
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            float sumaAlturas = 0f;

            Console.Write("Ingrese Cantidad aluras que va promediar: ");
            n = int.Parse(Console.ReadLine());

            x = 1;

            while(x <= n)
            {
                float alturas;
                Console.Write("Ingrese altura: ");
                alturas = float.Parse(Console.ReadLine());

                sumaAlturas += alturas;

                x++;

            }

            float promedioAltura;
            promedioAltura = sumaAlturas / n;

            Console.Write("El promedio de alturas es de: " + promedioAltura);
            Console.ReadKey();
        }
    }
}
