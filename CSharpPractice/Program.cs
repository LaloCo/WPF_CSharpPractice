using System;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            if(numberTwo == 1)
            {
                var numberThree = 12f;
            }
            var numberOne = 23.45;
            Console.WriteLine(numberOne);
            var message = Console.ReadLine();
            Console.WriteLine($"Echo: {message}");
            Console.ReadLine();
        }
    }
}
