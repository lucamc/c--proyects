using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto60
{
    class Triangulo
    {
        private float lado1, lado2, lado3;

        public void Inicializar()
        {
            Console.Write("Ingresar lado1: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.Write("Ingresar lado2: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.Write("Ingresar lado3: ");
            lado3 = float.Parse(Console.ReadLine());

        }

        public void ImprimirLadoMayor()
        {
            if(lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine("Lado Mayor es de: " + lado1);
            }
            else
            {
                if(lado2 > lado3)
                {
                    Console.WriteLine("Lado Mayor es de: " + lado2);
                }
                else
                {
                    Console.WriteLine("Lado Mayor es de: " + lado3);

                }
            }
        } 

        public void EsEquilatero()
        {
            if(lado1 == lado2 && lado1 == lado3)
            {
                Console.Write("El Triangulo es Equilatero");
            }
            else
            {
                Console.Write("El Triangulo No es Equilatero");
            }
        }

        static void Main(string[] args)
        {

            Triangulo triangulo1 = new Triangulo();
            triangulo1.Inicializar();
            triangulo1.ImprimirLadoMayor();
            triangulo1.EsEquilatero();
            Console.ReadKey();

        }
    }
}
