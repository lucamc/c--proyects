using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto36
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 8;

            while(x <= 500)
            {
                Console.WriteLine(x);

                x = x + 8;
            }
            Console.ReadKey();

        }
    }
}
