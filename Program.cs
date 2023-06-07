using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello viewer, Welcome to .Net FSD program !");
            //Console.ReadLine();

            //int a = 123456789;
            //long b = a;
            //Console.WriteLine(b);


            Console.WriteLine("Arithmetic Calculator");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
