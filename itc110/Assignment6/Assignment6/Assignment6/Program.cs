using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        // ASSIGNMENT 6:
        //Create a program that calculates a grade point average.
        /* This program should have an input method that asks the user how many grades they want to enter. 
         * You should create two arrays of that size, one for the grades and one for the number of credits. 
         * Loop through the arrays prompting the users to enter the grades and credits for each course. 
         * (Do both arrays in the same loop to keep the indexes aligned.) 
         * Both arrays should be passed as parameters to a second method that does the calculations.
         * 
         GPA is a weighted average, You get the weight by multiplying the grade point times the credits. 
         * This is so a 2 credit class doesn't count as much as a 5 credit class. 
         * Then you total the credits and the weight and divide the weight by the total credits. Here is an example with three grades:

Grade	Credits	Weight
3.4	5	17
2	1	2
4	5	20
 	11	39
 
39 divided by 11=3.5

The method that Calculates the GPA should return the GPA as a double. 

Create a display method that calls the calculate method and displays the GPA .

The Main() method should call the input and display methods.*/

        // BLAKE SCHWARTZ   3192    10/27/2014

          // Create variable for number of grades to enter (class scope):
            int number;
        static void Main(string[] args)
        { //Create program, start, and EndProgram methods:
            Program p = new Program();
            p.Start();
            p.EndProgram();
          
        }

        private void GetNumberOfGrades()
        { //Prompt user for number of grades:
            Console.WriteLine("How many grades do you want to enter?");
            number = int.Parse(Console.ReadLine());
        }
        private void Start()
        { //Start program, call CreateArrays method:

            GetNumberOfGrades();
            CreateArrays();
        }
        
        private void CreateArrays()
        { //Create 2 arrays; pass arrays to PopulateArrays method:
            double[] grades=new double[number];
            int[] credits=new int[number];

            PopulateArrays(grades, credits);
        }

        private void PopulateArrays(double[] grades, int[] credits)
        { //Populate arrays using user input; pass values to CalculateGPA method:
            for (int i=0;i<number ;i++ )
            {
                Console.WriteLine("What was your grade for this class?");
                grades[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("How many credits is this class worth?");
                credits[i] = int.Parse(Console.ReadLine());
            }

            CalculateGPA(grades, credits);
        }

        private void CalculateGPA(double[] grades, int[] credits)
        { //Declare weight; Use weight and other outputs to calculate Weighted GPA;
            double weight = 0;

            for(int i=0;i<number;i++)
            {
                weight += grades[i] * credits[i];
            }

            double GPA = weight / credits.Sum();
            Console.WriteLine("Your GPA is {0:F2}", GPA);
        }

        private void EndProgram()
        { //End Program method:
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    } //end class
} //end Namespace
