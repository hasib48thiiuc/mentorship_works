using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    public class EightSidedDice:Dice
    {
        public EightSidedDice()
        {
            Sides = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Sides[i] = i + 1;
            }
        }

        public override void Roll()
        {
            Console.WriteLine("Rolling logic for 8 sided dice");
        }
    }
}
