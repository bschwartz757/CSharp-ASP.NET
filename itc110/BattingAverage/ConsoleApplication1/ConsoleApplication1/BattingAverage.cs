using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BattingAverage
    {
        //fields
        private int hits;
        private int atBats;

        public int AtBats
        {
            get { return atBats; }
            set { atBats = value; }
        }

        public int Hits
        {
            get { return hits; }
            set { hits = value; }
        }
        
        public double CalculateBattingAverage()
        {
            return ((double)AtBats / Hits)*100;
            
        }
    }
}
