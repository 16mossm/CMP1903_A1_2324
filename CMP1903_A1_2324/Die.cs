﻿using System;
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

        /// <summary>
        /// rolles the die and gets a value from 1 to maxvalue (inclusive)
        /// </summary>
        /// <returns>the value rolled</returns>
        public int Roll()
        {
            Random rd = new Random();
            this.value = rd.Next(1, maxValue + 1); // lowwer bound is inclusive; upper bound is exclusive 
            return this.value;
        }

        /// <summary>
        /// gets the last value rolled
        /// </summary>
        /// <returns>the last value rolled</returns>
        public int GetValue() {
            return this.value;
        }

        /// <summary>
        /// intialises the class
        /// </summary>
        /// <param name="maxValue">the maximum value that the die can roll</param>
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
