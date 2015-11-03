using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Display
    {
        private Tip t;

        public Display()
        {
            t = new Tip();
            GetInput();
            ShowOutput();
        }
        private void GetInput()
        {
            Console.WriteLine("What is the total amount to base the tip on?");
            t.MealAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the tip percentage you want to leave?");
            t.TipPercent = double.Parse(Console.ReadLine());
        }
        private void ShowOutput()
        {
            Console.WriteLine("Your total amount is: ${0}", t.CalculateTotalAmount());
            Console.WriteLine("Your tip amount is: ${0}", t.CalculateTip());
            Console.WriteLine("The tax amount is: ${0}", t.CalculateTaxAmount());

            Console.ReadKey();

        }
    }
}
