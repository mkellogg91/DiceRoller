using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace DiceRoller
{
    
    public class Dice
    {
        public int numOfSides { get; set; } 
        public int rollValue { get; set; }
        public static Random rnd = new Random();

        public Int32 rollDice(int sides)
        {
            
            int result = rnd.Next(1, (sides + 1));      //generating a random number between 1 and 6
            return result;
        }

    }
}