using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Welcome to the calculator app!");

            while (!endApp)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("a - Add");
                Console.WriteLine("s - Subtract");
                Console.WriteLine("m - Multiply");
                Console.WriteLine("d - Divide");
                Console.WriteLine("q - Quit");
                Console.Write("Your option? ");
                switch (Console.ReadLine().Trim().ToLower())
                {
                    case "a":
                        Calculator.Addition();
                        break;
                    case "s":
                        Calculator.Subtraction();
                        break;
                    case "m":
                        Calculator.Multiplication();
                        break;
                    case "d":
                        Calculator.Division();
                        break;
                    case "q":
                        Console.WriteLine("Press Any Key To Exit");
                        Console.ReadLine();
                        endApp = true;
                        break;
                }
                Console.Clear();
            }
        }
        
    }
}
