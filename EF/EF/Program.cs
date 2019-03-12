using System;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<BlogDbContext> builder = new DbContextOptionsBuilder<BlogDbContext>();
            builder.UseSqlServer("Server=127.0.0.1;Database=BlogDb;User Id=sa;Password=P@ssw0rd;");
            DbContextOptions<BlogDbContext> opts = builder.Options;
            BlogDbContext context = new BlogDbContext(opts);
            context.Database.EnsureCreated();
            //Creates database context
            Blog firstEntry = new Blog
            {
                Title = "First!",
                CreateDate = DateTime.Now,
                Content = "bump"
            };

            context.Blogs.Add(firstEntry);

            Console.WriteLine($"Value of Id before save: {firstEntry.Id}");

            context.SaveChanges();

            Console.WriteLine($"Value of Id after save: {firstEntry.Id}");
             
            foreach(var entry in context.Blogs)
            {
                Console.WriteLine(entry.Id + "->" + entry.Title + ":" + entry.Content);
            }



            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
