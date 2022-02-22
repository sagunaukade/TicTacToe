
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display welcome message
            Console.WriteLine("Welcome to the tictactoe game");
            //UC-1
            TicTacToe.CreateBoard();
            Console.ReadLine();
        }
    }
}
