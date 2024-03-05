using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {

        public void testGame()  //calls debug.assert to ensure that the code is working correctly
        {
            Game gam = new Game(3, 6);  //create a new game of 3 dice with 6 sides each
            gam.rollDice(); //roll all of the dice in the game
            for(int i = 0; i < 3; i++)
            {
                Debug.Assert(gam.GetRoll(i) >= 1 && gam.GetRoll(i) <= 6, "dice rolls must be between 1 and 6");
            }
            Debug.Assert(gam.GetSum() == gam.GetRoll(0) + gam.GetRoll(1) + gam.GetRoll(2), "sum must be the total of all the dice");


        }


    }
}
