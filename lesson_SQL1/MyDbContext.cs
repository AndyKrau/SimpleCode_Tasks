using System;
using System.Data.Entity;

namespace lesson_SQL1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
