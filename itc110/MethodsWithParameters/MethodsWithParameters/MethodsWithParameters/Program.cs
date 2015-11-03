using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithParameters
{
    class Program
    {
        // This is about Methods with Parameters 10/15/2014
        // SCOPE: by putting this in the Class space, it is available to the entire program (not just a particular Method.)
        private const double PI = 3.14156;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetDiameter();
            p.EndProgram();
        }

        private void GetDiameter()
        {
            Console.WriteLine("Please give the diameter of your circle");
            double diameter = double.Parse(Console.ReadLine());

            GetCircumference(diameter);
        }

        private double GetCircumference(double diameter)
        {
            double circumference = diameter * PI;
            Display(circumference);
        }

        private void Display(double circ)
        {
            Console.WriteLine("the circumference is" + circ);
        }


    } // End Class
}
