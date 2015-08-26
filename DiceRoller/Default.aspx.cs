using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiceRoller
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            Dice die1 = new Dice();
            Dice die2 = new Dice();
                
                //calculating the values of the dice rolls
            die1.rollValue = die1.rollDice(6);
            die2.rollValue = die2.rollDice(6);

            die2.rollValue = die2.rollDice(6);

            rand1.Text = Convert.ToString(die1.rollValue);
            rand2.Text = Convert.ToString(die2.rollValue);
        }
    }
}