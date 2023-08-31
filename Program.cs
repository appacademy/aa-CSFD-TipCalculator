using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount, percent;

            Console.Write("Enter the amount: ");
            amount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the tip percentage: ");
            percent = decimal.Parse(Console.ReadLine()) / 100;

            Console.WriteLine($"For an amount of {amount:c} a {percent:p2} tip would be {amount * percent:c} totalling {amount * (1 + percent):c}.");
        }
    }
}
