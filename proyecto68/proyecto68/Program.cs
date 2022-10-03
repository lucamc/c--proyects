using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto68
{
    class AlturaPersona
    {
        private float[] alturas;
        private float promedio;


        public void Cargar()
        {
            alturas = new float[5];
            for(int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Ingrese altura: ");
                alturas[i] = float.Parse(Console.ReadLine());
            }
        }


        public void Promediar()
        {
            promedio = 0;
            for(int i = 0; i < alturas.Length; i++)
            {
                promedio += alturas[i];
            }
            promedio = promedio / alturas.Length;
            Console.WriteLine("El promedio de alturas es de: " + promedio);
        }


        public void ContarMasAltas()
        {
            int mayorAlPromedio = 0;
            int menorAlPromedio = 0;

            for(int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] > promedio)
                {
                    mayorAlPromedio += 1;
                }
                else
                {
                    menorAlPromedio += 1;
                }
            }

            Console.WriteLine("Alturas mayores al Proemdio: " + mayorAlPromedio);
            Console.WriteLine("Alturas menores al Promedio: " + menorAlPromedio);
        }


       


        static void Main(string[] args)
        {
            AlturaPersona alturas1 = new AlturaPersona();

            alturas1.Cargar();
            alturas1.Promediar();
            alturas1.ContarMasAltas();
            Console.ReadKey();

        }
    }
}
