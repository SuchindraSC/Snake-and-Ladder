using System;

namespace Snake_and_Ladder_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int START_POSITION = 0;
            Random rand = new Random();
            int DICE_ROLL = rand.Next(1, 7);
            int OPTIONS = rand.Next(0, 3);
            int stepsMoved = 0;
            switch (OPTIONS)
            {
                case 0:
                    Console.WriteLine("Player is at same position ");
                    break;
                case 1:
                    stepsMoved += DICE_ROLL;
                    Console.WriteLine("Player Moved by "+stepsMoved+" steps");
                    break;
                case 2:
                    stepsMoved += DICE_ROLL;
                    if (stepsMoved == 25 || stepsMoved == 51)
                    {
                        stepsMoved = 10;
                        Console.WriteLine("Player Moved Down To Position "+stepsMoved);
                    }
                    else if (stepsMoved == 60)
                    {
                        stepsMoved = 28;
                        Console.WriteLine("Player Moved Down To Position "+stepsMoved);
                    }
                    else if (stepsMoved == 55 || stepsMoved == 80)
                    {
                        stepsMoved = 21;
                        Console.WriteLine("Player Moved Down To Position "+stepsMoved);
                    }
                    else if (stepsMoved == 99)
                    {
                        stepsMoved = 2;
                        Console.WriteLine("Player Moved Down To Position "+stepsMoved);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
