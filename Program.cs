using dotnetbasics;
using System;


class Hello
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");



        //Comments --single line comment 

        /*
         multiple line comments 
       all the are example of multiple line comments 
         */


        // variables 
        //int a = 10, b = 34;
        //bool c = true, d = false;
        //variables1 var1 = new variables1();
        //// variables and operators
        //var1.testvariables(a, b, c, d);
        

        //conditional operators  if , if-else , switch;

        ConditionalOperaators cond = new ConditionalOperaators();
        cond.DrivingLicense(20);

        cond.CheckEvenOdd(10);
        cond.CheckEvenOdd(-11);
        cond.DayOfWeek(1);


        // loops while , do-while , for , foreach
        Loops loops = new Loops();
        loops.ForLoopExample();
       
        loops.WhileLoopExample();
        loops.DoWhileLoopExample();
        loops.ForeachLoopExample();
        loops.NestedLoopExample();
        Console.ReadLine();



    }


}