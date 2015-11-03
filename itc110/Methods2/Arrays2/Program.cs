using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        /// <summary>
        /// ITC 110 10/20/2014
        /// This program we are going to
        /// enter a shopping list into an array
        /// have a second array to store the prices
        /// and third array to store discounts.
        /// these parrallel arrays
        /// Use methods and only use the Main
        /// to start the program
        /// </summary> 

        int number;
        //this variable has class scope
        //meaning it can be seen by any method
        //in the class
        static void Main(string[] args)
        {
            //initialize the program

            Program p = new Program();
           
            //call the Start method
            p.Start();
           
            //call the end program method
            p.EndProgram();
        }

         /// <summary>
        /// the start method starts the program by
        /// calling the PopulateArrays method (which
        /// calls the create arrays methods and the 
        /// display method). It also puts that method
        /// into a while loop so that the program can be
        /// run as many times as the user would like
        /// </summary>
           
        private void Start()
        {
                        //set the variable for the while loop
            string shopping = "yes";
                        //loop as long as the shopping variable equals yes
            while (shopping.Equals("yes"))
            {
                                //call the PopulateArraysMethod
                PopulateArrays();
                                //ask user whether to continue or not
                Console.WriteLine("Continue Yes--any other = no");
                shopping = Console.ReadLine().ToLower();
            }
        }

        /// <summary>
        /// This array gets the number of items
        /// that the user wants to enter
        /// number is a class level variable
        /// and can be seen by any method
        /// </summary>
        private void GetNumberOfItems()
        {
            Console.WriteLine("How many items do you want to enter?");
            number = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method declares and initializes
        /// an array for the shopping list
        /// it returns a string[] array
        /// </summary>
        private string[] CreateShoppinglist()
        {
            string[] shoppingList = new string[number];
            return shoppingList;
        }

        //creates and returns an array for prices
        private double[] CreatePriceList()
        {
            double[] priceList = new double[number];
            return priceList;
        }

        //creates and returns an array for discounts
        private double[] CreateDiscountList()
        {
            double[] discountList = new double[number];
            return discountList;
        }

        /// <summary>
        /// this is the main method of the program
        /// it call the methods that create the arrays
        /// it loops through the arrays and lets
        /// the user enter values. the arrays are 
        /// parallel in that item [0] is parallel to price [0]
        /// is parallel to discount[0] etc.
        /// When the arrays are populated it passes
        /// them to the calculate method
        /// </summary>
        private void PopulateArrays()
        {
            //call GetNumberOfItems method to 
            //make sure number has a value
            GetNumberOfItems();
            //get the arrays created from the
            //methods that create  and return the arrays
            string[] itemList = CreateShoppinglist();
            double[] prices = CreatePriceList();
            double[] discounts = CreateDiscountList();

            //loop through the arrays and prompt
            //the user to enter values
            //by doing the three together we keep 
            //the index values in parallel
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the item name");
                itemList[i] = Console.ReadLine();
                Console.WriteLine("Enter the item price");
                prices[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter any discount as a decimal");
                discounts[i] = double.Parse(Console.ReadLine());
            }

            //call the Calculate method and pass the arrays
            //as parameters. parameters are passed 1st to 1st, 
            //2nd to second, etc. the program only knows if
            //the data type is right, not if it is the correct value
            Calculate(itemList, prices, discounts);
        }

        /// <summary>
        /// This method takes the three arrays as
        /// parameters and loops through them
        /// determing the price. It does this by
        /// subtracting the discount amount from
        /// the give price (price=price - (price * discount)
        /// then it gets the name of the item from the
        /// items array and concatinates it with the price
        /// and passes the string to the Display()
        /// method where it is printed to the console
        /// </summary>
        private void Calculate(string[] items, double[] prices, double[] discounts)
        {
            double price = 0;
            for(int i=0;i<number;i++)
            {
                //get the price by taking the price from the given
                //index of the array and subtracting the price * discount 
                //taken from the same index in discount array
                price = prices[i] - (prices[i] * discounts[i]);
                //put the name and the new price into a string
                //ToString() is a method that converts a number
                //to a string. The "C" formats it as currency
                string itemString = items[i] + "" + price.ToString("C");
                //call the display method and pass it the string
                //as a parameter
                Display(itemString);
            }

        }

        /// <summary>
        /// this method takes a string as a parameter
        /// and writes it to console
        /// </summary>
        private void Display (string itemPrice)
        {
            Console.WriteLine(itemPrice);
        }
        private void EndProgram()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        
    }
}
