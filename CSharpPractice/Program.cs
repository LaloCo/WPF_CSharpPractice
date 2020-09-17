using CSharpPractice.Classes;
using CSharpPractice.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildBankAccount bankAccount = new ChildBankAccount();
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();

            Console.WriteLine(Information(bankAccount));
            Console.WriteLine(Information(simpleMath));

            Console.ReadLine();
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }

    class SimpleMath : IInformation
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double[] numbers)
        {
            return numbers.Sum();
        }

        public string GetInformation()
        {
            return "Class that solves simple math";
        }
    }
}
