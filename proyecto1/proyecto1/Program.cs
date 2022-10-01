using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas horas trabajas al dia: ");
            string linea = Console.ReadLine();
            int horasTrabajadas = int.Parse(linea);

            Console.Write("Cuanto cobras por hora: ");
            string horas = Console.ReadLine();
            float costoHora = float.Parse(horas);

            float sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("Tu sueldo es de: {0}", sueldo);
            Console.Read();
            

        }
    }
}
