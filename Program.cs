class Hello
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");
        Greet();
        System.Console.ReadLine();
    }

    static void Greet()
    {
        System.Console.WriteLine("Greetings from the Greet method!");
    }

    static void AnotherMethod()
    {
        System.Console.WriteLine("This is another method.");
    }
}