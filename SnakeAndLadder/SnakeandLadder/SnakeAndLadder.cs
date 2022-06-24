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
        public void diceRoll()
        {
            int diceNo = random.Next(1, 6);
            switch (random.Next(0, 3))
            {
                case noPlay:
                    playerPosition += 0;
                    break;
                case snake:
                    playerPosition -= diceNo;
                    break;
                case ladder:
                    playerPosition += diceNo;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Dice value of player is {0} with Position at {1}", diceNo, playerPosition);
        }
    }
}
