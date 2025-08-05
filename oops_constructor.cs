using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    class oops_constructor
    {
        readonly int MAX = 100; // constant variable

        // Example of a constructor

        public oops_constructor(int max)
        {
            Console.WriteLine("Constructor called");
            this.MAX = max; // This will cause an error because MAX is a constant and cannot be changed after initialization 

            Console.WriteLine("The value of MAX is: " + MAX);
        }
    }
}
