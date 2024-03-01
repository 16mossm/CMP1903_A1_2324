using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        Die[] rolls; // the dice that the game rolls
        int DiceRolled = -1;    // the index of the last dice rolled (for the continuous rolling)

        /// <summary>
        /// rolles the specified ammount of dice.
        /// </summary>
        /// <param name="ammountOfRolls">the ammount of dice rolled</param>
        /// <param name="dieSize">the maxSize of each of the dice</param>
        public Game(int ammountOfRolls = 3, int dieSize = 6)  
        {
            this.rolls = new Die[ammountOfRolls];
            for(int i = 0; i < ammountOfRolls; i++)
            {
                this.rolls[i] = new Die(dieSize);   //initialise all of the dice
            }
        }

        /// <summary>
        ///rolls the next available die.
        ///throws exception if all available dice have been rolled
        /// </summary>
        /// <returns>the value of the die rolled</returns>
        public int RollNext()   //rolls the next available dice;
        {
            try
            {
                this.rollDice(++DiceRolled);    //rolls the next dice
                return this.rolls[DiceRolled].GetValue();   //returnes the value
            }
            catch (IndexOutOfRangeException)
            {
                //this happens if all of the dice have already been rolled;
                throw new Exception("all dice already rolled");
            }
        }

        /// <summary>
        /// adds the values of all dice
        /// </summary>
        /// <returns>the sum of all dice</returns>
        public int GetSum() //returns the sum of all dice
        {
            int total = 0;
            for (int i = 0; i < this.rolls.Length; i++)  
            {
                total = total + this.GetRoll(i);
            }
            return total;
        }

        /// <summary>
        /// rolles the specified die rolls all if -1 is given
        /// </summary>
        /// <param name="die">the die to roll, rolls all if -1</param>
        public void rollDice(int die = -1)   //rolles specified die. if -1 it rolls all of them
        {
            this.DiceRolled = this.rolls.Length;    //disables the continuous rolls function.
            if (die == -1)
            {
                for(int i = 0; i < this.rolls.Length; i++)  //if -1 roll all of the dice
                {
                    this.rolls[i].Roll();
                    
                }
                return;
            }
                
            if (die < 0 || die >= this.rolls.Length)    // if out of range throw an exeption
            {
                throw new IndexOutOfRangeException("index out of range");
            }

            this.rolls[die].Roll();     //roll the specified die
        }

        /// <summary>
        /// gets the value of the specified die
        /// </summary>
        /// <param name="index">the die to get the value of</param>
        /// <returns>the value of the specified die</returns>
        public int GetRoll(int index)
        {
            if(index < 0 || index >= this.rolls.Length)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
            return this.rolls[index].GetValue();    //returns the value of the dice specified.
        }

    }
}
