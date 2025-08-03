using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
     class Loops
    {
        public void ForLoopExample()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        public void WhileLoopExample()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Iteration {i}");
                i++;
            }
        }

        public void DoWhileLoopExample()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Iteration {i}");
                i++;
            } while (i < 5);
        }

        public void ForeachLoopExample()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        public void NestedLoopExample()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Outer Loop: {i}, Inner Loop: {j}");
                }
            }
        }

                
    }
}
