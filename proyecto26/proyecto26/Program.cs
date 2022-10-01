using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto26
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo, antiguedad;

            Console.Write("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());

            Console.Write("Ingres años de Antiguedad: ");
            antiguedad = int.Parse(Console.ReadLine());

            if(sueldo < 500 && antiguedad >= 10)
            {
                sueldo = sueldo + ((sueldo * 20) / 100);
                Console.Write("Sueldo a Pagar es de $" + sueldo);
            }
            else
            {
                if(sueldo < 500 && antiguedad < 10)
                {
                    sueldo = sueldo + ((sueldo * 5) / 100);
                    Console.Write("Sueldo a Pagar es de $" + sueldo);
                }
                else
                {
                    Console.Write("Sueldo a pagar es de $" + sueldo);
                }
            }
            Console.ReadKey();
        }
    }
}
