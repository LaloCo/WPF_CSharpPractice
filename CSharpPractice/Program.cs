using CSharpPractice.Classes;
using System;
using System.Linq;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            var result = SimpleMath.Add(numbers);
            Console.WriteLine(result);

            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.AddToBalance(100);
            Console.WriteLine(bankAccount.Balance);

            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddToBalance(100);
            Console.WriteLine(childBankAccount.Balance);

            Console.ReadLine();
        }
    }

    class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double[] numbers)
        {
            return numbers.Sum();
        }
    }
}
