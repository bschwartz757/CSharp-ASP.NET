using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipHandling
{
    /*Create a Class called "Tip."

The class should have fields for the amount the tip is based on, the percentage of the tip and the tax percent.

Make the tax percent a constant of .094.

There should be methods in the class for calculating the tip, the tax and the total.

Make a second class called "Display."

The Display class gets the users input for the amount to be tipped on, and the percent they want to tip and 
     * passes them to the Tip class. Then it retrieves the tip, tax and total amounts and displays them.

Call the Display class from the Main() method in the Program class.

Remember the Tip class should have nothing in it about display. We will use this class with the next two 
     * assignments.
 */
      class Program
    {
        static void Main(string[] args)
        {
            Display d = new Display();
            Program p = new Program();
            ReadTip r = new ReadTip(@"C:\SCCC 2014-2015 WD Files\ITC110\Assignment9\writegratuity.txt");
            Console.WriteLine(r.GetFile());
            Console.ReadKey();
        }
       

    }
}