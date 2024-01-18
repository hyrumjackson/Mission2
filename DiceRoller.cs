using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {

        public int[] RollDice(int numDiceRolls)
        {
            //Declare variables
            int die1 = 0, die2 = 0;
            int[] diceRollArray = new int[numDiceRolls];

            //Create a Random instance
            Random random = new Random();

            //For loop to roll dice and place value in array
            for (int i = 0; i < numDiceRolls; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);

                diceRollArray[i] = die1 + die2;
            }

            return diceRollArray;
        }
    }
}
