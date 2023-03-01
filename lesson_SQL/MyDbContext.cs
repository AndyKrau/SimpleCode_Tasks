using System;
using System.Data.Entity;

namespace lesson_SQL
{
    public class MyDbContext: DbContext
    {
        protected MyDbContext() : base("DbConnectionString")
        {

        }
    }
}
