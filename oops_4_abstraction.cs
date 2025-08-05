using System;

namespace dotnetbasics
{
    // Example of abstraction    
    public abstract class Animal
    {
        // Abstract method (no body)
        public abstract void MakeSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }

        public abstract void food(string foodtype);
    }

    // Concrete class
    public class Pig : Animal
    {
        // Override the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Wee wee!");
        }

        public override void food(string foodtype)
        {
            Console.WriteLine($"The pig eats {foodtype}.");
        }
    }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Pig myPig = new Pig();
    //         myPig.MakeSound();  // Output: Wee wee!
    //         myPig.Sleep();      // Output: The animal is sleeping.
    //     }
    // }
}
