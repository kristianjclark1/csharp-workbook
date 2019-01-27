using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {

            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());





            // leave this command at the end so your program does not close automatically
            //Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
            CheckForWin();
            CheckForTie();
            playerTurn = (playerTurn == "X") ? "O" : "X";

        }

        public static void PlaceMark(int row, int column)
        {

            //string[] myRow = board[row];
            //string myColumn = myRow[column];
            //myRow[column] = "X";
            board[row][column] = playerTurn;






            // your code goes here
        }

        public static bool CheckForWin()
        { // your code goes here

            if (HorizontalWin() || VerticalWin() || DiagonalWin() == true)
            {
                Console.WriteLine("Player " + playerTurn + " Won!");
                Environment.Exit(0);
            }
            return false;


        }

        public static bool CheckForTie()
        {
            if (board[0][0] != " " && board[0][1] != " " && board[0][2] != " " && board[1][0] != " " &&
            board[1][1] != " " && board[1][2] != " " && board[2][0] != " " && board[2][1] != " " &&
            board[2][2] != " ")
            {
                Console.WriteLine("It's a tie!");
                return true;
            }
            else
            {
                return false;
            }


            // your code goes here


        }

        public static bool HorizontalWin()
        {




            // your code goes here
            if ((board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn) ||
              (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn) ||
             (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static bool VerticalWin()
        {


            // your code goes here
            if ((board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn) ||
             (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn) ||
             (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool DiagonalWin()
        {
            // your code goes here
            if ((board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn) ||
             (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
