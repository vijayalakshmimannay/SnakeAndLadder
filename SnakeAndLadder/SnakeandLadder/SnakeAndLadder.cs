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
        public int startPosition = 0, playerPosition = 0;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();

        public int diceRoll()
        {
            int diceNo = random.Next(1, 6);
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
                }
            }
            Console.WriteLine("Player Position is at {0}", playerPosition);
        }
    }
}
