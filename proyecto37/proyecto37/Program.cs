using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto37
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            float valor, lista1, lista2;
            x = 1;
            lista1 = 0;
            lista2 = 0;

            Console.WriteLine("Primera Lista");
            while( x <= 5 )
            {
                Console.Write("Ingrese Valor: ");
                
                valor = float.Parse(Console.ReadLine());

                lista1 = lista1 + valor;
                x++;    
            }

            
            x = 1;

            Console.WriteLine("Segunda Lista");
            while( x <= 5 )
            {
                Console.Write("Ingrese Valor:: ");
                valor = float.Parse(Console.ReadLine());

                lista2 = lista2 + valor;
                x++;
            }

            Console.WriteLine("El total de la primera Lista es de " + lista1);
            Console.WriteLine("El total de la segunda Lista es de " + lista2);

            if (lista1 > lista2)
            {
                Console.Write("Lista 1 es Mayor");
            }
            else
            {
                if(lista2 > lista1)
                {
                    Console.Write("Lista 2 es Mayor");
                }
                else
                {
                    Console.Write("Listas Iguales");
                }
            }

    
            Console.ReadKey();

        }
    }
}
