﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;

            while(x <= 100)
            {
                Console.WriteLine( x );

                x = x + 1;
            };

            Console.ReadKey();
        }
    }
}
