using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto64
{
    class Operations

    {
        // Atributes
        private int value1, value2;



        // Method entry values
        public void Entry()
        {
            Console.Write("Enter the first value: ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            value2 = Convert.ToInt32(Console.ReadLine());
        }
       
        //Method Sum
        public void Sum()
        {
            
            int sum = value1 + value2;
            Console.WriteLine("The sum is: " + sum);
        }

        //Method Substraction
        public void Substraction()
        {
           
            int substraction = value1 - value2;
            Console.WriteLine("The substraction is: " + substraction);
        }

        //Method Multiplication 
        public void Multiplication()
        {
      
            int multiplication = value1 * value2;
            Console.WriteLine("The multiplication is: " + multiplication);

        }

        // Method Division
        public void Division()
        {
            int division = value1 / value2;
            Console.WriteLine("The division is: " + division);

        }

      
        // Main
        static void Main(string[] args)
        {

            Operations operation1 = new Operations();

            operation1.Entry();
            operation1.Sum();
            operation1.Substraction();
            operation1.Multiplication();
            operation1.Division();
            Console.ReadKey();


        }
    }
}
