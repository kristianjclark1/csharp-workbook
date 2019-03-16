using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace MyTasks
{
    internal class ToDoDbContext : DbContext
    {
        public ToDoDbContext( DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }
        public DbSet <Item> Things { get; set; }



    }   
}