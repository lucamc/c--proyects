using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto41
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNotasMayores, countNotasMenores;
            countNotasMayores = 0;
            countNotasMenores = 0;
            float nota;

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Ingrese Nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    countNotasMayores++;
                }
                else
                {
                    countNotasMenores++;
                }
            }

            Console.WriteLine("Cantidad notas mayores o iguales a 7: " + countNotasMayores);
            Console.WriteLine("Cantidad notas menores a 7: " + countNotasMenores);
            Console.ReadKey();

            }


    }
}
