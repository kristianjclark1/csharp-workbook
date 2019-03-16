using System;
namespace MyTasks
{//add or delete item
    
    public class Delete
    {
        static void DeleteItem(ToDoDbContext todoContext)
        {
            Console.WriteLine();
            //This method is used to delete items from your list

            ListAll(todoContext);
            Console.WriteLine("Which item would you like to delete?");
            Console.WriteLine("Please enter the ID of that item");

            int idValue = Convert.ToInt32(Console.ReadLine());

            Item placeHoldItem = todoContext.Items.Find(idValue);
            //creates a new item instance and finds/matches it item of matching id in DB set

            todoContext.Items.Remove(placeHoldItem);
            //removes selected item

            todoContext.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("What's next?");
            CommandList();
            HomeScreen(toDoContext);

        }

    }
}
