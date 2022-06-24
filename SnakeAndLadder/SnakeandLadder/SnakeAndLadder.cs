// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class SnakeAndLadder
    {
        int diceNo, inc = 0, playerPosition = 0;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();

        public int DiceRoll()
        {
            diceNo = random.Next(1, 6);
            inc++;
            return diceNo;
        }
        public void diceRollGame()
        {
            while (playerPosition < 100)
            {
                switch (random.Next(0, 3))
                {
                    case noPlay:
                        playerPosition += 0;
                        Console.WriteLine("Player got noPlay Option");
                        break;
                    case snake:
                        playerPosition -= DiceRoll();
                        break;
                    case ladder:
                        playerPosition += DiceRoll();
                        break;
                    default:
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                if (playerPosition > 100)
                {
                    Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n", inc, playerPosition);
                    playerPosition -= diceNo;
                    while (playerPosition < 100)
                    {
                        if (DiceRoll() == (100 - playerPosition))
                        {
                            playerPosition = 100;
                            Console.WriteLine("Player Won the Game");
                        }
                        else
                        {
                            Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n", inc, playerPosition);
                            continue;
                        }
                    }
                }
                Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n", inc, playerPosition);
            }
        }
    }
}


