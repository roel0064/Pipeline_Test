using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Dice
{
    public class Dice
    {
        private int Waarde;
        private int AantalVlakken;
        private Random Rand;

        public Dice()
        {
            this.Waarde = 2;
            AantalVlakken = 6;
            this.Rand = new Random();
        }

        public void Roll()
        {
            int next = this.Rand.Next(1, 99);
            this.Waarde += next;
        }

        public int GetValue()
        {
            return (Waarde % AantalVlakken) + 1;
        }

        public override string ToString()
        {
            string[] displaynumbers = new string[]
            {
                $" ----- "
              + " |1  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |o  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |3  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |4  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |5  |"
              + " |   |"
              + " |  o|"
              + " -----",

                " ----- "
              + " |o o|"
              + " |o o|"
              + " |o o|"
              + " -----"
            };

            int index = this.GetValue() - 1;

            return displaynumbers[index];
        }
    }
}

