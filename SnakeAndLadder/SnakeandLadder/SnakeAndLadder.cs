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
        int startPosition = 0, playerPosition = 0;
        public void Position()
        {
            Console.WriteLine("Initial position of player is " + playerPosition);
        }
    }
}
