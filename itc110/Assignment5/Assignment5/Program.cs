using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    /* ASSIGNMENT 5: ARRAYS
* 1. Create an array of 50 random integers. Then loop through the array and output a count of how many of the array elements are even numbers;

2. Create an array of strings. Place about 10 of your favorite quotes in the array. Use a random number generator to randomly select and display one of the quotes from the array every time you run the program.

3. Create an array of 10 doubles. Prompt a user to enter numbers into the array. After all the numbers have been entered display all the numbers in the array, the total of the numbers and the average.

    Blake Schwartz, 10/15/2014
* ITC 110, Section 3192 (Evening)
* PART 5.1 */
    {
        static void Main(string[] args)
        {
         /*   Random rand = new Random();
            int even = 0;
            int[] numberArray = new int[50];

            for (int i = 0; i < numberArray.Length; i++) 
            {
                numberArray[i] = rand.Next(1,50);
                if (numberArray[i] % 2 == 0) {
                    even++;
                }
            }
            Console.WriteLine("There are " + even + " even numbers");
          Console.ReadKey();
          * */
  /*  Blake Schwartz, 10/15/2014
* ITC 110, Section 3192 (Evening)
* PART 5.2 
            Random rand = new Random();
 
            string[] quotes = new string[]
            {"You can't always get what you want", "You get what you need", "Carpe diem", "When life gives you lemons...", "Sometimes you eat the bar...", "If wishes were fishes...", "Win some, lose some", "Don't look a gift horse...", "Rehab is for...", "Give em hell"};
            int number = rand.Next(0, 10);
            Console.WriteLine(quotes[number]);
            Console.ReadKey();
      
              Blake Schwartz, 10/15/2014
          * ITC 110, Section 3192 (Evening)
          * PART 5.3 */

            double[] input = new double[10];

            for (int i=0;i<input.Length;i++)
            {
                Console.WriteLine("Enter a number");
                input[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.WriteLine("The sum is:" + input.Sum());
            Console.WriteLine("The average is:" + input.Average());
            Console.ReadKey();
        }

      
    }// END CLASS
}
