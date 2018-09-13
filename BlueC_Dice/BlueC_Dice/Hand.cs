using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Hand
    {
        private Dice Dice1;
        private Dice Dice2;
        private Dice Dice3;
        private Dice Dice4;
        private Dice Dice5;
        private Dice Dice6;

        public Hand()
        {
            this.Dice1 = new Dice();
            this.Dice2 = new Dice();
            this.Dice3 = new Dice();
            this.Dice4 = new Dice();
            this.Dice5 = new Dice();
            this.Dice6 = new Dice();
        }

        public void Werp()
        {
            this.Dice1.Roll();
            this.Dice2.Roll();
            this.Dice3.Roll();
            this.Dice4.Roll();
            this.Dice5.Roll();
            this.Dice6.Roll();
        }

        public int GetValue()
        {
            int value = this.Dice1.GetValue()
                + this.Dice2.GetValue()
                + this.Dice3.GetValue()
                + this.Dice4.GetValue()
                + this.Dice5.GetValue()
                + this.Dice6.GetValue();
            return value;
        }
    }
}
