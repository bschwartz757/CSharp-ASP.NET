using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTipForm
{
    class Tip
    {
        private double mealAmount;
        private double tipPercent;
        const double TaxPercent = .094;

        public double MealAmount
        {
            get { return mealAmount; }
            set { mealAmount = value; }
        }

        public double TipPercent
        {
            get { return tipPercent; }
            set { tipPercent = value; }
        }

        
        public double CalculateTip()
                {
                    return(MealAmount*TipPercent);
                }
        public double CalculateTaxAmount()
                {
                    return (MealAmount * TaxPercent);
                }
        public double CalculateTotalAmount()
        {
            return ((MealAmount * TaxPercent) + (MealAmount * TipPercent) + MealAmount);
        }
        
    }
}
