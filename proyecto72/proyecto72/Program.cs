using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto72
{

    /*Se tienen las notas del primer parcial de los alumnos de 
     * dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.
     * Realizar un programa que muestre el curso que obtuvo el mayor promedio general.*/



    class Cursos
    {
        private double[] cursoA;
        private double[] cursoB;
        private double promedioA;
        private double promedioB;


        /*Cargar Notas de alumnos*/
        public void CargarNotas()
        {
            cursoA = new double[5];
            cursoB = new double[5];

            Console.WriteLine("Ingrese las notas del curso A");
            for(int i = 0; i < cursoA.Length; i++)
            {
                Console.Write("Ingrese Nota: ");
                cursoA[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese las notas del curso B");
            for (int i = 0; i < cursoB.Length; i++)
            {
                Console.Write("Ingrese Nota: ");
                cursoB[i] = double.Parse(Console.ReadLine());
            }

        }

        /*Metodo que calcula el promedio de las notas*/
        public void Promediar()
        {
           
            double sumaCursoA = 0;
            double sumaCursoB = 0;

            for (int i = 0; i < 5; i++)
            {
                sumaCursoA += cursoA[i];
                sumaCursoB += cursoB[i];
            }

            promedioA = sumaCursoA / cursoA.Length;
            promedioB = sumaCursoB / cursoB.Length;
            
        }


        /*Calcular el promedio mayor*/
        public void CalcularMayorPromedio()
        {
            if(promedioA > promedioB)
            {
                Console.WriteLine("El mayor promedio es del curso A");
                Console.WriteLine("Promedio: " + promedioA);
            }
            else
            {
                Console.WriteLine("El mayor promedio es del curso B");
                Console.WriteLine("Promedio: " + promedioB);
            }
        }





        static void Main(string[] args)
        {
            Cursos cursos1 = new Cursos();
            cursos1.CargarNotas();
            cursos1.Promediar();
            cursos1.CalcularMayorPromedio();
            Console.ReadKey();
        }
    }
}
