using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Display
    {
        private BattingAverage ba = new BattingAverage();

        public Display()
        {
            GetInput();
        }
        private void GetInput()
        {
            Console.WriteLine("Enter total number of at-bats");
            ba.AtBats = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter total number of hits");
            ba.Hits = int.Parse(Console.ReadLine());

            ShowBattingAverage();
        }

        private void ShowBattingAverage()
        {
            Console.WriteLine("The batting average is " + ba.CalculateBattingAverage());
        }
    }
}
