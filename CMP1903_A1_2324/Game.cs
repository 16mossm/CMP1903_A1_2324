﻿using System;
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

        public Game(int ammountOfRolls = 3, int dieSize = 6)  
        {
            this.rolls = new Die[ammountOfRolls];
            for(int i = 0; i < ammountOfRolls; i++)
            {
                this.rolls[i] = new Die(dieSize);   //initialise all of the dice
            }
        }

        public int RollNext()   //rolls the next available dice;
        {
            try
            {
                this.rollDice(++DiceRolled);    //rolls the next dice
                return this.rolls[DiceRolled].getValue();   //returnes the value
            }
            catch (IndexOutOfRangeException)
            {
                //this happens if all of the dice have already been rolled;
                throw new Exception("all dice already rolled");
            }
        }

        public int GetSum() //returns the sum of all dice
        {
            int total = 0;
            for (int i = 0; i < this.rolls.Length; i++)  //if -1 roll all of the dice
            {
                total = total + this.GetRoll(i);
            }
            return total;
        }

        public void rollDice(int die = -1)   //rolles specified die. if -1 it rolls all of them
        {
            this.DiceRolled = this.rolls.Length;    //disables the continuous rolls function.
            if (die == -1)
            {
                for(int i = 0; i < this.rolls.Length; i++)  //if -1 roll all of the dice
                {
                    this.rolls[i].roll();
                    
                }
                return;
            }
                
            if (die < 0 || die >= this.rolls.Length)    // if out of range throw an exeption
            {
                throw new IndexOutOfRangeException("index out of range");
            }

            this.rolls[die].roll();     //roll the specified die
        }


        public int GetRoll(int index)
        {
            if(index < 0 || index >= this.rolls.Length)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
            return this.rolls[index].getValue();    //returns the value of the dice specified.
        }

    }
}
