using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Ball
    {
        public string Letter { get; private set; }

        public Ball(string letter)
        {
            this.Letter = letter;
        }
    }

    class Row
    {
        public Ball[] balls = new Ball[4];

        public Row(Ball[] balls)
        {
            this.balls = balls;
        }

        public string Balls
        {
            get
            {
                foreach (var ball in this.balls)
                {
                    Console.Write(ball.Letter);
                }
                return "";
            }
        }


    }
    class Game
    {
        public List<Row> rows = new List<Row>();
        private string[] answer = new string[4];
        public string[] GenerateRandomCode = new string[4];


        public int tries;

        public Game(string[] answer, int tries)
        {
            this.answer = answer;
            this.tries = tries;

        }

        public string Score(Row row)
        {
            string[] answerClone = (string[])this.answer.Clone();
            // red is correct letter and correct position
            // white is correct letters minus red
            // this.answer => ["a", "b", "c", "d"]
            // row.balls => [{ Letter: "c" }, { Letter: "b" }, { Letter: "d" }, { Letter: "a" }]
            int red = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerClone[i] == row.balls[i].Letter)
                {
                    red++;
                }
            }
            int white = 0;
            for (int i = 0; i < 4; i++)
            {
                int foundIndex = Array.IndexOf(answerClone, row.balls[i].Letter);
                if (foundIndex > -1)
                {
                    white++;
                    answerClone[foundIndex] = null;
                }
            }
            return $" {red} - {white - red}";
        }
        public void AddRow(Row row)
        {
            this.rows.Add(row);
        }

        public string Rows
        {
            get
            {
                foreach (var row in this.rows)
                {
                    Console.Write(row.Balls);
                    Console.WriteLine(Score(row));
                }
                return "";
            }
        }

    }
    class Program
    {
        public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };


        public static void Main(string[] args)
        {

            bool win = false;
            string[] GenerateRandomCode()
            {
                string[] solution = new string[4];
                Random rnd = new Random();
                for (var i = 0; i < 4; i++)
                {
                    solution[i] = (letters[rnd.Next(0, letters.Length)]).ToString();
                }
                return solution;
            }
            Game game = new Game(GenerateRandomCode(), 10);
            for (int turns = 10; turns > 0; turns--)
            {
                Console.WriteLine("You have {0} tries left", turns);
                Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball(letters[i].ToString());
                }
                Row row = new Row(balls);
                game.AddRow(row);
                Console.WriteLine(game.Rows);
                if (game.Score(row) == " 4 - 0")
                {
                    System.Console.WriteLine("You win");
                    win = true;
                    break;
                }

            }
            if (win == false)
            {
                Console.WriteLine("Out Of Turns");
            }

        }







    }
}

