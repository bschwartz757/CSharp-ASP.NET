using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipHandling
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
        public void ShowOutput()
        {
            Console.WriteLine("Your total amount is: ${0}", t.CalculateTotalAmount());
            Console.WriteLine("Your tip amount is: ${0}", t.CalculateTip());
            Console.WriteLine("The tax amount is: ${0}", t.CalculateTaxAmount());

            WriteTip gratuity = new WriteTip(@"C:\SCCC 2014-2015 WD Files\ITC110\Assignment9\writegratuity.txt");
            gratuity.AddToFile("The total amount of the meal is: " + t.MealAmount.ToString());
            gratuity.AddToFile("The recommended tip amount is: " + t.CalculateTip().ToString());
            gratuity.AddToFile("The grand total is: " + t.CalculateTotalAmount().ToString());
            gratuity.CloseFile();

        }
    }
}
