using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game game = new Game();

        }
    }

    public class Checker
    {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }

        public Checker(string color, int[] position)
        {
            // Your code here
            this.Color = color;
            this.Position = position;

            int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            string openCircle = char.ConvertFromUtf32(openCircleId);
            int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            string closedCircle = char.ConvertFromUtf32(closedCircleId);


            if (color == "white")
            {
                Symbol = closedCircle;
            }
            else if (color == "black")
            {
                Symbol = openCircle;
            }
        }



    }

    public class Board
    {
        public string[,] Grid { get; set; }
        public List<Checker> Checkers { get; set; }

        public Board()
        {
            Checkers = new List<Checker>();
            Grid = new string[9, 9];
        }

        public void CreateBoard()
        {
            // Your code here
            return;
        }

        public void GenerateBoard()
        {
            return;
        }

        public void GenerateCheckers()
        {
            // Your code here
            for (int i = 1; i < 8; i += 2)
            {
                Checker check = new Checker("white", new int[] { 0, i });
                Checker checkee = new Checker("white", new int[] { 2, i });
                Checkers.Add(check);
                Checkers.Add(checkee);
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker check = new Checker("white", new int[] { 1, i });
                Checkers.Add(check);
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker check = new Checker("black", new int[] { 5, i });
                Checker checkee = new Checker("black", new int[] { 7, i });
                Checkers.Add(check);
                Checkers.Add(checkee);
            }
            for (int i = 1; i < 8; i += 2)
            {
                Checker check = new Checker("black", new int[] { 6, i });
                Checkers.Add(check);
            }




            return;
        }

        public void PlaceCheckers()
        {
            // Your code here
            System.Console.WriteLine("Enter Pickup Row");
            int x1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Pickup Column");
            int y1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Placement Row");
            int x2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Placement Column");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Checker check;

            try
            {
                check = SelectChecker(x1, y1);
            }
            catch
            {
                System.Console.WriteLine("No checker in space");
                return;
            }

            int WorB = 0;
            if (check.Color == "white")
            {
                WorB = 1;
            }
            else if (check.Color == "black")
            {
                WorB = -1;
            }

            if (x2 <= 7 && x2 >= 0 && y2 <= 7 && y2 >= 0)
            //Move needs to be within parameters of board
            {
                if (y2 == y1 + 1 || y2 == y1 - 1 && x2 == x1 + WorB)
                {
                    Checker openSpace;
                    openSpace = SelectChecker(x2, y2);
                    check.Position[0] = x2;
                    check.Position[1] = y2;
                    DrawBoard();

                    if (openSpace != null)
                    {
                        if (check.Color == openSpace.Color)
                        {
                            System.Console.WriteLine("Space taken");
                            return;
                        }
                        else if (check.Color != openSpace.Color)
                        {
                            check.Position[0] = (x2 - x1) + x2;
                            check.Position[1] = (y2 - y1) + y2;
                            Checkers.Remove(openSpace);
                            System.Console.WriteLine("Eat the checker!");
                            DrawBoard();

                            return;
                        }

                    }
                    return;
                }
                else
                {
                    DrawBoard();
                    System.Console.WriteLine("Not a legal move, try again.");
                    return;
                }


            }
            else
            {
                DrawBoard();
                System.Console.WriteLine("Outside the board, try again");
                return;
            }



            /* for (var i = 0; i < Checkers.Count; i++)
            {
                int[] position = Checkers[i].Position;
                Grid[position[0], position[1]] = Checkers[i].Symbol;
            }
            return;
            */
        }

        public void DrawBoard()
        {
            System.Console.WriteLine("\t0\t1\t2\t3\t4\t5\t6\t7");
            foreach (Checker check in Checkers)
            {
                int x = check.Position[0];
                int y = check.Position[1];

                Grid[x, y] = check.Symbol;
            }

            for (int i = 0; i < 8; i++)
            {
                System.Console.Write("{0}\t", i);
                for (int j = 0; j < 8; j++)
                {
                    System.Console.Write("{0}\t", Grid[i, j]);
                }
                System.Console.Write("\n");
            }

            return;
        }

        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }

        public void RemoveChecker(int row, int column)
        {
            // Your code here


            return;
        }

        public bool CheckForWin()
        {
            bool isWin = false;
            if (Checkers.All(x => (x.Color == "white") || (x.Color == "None")))
            {
                isWin = true;
            }
            if (Checkers.All(x => (x.Color == "black") || (x.Color == "None")))
            {
                isWin = true;
            }
            return isWin;
            // return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
            // return Checkers.All(x => x.Color == "black") || !Checkers.Exists(x => x.Color == "black");
        }
    }

    class Game
    {
        public Game()
        {
            // Your code here

            Board board = new Board();
            board.GenerateCheckers();
            board.DrawBoard();
            while (!board.CheckForWin())
            {
                board.PlaceCheckers();
            }




        }

    }
}
