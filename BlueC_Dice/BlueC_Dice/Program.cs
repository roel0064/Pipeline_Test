﻿using System;

namespace BlueC_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dobbelsteen = new Dice();

            while (true)
            {
                dobbelsteen.Roll();

                int waarde = dobbelsteen.GetValue();

                Console.WriteLine(waarde);
                Console.ReadLine();
            }
        }
    }
}
