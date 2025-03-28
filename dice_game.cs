using System;


namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum, enemyRandomNum;
            int playerPoint = 0,enemyPoint = 0;
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();

                playerRandomNum = rand.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = rand.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoint++;
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoint++;
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("The score is now - Player " + playerPoint + " Enemy: " + enemyPoint);
                Console.WriteLine();
            }

            if (playerPoint > enemyPoint)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoint < enemyPoint)
            {
                Console.WriteLine("You lose(");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
