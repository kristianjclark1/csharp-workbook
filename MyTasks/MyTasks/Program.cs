using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyTasks
{
    public enum DoneStatus { undone, In_Progress, done }


    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DoneStatus DoneValue { get; set; }


        public Item() {}

        public Item(string name, string description, DoneStatus doneValue)
        {
            Name = name;
            Description = description;


        }
        class Program
        {


            static void Main(string[] args)
            {
                DbContextOptionsBuilder<ToDoDbContext> builder = new DbContextOptionsBuilder<ToDoDbContext>();
                builder.UseSqlServer("Server=127.0.0.1;Database=TodoDb;User Id=sa;Password=P@ssw0rd;");
                DbContextOptions<ToDoDbContext> opts = builder.Options;
                ToDoDbContext context = new ToDoDbContext(opts);

                context.Database.EnsureCreated();

                Console.WriteLine("Hello World!!");

                IntroScreen();
                ListOfOptions();
                HomeScreen(context);
            }

            public static void HomeScreen(ToDoDbContext toDoContext)
            {
                string value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        AddTheItem(toDoContext);
                        break;
                    case "2":
                        DeleteTheItem(toDoContext);
                        break;
                    case "3":
                        EverythingOnList(toDoContext);
                        Console.WriteLine();
                        Console.WriteLine("What do you want to do?");
                        ListOfOptions();
                        HomeScreen(toDoContext);
                        break;
                    case "4":
                        EverythingOnList(toDoContext);
                        Console.WriteLine();
                        Console.WriteLine("Now what would like to do?");
                        ListOfOptions();
                        HomeScreen(toDoContext);
                        break;
                    case "5":
                        UpdateItemsList(toDoContext);
                        Console.WriteLine();
                        Console.WriteLine("What do you want to do?");
                        ListOfOptions();
                        HomeScreen(toDoContext);
                        break;
                    default:
                        //if user selects choice not from list

                        Console.WriteLine("Please give me a valid entry.");
                        HomeScreen(toDoContext);
                        break;
                }
            }
            public static void IntroScreen()
            {
               //simple prompt to welcome the user to application

                Console.WriteLine("Welcome to your To Do List! Here is your home screen with a list of commands.");
                Console.WriteLine("Entering the following single numbers will execute that command.");
            }
            public static void ListOfOptions()
            {
              //I provide the user a list of options to help navigate the app

                Console.WriteLine("1 - Add an item to your list.");
                Console.WriteLine("2 - Delete an item from your list.");
                Console.WriteLine("3 - List all done and unfinished items.");
                Console.WriteLine("4 - List only unfinished items.");
                Console.WriteLine("5 - Update an item already on your list.");
                Console.WriteLine();
            }
            public static void AddTheItem(ToDoDbContext toDoContext)
            {

                Console.WriteLine("Enter an item name to add to your list.");
                string enterName = Console.ReadLine();
                Console.WriteLine("Please enter a description for the item.");
                string enterDescription = Console.ReadLine();
                Item myItem = new Item(enterName, enterDescription, DoneStatus.undone);
                toDoContext.Things.Add(myItem);
                toDoContext.SaveChanges();
                Console.WriteLine();
                Console.WriteLine("What would you like to do now?");
                ListOfOptions();
                HomeScreen(toDoContext);
            }
             static void DeleteTheItem(ToDoDbContext toDoDbContext)
            {
                //Delete items from list
                Console.WriteLine();
                EverythingOnList(toDoDbContext);
                Console.WriteLine("Delete item from your list");
                Console.WriteLine("Please enter the ID of that item.");
                int idValue = Convert.ToInt32(Console.ReadLine());

                Item placeHoldItem = toDoDbContext.Things.Find(idValue);
                toDoDbContext.Things.Remove(placeHoldItem);
                //removes that selected item
                toDoDbContext.SaveChanges();
                Console.WriteLine();
                Console.WriteLine("What would you like to do now?");
                ListOfOptions();
                HomeScreen(toDoDbContext);

            }
            public static void EverythingOnList(ToDoDbContext toDoContext)
            {
                Console.WriteLine();
                //this method simply lists all things in the list
                var results = from s in toDoContext.Things
                select s;

                foreach (Item s in results)
                {
                    Console.WriteLine(s.Id + " || " + s.Name + " || " + s.Description + " || " + s.DoneValue);
                }

             }
            static void UnfinishedList(ToDoDbContext toDoDbContext)
            {
                Console.WriteLine();
                //this method lists all unfinished items in list

                var results = from s in toDoDbContext.Things
                              where (s.DoneValue == DoneStatus.undone)
                              select s;
                foreach( Item s in results)
                {
                    Console.WriteLine(s.Id + " || " + s.Name + " || " + s.Description + " || " + s.DoneValue);
                }
            }
            static void UpdateItemsList(ToDoDbContext toDoDbContext)
            {
                //Update items on list
                Console.WriteLine();
                EverythingOnList(toDoDbContext);
                Console.WriteLine("Which item would you like to update?");
                Console.WriteLine("Please enter id of that item.");
                int idValue = Convert.ToInt32(Console.ReadLine());
                Item placeHoldItem = toDoDbContext.Things.Find(idValue);

                Console.WriteLine("What do you want to update?");
                Console.WriteLine("Your choices are 'name', 'description', or 'done status'");
                string newUpdate = Console.ReadLine();
                //allows user to select what attribute they want to update

                switch (newUpdate)
                {
                    case "name":
                        {
                            Console.WriteLine("What do you want to rename the item?");
                            string newName = Console.ReadLine();

                            Item itemEntity = toDoDbContext.Things.First(s => s.Name.Equals(placeHoldItem.Name));
                            //puts new name into selected item
                            itemEntity.Name = newName;
                            toDoDbContext.SaveChanges();
                            break;
                        }

                    case "description":
                        {
                            Console.WriteLine("What do you want to rename the description?");
                            string newDescription = Console.ReadLine();
                            Item itemEntity = toDoDbContext.Things.First(s => s.Description.Equals(placeHoldItem.Description));
                            //puts new description into selected item

                            itemEntity.Description = newDescription;
                            toDoDbContext.SaveChanges();
                            break;
                        }

                    case "done status":
                        {
                            Console.WriteLine("Press the corresponding key the change the status of the selected item.");
                            Console.WriteLine("1 - undone");
                            Console.WriteLine("2 - In_Progress");
                            Console.WriteLine("3 - Done");

                            //the user can change the status of a selected item
                            //this code allows the user to decide which enum value they want to set it to, using an integer

                            string BrandNewStatus = Console.ReadLine();
                            switch (BrandNewStatus)
                            {
                                case "1":
                                    placeHoldItem.DoneValue = DoneStatus.undone;
                                    toDoDbContext.SaveChanges();
                                    break;
                                case "2":
                                    placeHoldItem.DoneValue = DoneStatus.In_Progress;
                                    toDoDbContext.SaveChanges();
                                    break;
                                case "3":
                                    placeHoldItem.DoneValue = DoneStatus.done;
                                    toDoDbContext.SaveChanges();
                                    break;
                            }

                            break;
                        }
                }

            }




        }
    }
}








    
