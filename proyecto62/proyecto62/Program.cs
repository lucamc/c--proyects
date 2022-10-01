using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto62
{
    class Cuadrado
    {
        private int lado;


        public void CargarValor()
        {
            Console.Write("Ingrese la medida del lado de un cuadrado: ");
            lado = Convert.ToInt32(Console.ReadLine());
        }


        public void ImprimirPerimetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("Perimetro del cuadrado: " + perimetro);
            
        }
       
        public void ImprimirSuperficie()
        {
            int superficie;
            superficie = lado * lado;
            Console.WriteLine("Superficie del cuadrado: " + superficie);
        }




        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();

            cuadrado1.CargarValor();
            cuadrado1.ImprimirPerimetro();
            cuadrado1.ImprimirSuperficie();
            Console.ReadKey();


        }
    }
}
