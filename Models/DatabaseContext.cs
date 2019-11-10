using System;
using Microsoft.EntityFrameworkCore;

namespace storygear_csharp.Models
{
    public class DatabaseContext
    {
        public class DataBaseContext : DbContext
        {
            public DataBaseContext(DbContextOptions<DataBaseContext> options) :
                base(options)
            { }
            public DbSet<Products> Products { get; set; }
        }
    }
}
