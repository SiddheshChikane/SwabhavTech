
using System;
namespace Numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int rn= Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 to 100:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < rn)
                    {
                        Console.WriteLine("Sorry. The Number is too Low.");
                        ++count;
                        continue;
                    }
                    else if (input > rn)
                    {
                        Console.WriteLine("Sorry. The Number is too High.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it right. The number is {0}",
                                           rn);
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
                Console.WriteLine("Do you wanna play again?(y/n):");
                char s = Convert.ToChar(Console.ReadLine());
                if (s=='y')
                {
                    continue;
                }
                else
                {
                    break;
                }
                Console.ReadLine();
            }

        }
        
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
