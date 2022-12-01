using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRolling();
            playerOne.PlayerCheck();
            Console.ReadLine();
        }
    }
}