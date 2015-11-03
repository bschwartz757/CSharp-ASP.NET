using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ones = 0, twos = 0, threes = 0, fours = 0;
            Random rand = new Random();
            int[] numberArray = new int[50];
            // Blake Schwartz  ITC 110  10/13/2014
            // Populate the Array
            for(int i=0;i<numberArray.Length;i++)
            {
                numberArray[i] = rand.Next(1, 5);
            }

            foreach(int i in numberArray)
            {
                if (i==1){ones++;}
                else if (i == 2) { twos++; }
                else if (i == 3) { threes++; }
                else { fours++; }
            }

            Console.Write("\nOnes:\t");
            for (int i = 0; i < ones;i++ )
            {
                Console.Write("*");
            }

            Console.Write("\ntwos:\t");
            for (int i = 0; i < twos; i++)
            {
                Console.Write("*");
            }

            Console.Write("\nthrees:\t");
            for (int i = 0; i < threes; i++)
            {
                Console.Write("*");
            }

            Console.Write("\nfours:\t");
            for (int i = 0; i < fours; i++)
            {
                Console.Write("*");
            }

            int[] numbersArray2 = new int[50];
            for (int i = 0; i < numbersArray2.Length; i++ )
            {
                numbersArray2[i] = rand.Next(1, 1000);
            }

            int max = 0;
            foreach(int i in numbersArray2)
            {
                if (i > max) { max = i; }
            }

            int maxb=numbersArray2.Max();

            Console.WriteLine("\nthe max is " + max);

            //****************************************

            // A two-dimensional Array:

            string[,]books=new string[3,2];
            books[0, 0] = "The Lord of the Rings";
            books[0, 1] = "Tolkien";
            books[1, 0] = "The Grapes of Wrath";
            books[1, 1] = "Steinbeck";
            books[2, 0] = "The Martian Chronicles";
            books[2, 1] = "Ray Bradbury";

            Console.WriteLine("Enter an author");
            string author = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if(author.Equals(books[i,1]))
                {
                    Console.WriteLine(books[i, 0]);
                }
            }
                Console.ReadKey();
        }
    }
}
