using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto69
{
    class SueldosEmepleados
    {
        private int[] sueldosPrimerTurno;
        private int[] sueldosSegundoTurno;


        public void CargarSueldos()
        {
            sueldosPrimerTurno = new int[4];
            sueldosSegundoTurno = new int[4];

            for(int i = 0; i < sueldosPrimerTurno.Length; i++)
            {
                Console.Write("Turno Manañana, Ingrese sueldo: ");
                sueldosPrimerTurno[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < sueldosSegundoTurno.Length; i++)
            {
                Console.Write("Turno Tarde, Ingrese Sueldo: ");
                sueldosSegundoTurno[i] = int.Parse(Console.ReadLine());

            }
        }

        public void SumarSueldos()
        {
            int sumaPrimerTurno = 0;
            int sumaSegundoTurno = 0;

            for (int i = 0; i < 4; i++)
            {
                sumaPrimerTurno += sueldosPrimerTurno[i];
                sumaSegundoTurno += sueldosSegundoTurno[i];
            }

            Console.WriteLine("Gastos en sueldos turno mañana: " + sumaPrimerTurno);
            Console.WriteLine("Gastos en sueldos turno tarde: " + sumaSegundoTurno);
        }


        static void Main(string[] args)
        {

            SueldosEmepleados sueldosEmpleados1 = new SueldosEmepleados();
            sueldosEmpleados1.CargarSueldos();
            sueldosEmpleados1.SumarSueldos();
            Console.ReadKey();


        }
    }
}
