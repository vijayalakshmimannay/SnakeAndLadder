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
        public int diceNo, diceRollTimes = 0, playerPosition = 0;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();
        public int DiceRoll()
        {
            diceNo = random.Next(1, 6);
            diceRollTimes++;
            return diceNo;
        }
        public void DiceRollGame()
        {
            while (playerPosition < 100)
            {
            repeat:
                int value = random.Next(3);
                switch (value)
                {
                    case noPlay:
                        playerPosition += 0;
                        //Console.WriteLine("Player got noPlay Option");
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
                    //Console.WriteLine("Player reached {0} position with dice turns {1}",playerPosition,diceRollTimes);
                }
                if (playerPosition > 100)
                {
                    playerPosition -= diceNo;
                    //Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n", diceRollTimes, playerPosition);
                    while (playerPosition < 100)
                    {
                        if (DiceRoll() == (100 - playerPosition))
                        {
                            playerPosition = 100;
                            //Console.WriteLine("Player Won the Game");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (value == ladder)
                {
                    if (playerPosition != 100)
                    {
                        //Console.WriteLine("-----");
                        //Console.WriteLine("Player got ladder, rolls the dice again");
                        goto repeat;
                    }
                }
                //Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n",diceRollTimes,playerPosition);
            }
        }
    }

}

