using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        internal static void Addition()
        {
            Console.WriteLine("Addition Selected");
            Console.WriteLine("Please enter the first number.");
            var num1 = Console.ReadLine();
            while (!double.TryParse(num1, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num1 = Console.ReadLine();
            }

            Console.WriteLine($"{num1} is the first number.");
            Console.WriteLine("Please enter the second number");
            var num2 = Console.ReadLine();
            while(!double.TryParse(num2, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num2 = Console.ReadLine();
            }
            Console.WriteLine($"{num2} is the second number");
            var result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
            Console.WriteLine($"{num1} + {num2} is {result}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }

        internal static void Subtraction()
        {
            Console.WriteLine("Subtraction Selected");
            Console.WriteLine("Please enter the first number.");
            var num1 = Console.ReadLine();
            while (!double.TryParse(num1, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num1 = Console.ReadLine();
            }

            Console.WriteLine($"{num1} is the first number.");
            Console.WriteLine("Please enter the second number");
            var num2 = Console.ReadLine();
            while (!double.TryParse(num2, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num2 = Console.ReadLine();
            }
            Console.WriteLine($"{num2} is the second number");
            var result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
            Console.WriteLine($"{num1} - {num2} is {result}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }

        internal static void Multiplication()
        {
            Console.WriteLine("Multiplication Selected");
            Console.WriteLine("Please enter the first number.");
            var num1 = Console.ReadLine();
            while (!double.TryParse(num1, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num1 = Console.ReadLine();
            }

            Console.WriteLine($"{num1} is the first number.");
            Console.WriteLine("Please enter the second number");
            var num2 = Console.ReadLine();
            while (!double.TryParse(num2, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num2 = Console.ReadLine();
            }
            Console.WriteLine($"{num2} is the second number");
            var result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
            Console.WriteLine($"{num1} * {num2} is {result}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }

        internal static void Division()
        {
            Console.WriteLine("Division Selected");
            Console.WriteLine("Please enter the first number.");
            var num1 = Console.ReadLine();
            while (!double.TryParse(num1, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num1 = Console.ReadLine();
            }

            Console.WriteLine($"{num1} is the first number.");
            Console.WriteLine("Please enter the second number");
            var num2 = Console.ReadLine();
            while (!double.TryParse(num2, out _))
            {
                Console.WriteLine("Please enter a valid number");
                num2 = Console.ReadLine();
            }
            Console.WriteLine($"{num2} is the second number");
            var result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Console.WriteLine($"{num1} / {num2} is {result}");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }
}
