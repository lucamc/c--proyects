using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto63
{
    class Employee

    {
        private string name;
        private float salary;


        public void Entry() //Entrada
        {
            Console.Write("Enter the name: ");
            name = Console.ReadLine();

            Console.Write("Enter the salary: ");
            salary = float.Parse(Console.ReadLine());

        }

        public void Print() //Imprimir
        {
            Console.WriteLine("Employee data");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

        public void PrintPayTax() //Si debe pagar Impuestos
        {
            if(salary > 3000)
            {
                Console.WriteLine("Have to pay taxes");
            }
            else
            {
                Console.WriteLine("You don't have to pay taxes");
            }
        }

        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.Entry();
            employee1.Print();
            employee1.PrintPayTax();
            Console.ReadKey();



        }
    }
}
