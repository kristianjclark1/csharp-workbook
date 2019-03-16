using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class BlogDbContext: DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        //Getting options specificially for DbContext
        {

        }

        public DbSet<Blog> Blogs { get; set; }

    }
}
