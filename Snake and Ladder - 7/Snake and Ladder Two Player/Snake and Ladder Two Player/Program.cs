using System;

namespace Snake_and_Ladder_Two_Player
{
    class Program
    {
       
            static void Main(string[] args)
            {
                int position = 0;
                int position2 = 0;
                int i = 0;
                Random rand = new Random();
                while (position != 100 && position2 != 100)
                {

                    ++i;
                    int diceRoll = rand.Next(1, 7);
                    int diceRoll2 = rand.Next(1, 7);
                    int snakeLadder = rand.Next(1, 4);
                    int snakeLadder2 = rand.Next(1, 4);
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
                    switch (snakeLadder2)
                    {
                        case 2:
                            Console.WriteLine("the  value of diceRoll2 is " + diceRoll2);
                            Console.WriteLine("the  value of snakeLadder2 is " + snakeLadder2);
                            position2 += diceRoll2;
                            Console.WriteLine("the  present position of 1st person  is " + position2);
                            break;
                        case 3:
                            Console.WriteLine("the  value of diceRoll2 is " + diceRoll2);
                            Console.WriteLine("the  value of snakeLadder2 is " + snakeLadder2);
                            position2 -= diceRoll2;
                            if (position2 < 0)
                            {
                                position2 = 0;
                            }
                            Console.WriteLine("the  present position of 2nd person  is " + position2);
                            break;
                        default:
                            position2 += 0;
                            Console.WriteLine("the value is " + position2);
                            break;
                    }
                    Console.WriteLine("the point of 1 person is " + position);
                    Console.WriteLine("the point of 2 person is " + position2);
                }
                Console.WriteLine("the number of times loop formed " + i);

                if (position == 100)
                {
                    Console.WriteLine("person 1 is the winner");
                }
                else
                {
                    Console.WriteLine("person 2 is the winner");
                }
            }
        
    }
}
