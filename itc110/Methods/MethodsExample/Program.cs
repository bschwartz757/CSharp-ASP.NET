using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample
{
    class Program
    {
        static void Main(string[] args)

        // Lecture Notes from Wednesday 10/15/2014
        {
            Program p = new Program();
            // p.AddNumbers();
            p.Display();
            p.EndProgram();
        }
        // This is a Method:
        private void AddNumbers()
        {
            int number1 = 4, number2 = 3;
            int sum = number1 + number2;
            Console.WriteLine("the Total is" + sum);
        }

        private int GetNumber()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        private int GetSum()
        {
            int sum = GetNumber() + GetNumber();
            return sum;
        }

        private void Display()
        {
            int sum = GetSum();
            Console.WriteLine("the sum is" + sum);
        }
        // Another Method:
        private void EndProgram()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    } // All Methods need to go inside the Class
}
