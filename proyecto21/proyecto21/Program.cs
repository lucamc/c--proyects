using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            Console.Write("Insert the day: ");
            day= int.Parse(Console.ReadLine());

            Console.Write("Insert the month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Insert the year: ");
            year = int.Parse(Console.ReadLine());

            if (day == 25 && month == 12)
            {
                Console.Write("The date corresponds to christmas");
            }
            Console.ReadKey();
        }  
    }
}
