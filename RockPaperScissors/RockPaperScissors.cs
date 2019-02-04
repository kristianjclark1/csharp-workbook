using System;

namespace RockPaperScissors
{
    class Program
    {
        public static int count = 0;
        public static int count1 = 0;

        public static void Main()
        {

            string user = System.String.Empty;
            string comp = System.String.Empty;
            Random rnd = new Random();
            int compChoice = rnd.Next(1, 4);

            Console.WriteLine("Welcome to RockPaperScissors game");
            Console.WriteLine("Enter hand 1: ");
            user = Console.ReadLine().ToLower();
            if (compChoice == 1)
            {
                comp = "rock";
            }

            else if (compChoice == 2)
            {
                comp = "paper";
            }
            else if (compChoice == 3)
            {
                comp = "scissors";
            }

            Console.WriteLine("Computer has chosen: {0}", comp);
            Console.WriteLine(CompareHands(user, comp));
            Console.WriteLine("User wins " + count + " times");
            Console.WriteLine("Computer wins " + count1 + " times");
            Replay();






            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }


        public static string CompareHands(string user, string comp)
        {



            if (user == comp)
            {
                return "It's a tie!";

            }

            if (user == "rock")
            {
                //if hand1 picks rock and hand2 picks scissors, rock wins
                if (comp == "scissors")
                {
                    count++;
                    return "User wins";
                }

                else
                {
                    count1++;
                    return "Comp wins";

                }

            }
            if (user == "paper")
            {
                if (comp == "rock")
                {
                    count++;
                    return "User wins";

                }

                else
                {
                    count1++;
                    return "Comp wins";

                }
            }
            if (user == "scissors")
            {
                if (comp == "paper")
                {
                    count++;
                    return "User wins";
                    ;
                }

                else
                {
                    count1++;
                    return "Comp wins";

                }
            }







            // if  (player1 = rock)
            //     {
            //         Console.WriteLine("Player1 chooses rock");

            //     }

            // else if (player1 = paper)
            //     {
            //         Console.WriteLine("Player1 chooses paper");

            //     }

            // else if (player1 = scissors)
            //   {
            //       Console.WriteLine("Player1 chooses scissors");

            // if (player2 = rock) 
            // {
            //     Console.WriteLine("Player2 chooses rock");
            // }

            // else if (player2 = paper)
            // {
            //     Console.WriteLine("Player2 chooses paper");

            // }

            // else if (player2 = scissors)
            // {
            //     Console.WriteLine("Player2 chooses scissors");
            // }

            // Your code here

            return user + ' ' + comp;

        }

        //replay
        public static void Replay()
        {
            System.Console.WriteLine("Do you want to play again(y/n):");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Main();
            }

            else
            {
                System.Console.WriteLine("Thanks for playing.");
            }

        }

    }
}




