using System;
using System.Threading;

namespace PriceIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PriceIt.\r\n");
            Console.WriteLine("Please note: We do NOT collect any answers that you submit.\r\n")
            Thread.Sleep(3000);
            Console.Write("If you are paying daily, enter 'd'.\r\n");
            Console.Write("If you are paying weekly, enter 'w'.\r\n");
            Console.Write("If you are paying monthly, enter 'm'.\r\n");
            Console.Write("If you are paying annually, enter 'a'.\r\n");
            Thread.Sleep(2000);
            Console.WriteLine("Looking for more options? Please enter 'o'. ");
            string payFreq = Console.ReadLine();

            Console.Write("What is your symbol of currency? ");
            string currencySymbol = Console.ReadLine();

            switch(payFreq)
            {
                case "d":
                    Console.Write("You are paying daily for something. \r\n");
                    Console.WriteLine("For how many days are you paying for? \r\n");
                    double payLengthDays = Console.ReadLine();
                    Console.Write($"\r\nGreat! You're paying for {payLengthDays} days!\r\n");
                    Console.Write("How much are you paying each day? (Please don't include any symbol of currency). \r\n");
                    double payAmountDays = Console.ReadLine();
                    Console.Write($"Ok! So you are paying {currencySymbol}{payAmountDays} in daily increments for {payLengthDays} days.\r\n");
                    double hirePurchaseCost = 
                    Console.Write($"This would mean that the total cost of your item is... {hirePurchaseCost}. ");
                    break;
            }
        }
    }
}
