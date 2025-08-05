using dotnetbasics;
using System;


Console.WriteLine("Hello, World!");



//Comments --single line comment 

/*
 multiple line comments 
all the are example of multiple line comments 
 */


//// variables 
//int a = 10, b = 34;
//bool c = true, d = false;
//variables1 var1 = new variables1();
//// variables and operators
//var1.testvariables(a, b, c, d);


////conditional operators  if , if-else , switch;

//ConditionalOperaators cond = new ConditionalOperaators();
//cond.DrivingLicense(20);

//cond.CheckEvenOdd(10);
//cond.CheckEvenOdd(-11);
//cond.DayOfWeek(1);


//// loops while , do-while , for , foreach
//Loops loops = new Loops();
//loops.ForLoopExample();

//loops.WhileLoopExample();
//loops.DoWhileLoopExample();
//loops.ForeachLoopExample();
//loops.NestedLoopExample();
//Console.ReadLine();

//// operators xor and right shift left
//Operators operators = new Operators();
//operators.Operators1(15, 3);
//Console.ReadLine();

//// oops concepts inheritance , polymorphism , encapsulation , abstraction
///


//Child oops = new Child();
//oops.Display();
//oops.Show(); // This will call the Parent class method due to method hiding
//oops.test();
//oops.Hyper(); // This will call the Child class method due to method hiding
//GrandChild grandChild = new GrandChild();
//grandChild.DisplayGrandChild(); // This will call the GrandChild class method
//Sibling sibling = new Sibling();
//sibling.DisplaySibling(); // This will call the Sibling class method



//oops_2_PolmorphismExample oops1 = new oops_2_PolmorphismExample1();
//// method overloading example
//Console.WriteLine(oops1.add(10, 20)); // Calls the int version
//Console.WriteLine(oops1.add(10.5, 20.5)); // Calls the double version
// Pig pig = new Pig();
//pig.MakeSound();  // Output: Wee wee!
//pig.Sleep();      // Output: The animal is sleeping.



//pig.food("vegetables"); // Output: The pig eats vegetables.

// constructor example

//oops_constructor obj = new oops_constructor(50);

//string testString = "--:text in here:--";

//// Call the method from the other class
//string result = RegularExpressionExample.ExtractTextBetweenColons(testString);
//Console.WriteLine("Extracted text: " + result);

// encapsulation example
//oops_3_encapsulation.Person person = new oops_3_encapsulation.Person
//{
//    Name = "John Doe", // Set the name
//    Age = 30 // Set the age
//};
//person.Display(); // Display the person's details
//                  // person.Name = ""; // Uncommenting this line will throw an exception because the name cannot be empty
//                  // person.Age = -5; // Uncommenting this line will throw an exception because age must be a positive number
//                  // person.Display(); // Display the person's details again
//                  //Console.WriteLine("Press Enter to exit...");  


string filePath = "C:\\Users\\Beardmann_shubh\\Desktop\\testing1.txt";
FileHandling fileHandler = new FileHandling();
fileHandler.ReadFile(filePath);


Console.ReadLine();
