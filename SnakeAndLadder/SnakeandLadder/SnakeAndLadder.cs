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
        int diceNo, playerPosition = 0;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();

        public int diceRoll()
        {
            diceNo = random.Next(1, 6);
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
                        break;
                    case snake:
                        playerPosition -= diceRoll();
                        break;
                    case ladder:
                        playerPosition += diceRoll();
                        break;
                    default:
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("Player Present Position is at " + playerPosition);
                }
                if (playerPosition > 100)
                {
                    playerPosition -= diceNo;
                    while (playerPosition < 100)
                    {
                        if (diceRoll() == (100 - playerPosition))
                        {
                            playerPosition = 100;
                            Console.WriteLine("Player Won the Game");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("Player Present Position is at {0}\n", playerPosition);
            }
        }
    }
}

