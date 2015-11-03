using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This assignment introduces Selection (the if statement.)

1. For this one, use the tip assignment from 3 in Assignment 2, Change it so the user can enter a decimal or a whole number for the tip percent. So if the percent is greater than 1 divide by 100 otherwise use the decimal they provided.

2. Have the user enter a number. If it is even output "Even," if odd, "Odd."

3. Have the user enter a grade point between 0 and 4. Validate that the number is in the correct range then evaluate the number to assign a letter grade. The assignment would correspond to this table
 * ASSIGNMENT 3
 * BLAKE SCHWARTZ SECTION 3192
 * 10/1/2014 */

            int year;
            Console.WriteLine("Enter the year of your birth (a 4 digit integer)");
            string yearString = Console.ReadLine();
            if (yearString.Length == 4)
            {
                bool goodYear = int.TryParse(yearString, out year);
                if (goodYear)
                {
                    int currentYear = DateTime.Now.Year;
                    int yearsOld = currentYear - year;
                    Console.WriteLine("You are {0} years old", yearsOld);

                    string message = null;

                    if (yearsOld > 50)
                    {
                        message = "Well done";
                    }
                    else if (yearsOld > 40)
                    {
                        message = "Age perfection";
                    }
                    else if (yearsOld > 30)
                    {
                        message = "Just getting going";
                    }
                    else if (yearsOld > 20)
                    {
                        message = "Youth is wasted on the young";
                    }
                    else
                    {
                        message = "Just getting started";
                    }
                    Console.WriteLine(message);
                    Console.ReadKey();
                }
            } //end main
        }
    } 
}
