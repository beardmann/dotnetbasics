using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    // inheritence example
    class Parent
    {
        public  void Display()
        {
            Console.WriteLine("Parent class method");
        }

        public void Show()
        {
            Console.WriteLine("Parent class show method");
        }

    }

    class Child : Parent
    {
        public  void test()
        {
            Console.WriteLine("Child class method");
        }

        public void Hyper()
        {
            Console.WriteLine("Child class show method");
        }
    }


     




}