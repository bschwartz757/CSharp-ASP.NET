using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileageFormWPF
{
    class Mileage
    {
        public double Distance { get; set; }
        public double Gallons {get;set;}
        public double PricePerGallon {get;set;}

       public double CalculateMileage()
        {
            return PricePerGallon * Gallons;
        }

        public double CalculatePricePerMile()
       {
           return CalculateMileage() / Distance;
       }
    }
}
