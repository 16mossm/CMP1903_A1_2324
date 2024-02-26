using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        
        private int value;      //current value 
        private int maxValue;   // the maximum value the dice can be 

        
        public int roll()
        {
            Random rd = new Random();
            this.value = rd.Next(1, maxValue + 1); // lowwer bound is inclusive; upper bound is exclusive 
            return this.value;
        }

        public int getValue() {
            return this.value;
        }


        public Die(int maxValue = 6)    //made an initaliser so that the class is more adaptable 
        {
            if(maxValue < 1)    //dice cannot have less than 1 side
            {
                throw new ArgumentOutOfRangeException("should be 1 or higher"); //throws error
            }
            this.maxValue = maxValue;
        }

    }
}
