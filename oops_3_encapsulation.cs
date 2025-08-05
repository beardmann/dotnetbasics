using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    public class oops_3_encapsulation
    {
        // example of encapsulation
       public class Person
        {
            private string name;
            private int age;
            // Property for Name with validation
            public string Name
            {
                get { return name; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                }
            }
            // Property for Age with validation
            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                    else
                    {
                        throw new ArgumentException("Age must be a positive number");
                    }
                }
            }
            // Method to display person details
            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

    }
}
