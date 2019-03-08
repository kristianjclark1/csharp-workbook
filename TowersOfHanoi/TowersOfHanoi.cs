using System;
using System.Collections;
using System.Collections.Generic;


namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            bool win = false;

            do
            {
                //Hasn't won yet
                game.AskMove();
                game.PrintBoard();
                win = game.CheckForWin();
            }
            while (!win);


            // game.PrintBoard();
            // game.AskMove();
            // game.PrintBoard();
            // game.AskMove();
        }
    }
    class Block
    {
        public int Weight { get; private set; }
        public Block(int weight)
        {
            this.Weight = weight;
        }

    }

    class Tower
    {
        public string Towers { get; set; }
        public Stack<Block> blocks = new Stack<Block>();
        public Tower(Stack<Block> block)
        {
            this.blocks = block;
        }

    }

    class Game
    {
        Block stack1 = new Block(4);
        Dictionary<string, Tower> towers = new Dictionary<string, Tower>();
        public Game()
        {
            Tower towerA = new Tower(new Stack<Block>());
            Tower towerB = new Tower(new Stack<Block>());
            Tower towerC = new Tower(new Stack<Block>());
            towers["A"] = towerA;
            towers["B"] = towerB;
            towers["C"] = towerC;
            towerA.blocks.Push(new Block(4));
            towerA.blocks.Push(new Block(3));
            towerA.blocks.Push(new Block(2));
            towerA.blocks.Push(new Block(1));
        }
        public void PrintBoard()
        {
            foreach (KeyValuePair<string, Tower> item in towers)
            {
                string blocks = "";
                foreach (Block block in item.Value.blocks)
                {
                    blocks += block.Weight.ToString();
                }
                System.Console.WriteLine(item.Key + "|" + blocks);

            }

        }

        public static bool IsLegal(Tower from, Tower to)
        {
            Block popOff = from.blocks.Peek();
            Block pushOn = to.blocks.Peek();

            if (pushOn == null)
            {
                return true;
            }
            else if (popOff.Weight < pushOn.Weight)
            {
                return true;
            }
            else
                return false;
        }
        public void MovePiece(Tower from, Tower to)
        { //2.Popoff the piece from the From Tower
          //3.Push block on to To Tower
            Block lastBlock = from.blocks.Pop();
            to.blocks.Push(lastBlock);


        }

        public void AskMove()
        {
            System.Console.WriteLine("Which tower you do want to move from?");
            string fromTower = Console.ReadLine();
            System.Console.WriteLine("Which tower do you want to move to?");
            string toTower = Console.ReadLine();
            MovePiece(towers[fromTower], towers[toTower]);
        }

        public bool CheckForWin()
        {
            if (towers["B"].blocks.Count == 4 || towers["C"].blocks.Count == 4)
            {
                System.Console.WriteLine("You Won!");
                return true;
            }
            else
                return false;

        }













    }



}



