using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            // Calling method with params
            var sum = calculator.Add(5, 10, 15, 20);
        }
    }
}
