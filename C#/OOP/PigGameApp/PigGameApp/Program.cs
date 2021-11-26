using System;

namespace PigGameApp
{
    class Program
    {
        private static int Game_Score = 20;
        private static int Lose_Score = 1;
        private static int Hold_Score = 0;
        private static int Total_Score = 0;
        private static int Turn_Count = 1;
        private static void StartGame()
        {
            int current_score = 0;
            Random rand = new Random();
            Console.WriteLine("Turn:" + Turn_Count);
            while(true)
            {
                Console.WriteLine("Do you want to roll or hold (r/h)?:");
                char uservalue = Convert.ToChar(Console.ReadLine());
                if (uservalue == 'r')
                {
                    int Dice_value = RollDice();
                    Console.WriteLine("Die:" + Dice_value);
                    if (Dice_value == Lose_Score)
                    {
                        current_score = 0;
                        Turn_Count++;
                        Console.WriteLine("Turn is Over......Null Score!!!");
                        break;
                    }
                    else
                    {
                        current_score += Dice_value;
                    }
                }
                else if(uservalue == 'h')
                {
                    int Hold_Value = HoldDice(current_score);
                    if (Hold_Value >= Game_Score)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You have finished it in " + (Turn_Count-1) + "turns");
                        Console.WriteLine("Game Over!!\n");
                        current_score = 0;
                        Total_Score = 0;
                        Turn_Count = 1;
                        Console.WriteLine("\n");

                        break;
                    }
                    break;
                }
                else if(uservalue == 'q')
                {
                    return;
                }
            }
        }
        private static int RollDice()
        {
            Random rand = new Random();
            int Dice_value = rand.Next(1, 7);
            return Dice_value;
        }
        private static int HoldDice(int current_score)
        {
            Total_Score += current_score;
            Console.WriteLine("Score for this turn:" + current_score);
            Console.WriteLine("Total Score:" + Total_Score);
            current_score = 0;
            Turn_Count++;
            return Total_Score;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("We Welcome you to Pig Game:\n");
            while(true)
            {
                StartGame();
            }
            Console.WriteLine(" ");
        }
    }
}
