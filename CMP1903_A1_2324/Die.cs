using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int value;

        //Method
        public int roll()
        {
            Random rd = new Random();
            this.value = rd.Next(1, 7); // lowwer bound is inclusive; upper bound is exclusive 
            return this.value;
        }

        public int getValue() {
            return this.value;
        }

    }
}
