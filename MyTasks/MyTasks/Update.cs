using System;
using System.Collections.Generic;
namespace MyTasks
{//Update list by completing or deleting
    public class Update
    {
        public enum DoneStatus { undone, In_Progress, done }
        static void UpdateItem(ToDoDbContext toDoContext)
        {
            Console.WriteLine();
            //this method used to update items in list
            //it can be used to update the name, desc, or status of being finsihed

            ListAll(toDoContext);
            Console.WriteLine("Which item would you like to update?");
            Console.WriteLine("Please enter the ID of that item.");
            int idValue = Convert.ToInt32(Console.ReadLine());
            Item placeHoldItem = toDoContext.Items.Find(idValue);
            //This code allows user to select an item to change

            Console.WriteLine("Now which attribute would you like to update?");
            Console.WriteLine("Your choices are 'name', 'description', or 'done status'");

            string value = Console.ReadLine();
            //allows user to select an attribute of that selected item to update

            if (value == "name")
            {
                Console.WriteLine("What would you like this item's name to read?");
                string newName = Console.ReadLine();
                Item itemEntity = toDoContext.Items.First(s => s.name.Equals(placeHoldItem.name));
                //throws the new name into selected item

                itemEntity.name = newName;
                toDoContext.SaveChanges();
            }
            else if (value == "description")
            {
                Console.WriteLine("What would you like this item's description to read?");
                string newDescription = Console.ReadLine();
                Item itemEntity = toDoContext.Items.First(s => s.description.Equals(placeHoldItem.description));
                //throws new description into selected item

                itemEntity.description = newDescription;
                toDoContext.SaveChanges();
            }
            else if (value == "done status")
            {
                Console.WriteLine("Press the corresponding key to change status of selected item.");
                Console.WriteLine("1 - undone");
                Console.WriteLine("2 - In_Progress");
                Console.WriteLine("3 - Done");
                //User changes the status of selected item
                //this code allows the user to decide which enum value they want to set it to, use an integer

                string newStatusKey = Console.ReadLine();
                if (newStatusKey == "1")
                {
                    placeHoldItem.doneValue = DoneStatus.undone;
                    toDoContext.SaveChanges();
                }
                else if (newStatusKey == "2")
                {
                    placeHoldItem.doneValue = DoneStatus.In_Progress;
                    toDoContext.SaveChanges();
                }
                else if (newStatusKey == "3")
                {
                    placeHoldItem.doneValue = DoneStatus.done;
                    toDoContext.SaveChanges();
                }
            }
        }
    }
}
