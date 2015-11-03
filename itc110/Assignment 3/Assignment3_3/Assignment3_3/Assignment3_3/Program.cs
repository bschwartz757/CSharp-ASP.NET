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
 
Grade Equivalents;
Grade Point	Letter Grade
3.5 to 4	A
3 to 3.4	B
2 to 2.9	C
1 to 1.9	D
0 to 0..9	F
         * 
 BLAKE SCHWARTZ
 * SECTION 3192 MW EVENING CLASS
 * ASSIGNMENT 3 10/1/2014 PART 3
 */

        static void Main(string[] args)
        {
            double gradePoint;

            Console.WriteLine("Enter a grade point average between 0 and 4");
            gradePoint = double.Parse(Console.ReadLine());

            if (gradePoint >= 3.5 && gradePoint <= 4)
            {
                Console.WriteLine("A");
            } //End if
            else if (gradePoint >= 3 && gradePoint <= 3.4)
            {
                Console.WriteLine("B");
            } //End else if 1
            else if (gradePoint >= 2 && gradePoint <= 2.9)
            {
                Console.WriteLine("C");
            } //End else if 2
            else if (gradePoint >= 1 && gradePoint <= 1.9)
            {
                Console.WriteLine("D");
            } //End else if 3
            else if (gradePoint >= 0 && gradePoint <= 0.9)
            {
                Console.WriteLine("F");
            }

            Console.ReadKey();
        } // End Main
    } // End Class
} // End Namespace
