using System;

namespace P01_HelloName
{
    class P01_HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
