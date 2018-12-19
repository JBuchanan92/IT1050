using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            GameBoard.CreateBoard();
            GameBoard.PrintBoard();
            GameBoard.UpdateBoard();
            GameBoard.AskToContinue();

            System.Threading.Thread.Sleep(50000);
        }
    }
    
}
