using System;

namespace TextBasedGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            int complete = 0;
            bool alive = true;
            while (alive == true)
            {



                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("Welcome to the cavern of secrets!");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                Console.WriteLine("You enter a dark cavern out of curiosity." +
                "It is dark and you can only make out a small stick on the floor.Do you take it? [y/n]: ");
                string ch1 = Console.ReadLine();

                //Stick taken`
                int stick = 0;
                if (ch1 == "y")
                {
                    System.Console.WriteLine("You have taken the stick!");
                    System.Threading.Thread.Sleep(2000);
                    stick = 1;
                }

                //Stick not takens
                else if (ch1 == "n")
                {
                    Console.WriteLine("You did not take the stick");
                    stick = 0;

                }

                Console.WriteLine("As you proceed further into the cave, you see a small glowing object Do you approach the object? [y/n]");
                string ch2 = Console.ReadLine();

                //Approach object
                if (ch2 == "y")
                {
                    System.Console.WriteLine("You approach the object");
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("The eye belongs to a giant spider! Do you try to fight it? [Y/N]");

                }
                string ch3 = Console.ReadLine();
                //Fight spider
                if (ch3 == "Y")
                {
                    //With stick
                    if (stick == 1)
                    {
                        System.Console.WriteLine("You only have a stick to fight with! You quickly jab the spider in it's eye and gain an advantage");
                        System.Threading.Thread.Sleep(2000);
                        System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        System.Console.WriteLine("                  Fighting...                   ");
                        System.Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                        System.Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                        System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        System.Threading.Thread.Sleep(2000);
                        Random rnd = new Random();
                        int fdmg1 = rnd.Next(3, 10);
                        int edmg1 = rnd.Next(1, 5);
                        System.Console.WriteLine("you hit a " + fdmg1);
                        System.Console.WriteLine("the spider hits a " + edmg1);
                        System.Threading.Thread.Sleep(1000);
                        if (edmg1 > fdmg1)
                        {
                            System.Console.WriteLine("The spider has dealt more damage than you!");
                            complete = 0;
                            //return complete;
                        }
                        else if (fdmg1 < 5)
                        {
                            System.Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                            complete = 1;
                            //return complete;
                        }
                        else
                        {
                            System.Console.WriteLine("You killed the spider!");
                            complete = 1;
                            //return complete;
                        }
                    }
                    //Without stick
                    else
                    {
                        System.Console.WriteLine("You don't have anything to fight with!");
                        System.Threading.Thread.Sleep(2000);
                        System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        System.Console.WriteLine("                  Fighting...                   ");
                        System.Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                        System.Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                        System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        System.Threading.Thread.Sleep(2000);
                        Random rnd = new Random();
                        int fdmg2 = rnd.Next(1, 8);
                        int edmg2 = rnd.Next(1, 5);
                        System.Console.WriteLine("you hit a " + fdmg2);
                        System.Console.WriteLine("the spider hits a " + edmg2);
                        System.Threading.Thread.Sleep(2000);
                        if (edmg2 > fdmg2)
                        {
                            System.Console.WriteLine("The spider has dealt more damage than you!");
                            complete = 0;
                            //return complete;
                        }
                        else if (fdmg2 < 5)
                        {
                            System.Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                            complete = 1;
                            //return complete;
                        }
                        else
                        {
                            System.Console.WriteLine("You killed the spider!");
                            complete = 1;
                            //return complete;
                        }
                    }
                }
                //Do Not Fight Spider
                else if (ch3 == "N")
                {
                    System.Console.WriteLine("You choose not to fight the spider.");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!!!");
                    complete = 0;
                    //return complete
                }

                //Do not approach object
                else if (ch2 == "n")
                {
                    System.Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave...");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("But something won't let you....");
                    System.Threading.Thread.Sleep(2000);
                    complete = 0;
                    //return complete

                }
                //The end//
                if (complete == 1)
                {
                    Console.WriteLine("You managed to escape the cavern alive! Would you like to play again? [y/n]: ");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        alive = true;
                    }
                    else if (choice == "n")
                    {
                        alive = false;
                    }
                }
                else
                {
                    Console.WriteLine("You have died! Would you like to play again? [y/n]: ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "y")
                    {
                        alive = true;
                    }
                    else
                    {
                        alive = false;
                    }

                }

            }






        }






    }


}

