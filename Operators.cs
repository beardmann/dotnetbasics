using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    internal class Operators
    {
        public void Operators1( int a , int b) {
            // xor operator

            int xorResult = a ^ b;
            Console.WriteLine($"XOR of {a} and {b} is: {xorResult}");


        }
    }
}
