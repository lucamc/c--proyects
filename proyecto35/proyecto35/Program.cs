using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto35
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count;
            x = 1;
            count = 11;

            while(x <= 25)
            {
               
               Console.WriteLine(count);
                count = count + 11;
                

                x++;

            }
            Console.ReadKey();
        }
    }
}
