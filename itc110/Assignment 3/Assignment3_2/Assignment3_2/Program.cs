using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        /* This assignment introduces Selection (the if statement.)

1. For this one, use the tip assignment from 3 in Assignment 2, Change it so the user can enter a decimal or a whole number for the tip percent. So if the percent is greater than 1 divide by 100 otherwise use the decimal they provided.

2. Have the user enter a number. If it is even output "Even," if odd, "Odd."

3. Have the user enter a grade point between 0 and 4. Validate that the number is in the correct range then evaluate the number to assign a letter grade. The assignment would correspond to this table 
            
 BLAKE SCHWARTZ
 * SECTION 3192 MW EVENING CLASS
 * ASSIGNMENT 3 10/1/2014 PART 2
 */

        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a whole number");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            } //End if
            else
            {
                Console.WriteLine("Odd");
            } //End else

            Console.ReadKey();
        } // End Main
    } // End Class
} // End Namespace
