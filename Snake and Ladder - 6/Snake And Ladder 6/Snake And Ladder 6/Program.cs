﻿using System;

namespace Snake_And_Ladder_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int i = 0;
            Random rand = new Random();
            while (position != 100)
            {
                ++i;
                int diceRoll = rand.Next(1, 7);
                int snakeLadder = rand.Next(1, 4);
                switch (snakeLadder)
                {
                    case 2:
                        Console.WriteLine("the  value of diceRoll is " + diceRoll);
                        Console.WriteLine("the  value of snakeLadder is " + snakeLadder);
                        position += diceRoll;
                        Console.WriteLine("the  present position of 1st person  is " + position);
                        break;
                    case 3:
                        Console.WriteLine("the  value of diceRoll is " + diceRoll);
                        Console.WriteLine("the  value of snakeLadder is " + snakeLadder);
                        position -= diceRoll;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("the  present position of 1st person  is " + position);
                        break;
                    default:
                        position += 0;
                        Console.WriteLine("the value is " + position);
                        break;
                }
                Console.WriteLine("The Position of the Player is " + position);
            }
            Console.WriteLine("As Player Reaches 100 Player Wins");
            Console.WriteLine("the number of times loop formed " + i);

        }
    }
}
