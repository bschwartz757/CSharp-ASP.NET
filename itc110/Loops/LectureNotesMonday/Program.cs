using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureNotesMonday
{
    class Program
    {
        static void Main(string[] args)
            // This is about writing Loops
        {
            Random rand = new Random();
            for(int n=0;n<10;n++) // The ++ is an operator that tells the computer to increment by one
            {
            // To generate a random number:
           
            int number = rand.Next(1, 501);
            Console.WriteLine(number);
            }
            Console.WriteLine("*********");
            int number2 = 3;
            for (int i = 0; i < 10; i++ ) // Same as number2 = number2+i (adding)
            {
                number2 += i;
                Console.WriteLine(number2);
            }

            /*
            Console.WriteLine("How many loops?");  Number of loops
            int numberOfLoops = int.Parse(Console.ReadLine());
           */
           
            string go = "yes";
            int counter = 0;
            while (go.Equals("yes") || go.Equals("Yes"))
            {
                counter++;
                Console.WriteLine("You have done {0} loops", counter);
                Console.WriteLine("Do you want to do another?");
                go = Console.ReadLine();
            }
             /*   for (int n = 0; n < 10; n--) // The -- is an operator that tells the computer to decrement by one
                {
                    int number = rand.Next(1, 501);
                    Console.WriteLine(number);
                } */
            Console.ReadKey();
        }
    }
}
