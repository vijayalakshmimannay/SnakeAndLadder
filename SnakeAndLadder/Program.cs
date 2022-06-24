// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome Snake and Ladder");
SnakeandLadder.SnakeAndLadder player1 = new SnakeandLadder.SnakeAndLadder();
SnakeandLadder.SnakeAndLadder player2 = new SnakeandLadder.SnakeAndLadder();
player1.DiceRollGame();
Console.WriteLine("Player 1 rolls {0} times to get winner position {1}", player1.diceRollTimes, player1.playerPosition);
player2.DiceRollGame();
Console.WriteLine("Player 2 rolls {0} times to get winner position {1}", player2.diceRollTimes, player2.playerPosition);
if (player1.diceRollTimes > player2.diceRollTimes)
{
    Console.WriteLine("Player 2 won with {0} turns", player2.diceRollTimes);
}
else if (player2.diceRollTimes > player1.diceRollTimes)
{
    Console.WriteLine("Player 1 won with {0} turns", player1.diceRollTimes);
}
else
{
    Console.WriteLine("Equal turns {0} and {1}", player1.diceRollTimes, player2.diceRollTimes);
}