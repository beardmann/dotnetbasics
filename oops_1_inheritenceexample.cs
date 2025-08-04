using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    // inheritence example

    // types of inheritence  single inheritence , multilevel inheritance, hierarchical inheritance, multiple inheritance, hybrid inheritance

    // example of single inheritance
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


    // example of multilevel inheritance

    class GrandChild : Child
    {
        public void DisplayGrandChild()
        {
            Console.WriteLine("GrandChild class method");
        }
    }


    // example of hierarchical inheritance

    class Sibling : Parent
    {
        public void DisplaySibling()
        {
            Console.WriteLine("Sibling class method");
        }
    }

    // example of multiple inheritance this can not be achieve by the inheritence in C# but can be achieved by interfaces






}