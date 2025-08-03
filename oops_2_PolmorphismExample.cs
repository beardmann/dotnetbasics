using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    class oops_2_PolmorphismExample
    {
        // method overloading example
      public  int add(int a, int b)
        {
            return(a + b);
        }
        // method overloading example
      public  double add(double a, double b)
        {
            return (a + b);
        }

        // method overloading example
       public double add(int a, int b, int c)
        {
            return (a + b + c);
        }

    }

    class oops_2_PolmorphismExample1 : oops_2_PolmorphismExample
    {
        // method overriding example

        public int add(int a, int b) { 
            return (a - b);
        
        }

        // method overriding example
       public double add(double a, double b)
        {
            return (a - b);

        }
        // method overriding example    
       public double add(int a, int b, int c)
        {
            return (a - b - c);
        }



    }



}